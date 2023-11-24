using dotnet_rpg.Data;
using dotnet_rpg.Dtos;
using dotnet_rpg.IService;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace dotnet_rpg.Services
{
    public class PropertyRepository : IProperty
    {
        private readonly DataContext _dataContext;

        public PropertyRepository(DataContext dataContext) 
        {
            _dataContext = dataContext;
        }

        public Property Add(PropertyDto property)
        {

            var propertyEntity = new Property
            {
                Property_Name = property.Property_Name,
                Property_Type_ID = property.Property_Type_ID,
                Description = property.Description,
                District_ID = property.District_ID,
                Address = property.Address,
                Area = property.Area,
                Bed_Room = property.Bed_Room,
                Bath_Room = property.Bath_Room,
                Price = property.Price,
                Album = property.Album,
                Avatar = property.Avatar,
                Installment_Rate = property.Installment_Rate,
                Property_Status_ID = property.Property_Status_ID,
            };
            
            int id = propertyEntity.ID;

            string namHienTai = DateTime.Now.ToString("yy");

            int max;
            if (_dataContext.Properties.Any())
            {
                max = _dataContext.Properties
                    .AsEnumerable() // Switch to in-memory processing
                    .Max(p => int.Parse(p.Property_Code.Substring(4))) + 1;
            }
            else
            {
                max = 1;
            }

            string msBDS = $"F{namHienTai}{max:D4}"; 

            propertyEntity.Property_Code = msBDS;
            _dataContext.Add(propertyEntity);
            _dataContext.SaveChanges();
            return propertyEntity;
        }

        public List<Property> GetAll()
        {
            var data = _dataContext.Properties.ToList();
            return data;
        }

        
    }
}
