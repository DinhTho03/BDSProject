using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnet_rpg.Models
{
    [Table("Property_Service")]
    public class Property_Service
    {
        [Key]
        public int Id { get; set; }
        public int Service_ID { get; set; }
        public int Property_ID { get; set;}

    }
}
