using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace dotnet_rpg.Dtos
{
    public class PropertyDto
    {
        [StringLength(50)]
        public string Property_Name { get; set; }

        [Required]
        public int Property_Type_ID { get; set; }

        public string Description { get; set; }

        [Required]
        public int District_ID { get; set; }

        [StringLength(100)]
        public string Address { get; set; }

        public int? Area { get; set; }

        public int? Bed_Room { get; set; }

        public int? Bath_Room { get; set; }

        [Column(TypeName = "numeric(18,0)")]
        public decimal? Price { get; set; }

        public double? Installment_Rate { get; set; }

        public string Avatar { get; set; }

        public string Album { get; set; }

        [Required]
        public int Property_Status_ID { get; set; }


    }
}
