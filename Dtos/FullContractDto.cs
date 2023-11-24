using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnet_rpg.Dtos
{
    public class FullContractDto
    {
       

        [Required]
        [MaxLength(50)]
        public string CustomerName { get; set; }

        public int? YearOfBirth { get; set; }

        [Required]
        [MaxLength(15)]
        public string SSN { get; set; }

        [MaxLength(100)]
        public string CustomerAddress { get; set; }

        [MaxLength(15)]
        public string Mobile { get; set; }

        [Required]
        public int PropertyID { get; set; }

        public DateTime? DateOfContract { get; set; }

        public decimal? Price { get; set; }

        public decimal? Deposit { get; set; }

        public decimal? Remain { get; set; }

        [Required]
        public bool Status { get; set; }
        
    }
}
