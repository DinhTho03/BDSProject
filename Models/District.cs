using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnet_rpg.Models
{
    [Table("District")]
    public class District
    {
        [Key]
        public int Id { get; set; }
         public int City_Id { get; set; }
        public string District_Name { get; set;}
    }
}
