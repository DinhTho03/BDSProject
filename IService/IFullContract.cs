using dotnet_rpg.Dtos;
using System.Diagnostics.Contracts;

namespace dotnet_rpg.IService
{
    public interface IFullContract
    {
        List<Full_Contract> GetFull_Contracts();
        Full_Contract Add(FullContractDto contract);
    }
}
