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
    public class HospitalAffiliationsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly ProviderService _providerService;
        private readonly ILogger<HospitalAffiliationsController> _logger;
        public HospitalAffiliationsController(ApplicationDbContext context, ProviderService providerService, ILogger<HospitalAffiliationsController> logger)
        {
            _context = context;
            _providerService = providerService;
            _logger = logger;
        }

        // GET: HospitalAffiliation/5
        [HttpGet("HospitalAffiliation/{credentialingProfileId}")]
        public async Task<ActionResult> GetHospitalAffiliation(string credentialingProfileId)
        {
            try
            {
                int? providerId = await _providerService.GetProviderIdAsync(credentialingProfileId);

                if (providerId.HasValue)
                {
                    var hospitalAffiliation = await _context.HospitalAffiliations.AsNoTracking()
                                    .FirstOrDefaultAsync(x => x.ProviderId == providerId.Value);

                    if (hospitalAffiliation == null)
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
                                Method = "PATCH",
                                Url = "/services/data/v52.0/sobjects/Hospital_Affiliations__c/Id/a20BZ000001XXafYAG",
                                ReferenceId = "HA1",
                                Body = new HospitalAffiliationDto
                                {
                                    Credentialing_Profile_Id__c = credentialingProfileId,
                                    Category_of_Membership__c = hospitalAffiliation.CategoryofMembership,
                                    Hospital_Affiliation_Name__c = hospitalAffiliation.HospitalAffiliationName,
                                    Hospital_Affiliation_Address__c = hospitalAffiliation.HospitalAffiliationAddress,
                                    Start_Date_of_Affiliation__c = hospitalAffiliation.StartDateofAffiliation,
                                    End_Date_of_Affiliation__c = hospitalAffiliation.EndDateofAffiliation
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
