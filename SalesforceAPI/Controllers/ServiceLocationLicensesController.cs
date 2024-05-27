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
    public class ServiceLocationLicensesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly ProviderService _providerService;
        private readonly ILogger<ServiceLocationLicensesController> _logger;
        public ServiceLocationLicensesController(ApplicationDbContext context, ProviderService providerService, ILogger<ServiceLocationLicensesController> logger)
        {
            _context = context;
            _providerService = providerService;
            _logger = logger;
        }

        // GET: ServiceLocationLicense/5
        [HttpGet("ServiceLocationLicense/{credentialingProfileId}")]
        public async Task<ActionResult> GetServiceLocationLicense(string credentialingProfileId)
        {
            try
            {
                int? providerId = await _providerService.GetProviderIdAsync(credentialingProfileId);

                if (providerId.HasValue)
                {
                    var serviceLocationLicense = await _context.ServiceLocationLicenses.AsNoTracking()
                                    .FirstOrDefaultAsync(x => x.ProviderId == providerId.Value);

                    if (serviceLocationLicense == null)
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
                                Url = "/services/data/v59.0/sobjects/Service_Location_License__c",
                                ReferenceId = "ServiceLocationLicense1",
                                Body = new ServiceLocationLicenseDto
                                {
                                    Credentialing_Profile__c = credentialingProfileId,
                                    Service_Locations__c = serviceLocationLicense.ServiceLocations,
                                    Service_Name__c = serviceLocationLicense.ServiceName,
                                    Service_License_Expiration_if_applicabl__c = serviceLocationLicense.ServiceLicenseExpirationifapplicabl,
                                    Service_License_Number_if_applicable__c = serviceLocationLicense.ServiceLicenseNumberifapplicable,
                                    Service_License_Status_if_applicable__c = serviceLocationLicense.ServiceLicenseStatusifapplicable
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
