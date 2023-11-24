using dotnet_rpg.Data;
using dotnet_rpg.Dtos;
using dotnet_rpg.IService;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Diagnostics.Contracts;

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
            // Create City
            var city = new City { City_Name = property.City_Name };
            _dataContext.Cities.Add(city);
            _dataContext.SaveChanges();

            // Create District
            var district = new District
            {
                District_Name = property.District_Name,
                City_Id = city.Id
            };
            _dataContext.Districts.Add(district);
            _dataContext.SaveChanges();

            // Create Service
            var service = new Service
            {
                Service_Name = property.Service_Name,
            };
            _dataContext.Services.Add(service);
            _dataContext.SaveChanges();

            // Create Property_Status
            var status = new Property_Status
            {
                Property_Status_Name = property.Status
            };
            _dataContext.Property_Statuses.Add(status);
            _dataContext.SaveChanges();

            // Create Property_Type
            var type = new Property_Type
            {
                Property_Type_Name = property.Type,
                Property_Amount = 1,
            };
            _dataContext.property_Types.Add(type);
            _dataContext.SaveChanges();

            // Create Property entity
            var propertyEntity = new Property
            {
                Property_Name = property.Property_Name,
                Property_Type_ID = type.Id,
                Description = property.Description,
                Address = property.Address,
                Area = property.Area,
                Bed_Room = property.Bed_Room,
                Bath_Room = property.Bath_Room,
                Price = property.Price,
                Album = property.Album,
                Avatar = property.Avatar,
                Installment_Rate = property.Installment_Rate,
                District_ID = district.Id,
                Property_Status_ID = status.ID,
            };

            // Generate Property Code
            string namHienTai = DateTime.Now.ToString("yy");
            int max =  _dataContext.Properties
                    .AsEnumerable() // Switch to in-memory processing
                    .Max(p => int.Parse(p.Property_Code.Substring(4))) + 1;

            string msBDS = $"F{namHienTai}{max:D4}";
            propertyEntity.Property_Code = msBDS;

            // Add Property entity to the database
            _dataContext.Properties.Add(propertyEntity);
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
