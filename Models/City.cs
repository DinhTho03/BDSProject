using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnet_rpg.Models
{
    [Table("City")]
    public class City
    {
        [Key]
        public int Id { get; set; }

        public string City_Name { get; set; }
    }
}
