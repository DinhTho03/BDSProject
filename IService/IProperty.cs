using dotnet_rpg.Dtos;

namespace dotnet_rpg.IService
{
    public interface IProperty 
    {
        List<Property>  GetAll();
        Property Add(PropertyDto property);

    }
}
