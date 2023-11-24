using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnet_rpg.Models
{
    [Table("Property_Type")]
    public class Property_Type
    {
        [Key]
        public int Id { get; set; }
        public string Property_Type_Name { get; set; }
        public int Property_Amount { get; set; }
        
    }
}
