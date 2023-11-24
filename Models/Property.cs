using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_rpg.Models
{
    [Table("Property")]
    public class Property
    {
        [Key]
        public int ID { get; set; }

        [StringLength(7)]
        public string Property_Code { get; set; }

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