using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnet_rpg.Models
{
    [Table("Service")]
    public class Service
    {
        [Key]
        public int Id { get; set; }
        public string Service_Name { get; set; }
    }
}
