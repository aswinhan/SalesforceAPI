using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SalesforceAPI.Controllers.Services;
using SalesforceAPI.Data;
using SalesforceAPI.Dtos;
using SalesforceAPI.Models;

namespace SalesforceAPI.Controllers
{
    [ApiController]
    public class PractitionerLicenseCertificationsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly ProviderService _providerService;
        private readonly ILogger<PractitionerLicenseCertificationsController> _logger;
        public PractitionerLicenseCertificationsController(ApplicationDbContext context, ProviderService providerService, ILogger<PractitionerLicenseCertificationsController> logger)
        {
            _context = context;
            _providerService = providerService;
            _logger = logger;
        }

        // GET: PractitionerLicenseCertification/5
        [HttpGet("PractitionerLicenseCertification/{credentialingProfileId}")]
        public async Task<ActionResult> GetPractitionerLicenseCertification(string credentialingProfileId)
        {
            try
            {
                int? providerId = await _providerService.GetProviderIdAsync(credentialingProfileId);

                if (providerId.HasValue)
                {
                    var practitionerLicenseCertification = await _context.PractitionerLicenseCertifications.AsNoTracking()
                                    .FirstOrDefaultAsync(x => x.ProviderId == providerId.Value);

                    if (practitionerLicenseCertification == null)
                    {
                        return NotFound();
                    }

                    var compositeRequest = new CompositeRequest
                    {
                        AllOrNone = true,
                        CompositeSubRequestList = new List<CompositeSubRequest>
                        {
                            new CompositeSubRequest
                            {
                                Method = "POST",
                                Url = "/services/data/v59.0/sobjects/Practitioner_Licenses_Certifications__c",
                                ReferenceId = "PLC1",
                                Body = new PractitionerLicenseCertificationDto
                                {
                                    Credentialing_Profile_Id__c = credentialingProfileId,
                                    RecordTypeId = practitionerLicenseCertification.RecordTypeId,
                                    LicenseCertification_Type__c = practitionerLicenseCertification.LicenseCertificationType,
                                    License_Types_LARA__c = practitionerLicenseCertification.LicenseTypesLARA,
                                    Other_License_Type__c = practitionerLicenseCertification.OtherLicenseType,
                                    Board_Certifications__c = practitionerLicenseCertification.BoardCertifications,
                                    Other_Board_Certification__c = practitionerLicenseCertification.OtherBoardCertification,
                                    Nursing_Certifications__c = practitionerLicenseCertification.NursingCertifications,
                                    Expiration_Date__c = practitionerLicenseCertification.ExpirationDate,
                                    File_Uploaded__c = practitionerLicenseCertification.FileUploaded,
                                    LicenseCertification_Status__c = practitionerLicenseCertification.LicenseCertificationStatus
                                }
                            }
                        }
                    };

                    return new JsonResult(compositeRequest);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while fetching the education record.");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
