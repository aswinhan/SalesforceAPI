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
    public class PractitionerPSVController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly ProviderService _providerService;
        private readonly ILogger<PractitionerPSVController> _logger;
        public PractitionerPSVController(ApplicationDbContext context, ProviderService providerService, ILogger<PractitionerPSVController> logger)
        {
            _context = context;
            _providerService = providerService;
            _logger = logger;
        }

        // GET: PractitionerPSV/5
        [HttpGet("PractitionerPSV/{credentialingProfileId}")]
        public async Task<ActionResult> GetPractitionerPSV(string credentialingProfileId)
        {
            try
            {
                int? providerId = await _providerService.GetProviderIdAsync(credentialingProfileId);

                if (providerId.HasValue)
                {
                    var practitionerPSV = await _context.PractitionerPrimarySourceVerifications.AsNoTracking()
                                    .FirstOrDefaultAsync(x => x.ProviderId == providerId.Value);

                    if (practitionerPSV == null)
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
                                Url = "/services/data/v59.0/sobjects/Primary_Source_Verification__c",
                                ReferenceId = "newPSVRecord",
                                Body = new PractitionerPrimarySourceVerificationDto
                                {
                                    Credentialing_Profile__c = credentialingProfileId,
                                    Name = practitionerPSV.Name,
                                    PSV_Status__c = practitionerPSV.PSVStatus,
                                    Creation_Date__c = practitionerPSV.CreationDate,
                                    Completion_Date__c = practitionerPSV.CompletionDate,
                                    Verifier_s_Credentialing_Organization__c = practitionerPSV.VerifiersCredentialingOrganization,
                                    Other_Accred__c = practitionerPSV.OtherAccred,
                                    Provider_Name__c = practitionerPSV.ProviderName,
                                    Primary_Source_Verifier__c = practitionerPSV.PrimarySourceVerifier,
                                    OwnerId = practitionerPSV.OwnerId,
                                    LARA_License__c = practitionerPSV.LARALicense,
                                    MDHHS_Sanctioned_Provider_Check__c = practitionerPSV.MDHHSSanctionedProviderCheck,
                                    Office_of_Inspector_General_Check__c = practitionerPSV.OfficeofInspectorGeneralCheck,
                                    SAM_gov_Check__c = practitionerPSV.SAMgovCheck,
                                    Ichat_Background_Check__c = practitionerPSV.IchatBackgroundCheck,
                                    Workforce_Background_Check__c = practitionerPSV.WorkforceBackgroundCheck,
                                    Medicare_Base_Enrollment__c = practitionerPSV.MedicareBaseEnrollment,
                                    Medicare_Opt_Out__c = practitionerPSV.MedicareOptOut,
                                    LARA_Uploaded__c = practitionerPSV.LARAUploaded,
                                    Official_Transcript_from_Accredited_Scho__c = practitionerPSV.OfficialTranscriptfromAccreditedScho,
                                    Degree_Verification__c = practitionerPSV.DegreeVerification,
                                    ECFMG__c = practitionerPSV.ECFMG,
                                    AMA_Verification__c = practitionerPSV.AMAVerification,
                                    AOA_Verification__c = practitionerPSV.AOAVerification,
                                    MCBAP_Verification__c = practitionerPSV.MCBAPVerification,
                                    MI_Public_Sex_Offender_Registry_Check__c = practitionerPSV.MIPublicSexOffenderRegistryCheck,
                                    National_Sex_Offender_Registry_Check__c = practitionerPSV.NationalSexOffenderRegistryCheck
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
