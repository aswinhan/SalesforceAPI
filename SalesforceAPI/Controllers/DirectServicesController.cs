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
    public class DirectServicesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly ProviderService _providerService;
        private readonly ILogger<DirectServicesController> _logger;
        public DirectServicesController(ApplicationDbContext context, ProviderService providerService, ILogger<DirectServicesController> logger)
        {
            _context = context;
            _providerService = providerService;
            _logger = logger;
        }

        // GET: DirectService/5
        [HttpGet("DirectService/{credentialingProfileId}")]
        public async Task<ActionResult> GetDirectService(string credentialingProfileId)
        {
            try
            {
                int? providerId = await _providerService.GetProviderIdAsync(credentialingProfileId);

                if (providerId.HasValue)
                {
                    var directService = await _context.DirectServices.AsNoTracking()
                                    .FirstOrDefaultAsync(x => x.ProviderId == providerId.Value);

                    if (directService == null)
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
                                Url = "/services/data/v52.0/sobjects/Direct_Service__c",
                                ReferenceId = "DirectService1",
                                Body = new DirectServiceDto
                                {
                                    Operator__c = directService.Operator,
                                    Service__c = directService.Service,
                                    is_Certification__c = directService.IsCertification
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
