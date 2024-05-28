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
    public class OrganizationalPSVController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly ProviderService _providerService;
        private readonly ILogger<OrganizationalPSVController> _logger;
        public OrganizationalPSVController(ApplicationDbContext context, ProviderService providerService, ILogger<OrganizationalPSVController> logger)
        {
            _context = context;
            _providerService = providerService;
            _logger = logger;
        }

        // GET: OrganizationalPSV/5
        [HttpGet("OrganizationalPSV/{credentialingProfileId}")]
        public async Task<ActionResult> GetOrganizationalPSV(string credentialingProfileId)
        {
            try
            {
                int? providerId = await _providerService.GetProviderIdAsync(credentialingProfileId);

                if (providerId.HasValue)
                {
                    var organizationalPSV = await _context.OrganizationalPrimarySourceVerifications.AsNoTracking()
                                    .FirstOrDefaultAsync(x => x.ProviderId == providerId.Value);

                    if (organizationalPSV == null)
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
                                ReferenceId = "PSV1",
                                Body = new OrganizationalPrimarySourceVerificationDto
                                {
                                    Credentialing_Profile__c = credentialingProfileId,
                                    Name = organizationalPSV.Name,
                                    PSV_Status__c = organizationalPSV.PSVStatus,
                                    Creation_Date__c = organizationalPSV.CreationDate,
                                    Completion_Date__c = organizationalPSV.CompletionDate,
                                    Verifier_s_Credentialing_Organization__c = organizationalPSV.VerifiersCredentialingOrganization,
                                    Other_Accred__c = organizationalPSV.OtherAccred,
                                    Provider_Name__c = organizationalPSV.ProviderName,
                                    Primary_Source_Verifier__c = organizationalPSV.PrimarySourceVerifier,
                                    OwnerId = organizationalPSV.OwnerId,
                                    LARA_License__c = organizationalPSV.LARALicense,
                                    MDHHS_Sanctioned_Provider_Check__c = organizationalPSV.MDHHSSanctionedProviderCheck,
                                    Office_of_Inspector_General_Check__c = organizationalPSV.OfficeofInspectorGeneralCheck,
                                    SAM_gov_Check__c = organizationalPSV.SAMgovCheck,
                                    Proof_of_Accreditation__c = organizationalPSV.ProofofAccreditation,
                                    Disciplinary_status_with_regulatory_boar__c = organizationalPSV.Disciplinarystatuswithregulatoryboar,
                                    At_least_five_year_history_of_organizati__c = organizationalPSV.Atleastfiveyearhistoryoforganizati,
                                    On_Site_Quality_Assessment_Recredential__c = organizationalPSV.OnSiteQualityAssessmentRecredential
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
