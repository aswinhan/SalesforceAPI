using System.ComponentModel.DataAnnotations;
using static SalesforceAPI.Dtos.PractitionerLicenseCertificationDto;

namespace SalesforceAPI.Models
{
    public class PractitionerLicenseCertification
    {
        [Key]
        public int Id { get; set; }
        public int ProviderId { get; set; }
        public string? RecordTypeId { get; set; }
        public LicenseCertificationTypeCEnum? LicenseCertificationType { get; set; }
        public LicenseTypesLARACEnum? LicenseTypesLARA { get; set; }
        public string? OtherLicenseType { get; set; }
        public BoardCertificationsCEnum? BoardCertifications { get; set; }
        public string? OtherBoardCertification { get; set; }
        public NursingCertificationsCEnum? NursingCertifications { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool FileUploaded { get; set; }
        public LicenseCertificationStatusCEnum? LicenseCertificationStatus { get; set; }
    }
}
