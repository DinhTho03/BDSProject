using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_rpg.Models
{
    [Table("Full_Contract")]
    public class Full_Contract
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int ID { get; set; }

        [MaxLength(10)]
        [Column("Full_Contract_Code")]
        public string FullContractCode { get; set; }

        [Required]
        [MaxLength(50)]
        [Column("Customer_Name")]
        public string CustomerName { get; set; }

        [Column("Year_Of_Birth")]
        public int? YearOfBirth { get; set; }

        [Required]
        [MaxLength(15)]
        [Column("SSN")]
        public string SSN { get; set; }

        [MaxLength(100)]
        [Column("Customer_Address")]
        public string CustomerAddress { get; set; }

        [MaxLength(15)]
        [Column("Mobile")]
        public string Mobile { get; set; }

        [Required]
        [Column("Property_ID")]
        public int PropertyID { get; set; }

        [Column("Date_Of_Contract")]
        public DateTime? DateOfContract { get; set; }

        [Column("Price")]
        public decimal? Price { get; set; }

        [Column("Deposit")]
        public decimal? Deposit { get; set; }

        [Column("Remain")]
        public decimal? Remain { get; set; }

        [Required]
        [Column("Status")]
        public bool Status { get; set; }


    }
}