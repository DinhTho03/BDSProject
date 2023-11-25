using dotnet_rpg.Data;
using dotnet_rpg.Dtos;
using dotnet_rpg.IService;
using dotnet_rpg.Models;

namespace dotnet_rpg.Services
{
    public class FullContractRepository : IFullContract
    {
        private readonly DataContext _dataContext;

        public FullContractRepository(DataContext dataContext) 
        {
            _dataContext = dataContext;
        }

        public Full_Contract Add(FullContractDto contract)
        {
            var fullContractEntity = new Full_Contract
            {
                CustomerName = contract.CustomerName,
                YearOfBirth = contract.YearOfBirth,
                SSN = contract.SSN,
                CustomerAddress = contract.CustomerAddress,
                Mobile = contract.Mobile,
                PropertyID = contract.PropertyID,
                DateOfContract = DateTime.Now,
                Price = contract.Price,
                Deposit = contract.Deposit, 
                Remain = contract.Price, 
                Status = contract.Status,
            };

            

            int id = fullContractEntity.ID; 

            string namHienTai = DateTime.Now.ToString("yy");

            int max;
            if (_dataContext.Full_Contract.Any())
            {
                max = _dataContext.Full_Contract
                    .AsEnumerable() // Switch to in-memory processing
                    .Max(fc => int.TryParse(fc.FullContractCode.Substring(6), out int value) ? value : 0) + 1;
            }
            else
            {
                max = 1;
            }

            string msBDS = $"HD.{namHienTai}.{max:D4}";

            fullContractEntity.FullContractCode = msBDS;
            _dataContext.Add(fullContractEntity);
            _dataContext.SaveChanges();

            return fullContractEntity;
        }

         
        public List<Full_Contract> GetFull_Contracts()
        {
            return _dataContext.Full_Contract.ToList();
        }
    }
}
