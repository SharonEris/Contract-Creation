using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.General;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContractManagementSystem.Models
{
    public enum ContractStatus
    {
        Active, Pending, Rejected, Expired
    }
    public class Contract
    {
        [Key]
        public int ContractId { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EndDate { get; set; }

        public required string ContractType { get; set; }

        public required string ContractedParty { get; set; }
        [Required]
        public decimal ContractValue { get; set; }
        [Required]
        public required string PaymentStructure { get; set; }
        [Required]


        public ContractStatus Status { get; set; } = ContractStatus.Pending;
        [Required]

        public string? ContractFile { get; set; }

        





    }
}
