using System;
using System.ComponentModel.DataAnnotations;

namespace ContractMonthlyClaimSystem.Models
{
    public class Claim
    {
        public int ClaimId { get; set; }

        [Required]
        [Display(Name = "Lecturer Name")]
        public string LecturerName { get; set; }

        [Required]
        [Display(Name = "Claim Period From")]
        [DataType(DataType.Date)]
        public DateTime ClaimPeriodFrom { get; set; }

        [Required]
        [Display(Name = "Claim Period To")]
        [DataType(DataType.Date)]
        public DateTime ClaimPeriodTo { get; set; }

        [Display(Name = "Module Code")]
        public string ModuleCode { get; set; }

        [Required]
        [Display(Name = "Rate")]
        public decimal Rate { get; set; }

        public decimal Total { get; set; }

        [Required]
        public string Status { get; set; } = "Pending"; // Pending, Verified, Approved
    }
}

