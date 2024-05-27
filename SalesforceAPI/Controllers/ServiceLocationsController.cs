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
    public class ServiceLocationsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly ProviderService _providerService;
        private readonly ILogger<ServiceLocationsController> _logger;
        public ServiceLocationsController(ApplicationDbContext context, ProviderService providerService, ILogger<ServiceLocationsController> logger)
        {
            _context = context;
            _providerService = providerService;
            _logger = logger;
        }

        // GET: ServiceLocation/5
        [HttpGet("ServiceLocation/{credentialingProfileId}")]
        public async Task<ActionResult> GetServiceLocation(string credentialingProfileId)
        {
            try
            {
                int? providerId = await _providerService.GetProviderIdAsync(credentialingProfileId);

                if (providerId.HasValue)
                {
                    var serviceLocation = await _context.ServiceLocations.AsNoTracking()
                                    .FirstOrDefaultAsync(x => x.ProviderId == providerId.Value);

                    if (serviceLocation == null)
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
                                Url = "/services/data/v59.0/sobjects/Service_Locations__c",
                                ReferenceId = "ServiceLocation1",
                                Body = new ServiceLocationDto
                                {
                                    Credentialing_Profile__c = credentialingProfileId,
                                    Account_Site__c = serviceLocation.AccountSite,
                                    Account__c = serviceLocation.Account,
                                    Facility_License_if_applicable__c = serviceLocation.FacilityLicenseifapplicable,
                                    Facility_License_Expiration_if_applicab__c = serviceLocation.FacilityLicenseExpirationifapplicab,
                                    Facility_License_Number_if_applicable__c = serviceLocation.FacilityLicenseNumberifapplicable,
                                    Facility_License_Status_if_applicable__c = serviceLocation.FacilityLicenseStatusifapplicable,
                                    Hours_of_Operation__c = serviceLocation.HoursofOperation,
                                    Accomodations_Accessibility__c = serviceLocation.AccomodationsAccessibility,
                                    Accomodations_Accessibility_Other__c = serviceLocation.AccomodationsAccessibilityOther,
                                    Licensed_Facility__c =  serviceLocation.LicensedFacility
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
