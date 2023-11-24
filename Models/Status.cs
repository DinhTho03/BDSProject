using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnet_rpg.Models
{
    [Table("Property_Status")]
    public class Property_Status
    {
        [Key]
        public int ID { get; set; }
        public string Property_Status_Name { get; set; }
        
    }
}
