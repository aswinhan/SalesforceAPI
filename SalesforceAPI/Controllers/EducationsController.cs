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
    public class EducationsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly ProviderService _providerService;
        private readonly ILogger<EducationsController> _logger;
        public EducationsController(ApplicationDbContext context, ProviderService providerService, ILogger<EducationsController> logger)
        {
            _context = context;
            _providerService = providerService;
            _logger = logger;
        }

        // GET: Education/5
        [HttpGet("Education/{credentialingProfileId}")]
        public async Task<ActionResult> GetEducation(string credentialingProfileId)
        {
            try
            {
                int? providerId = await _providerService.GetProviderIdAsync(credentialingProfileId);

                if (providerId.HasValue)
                {
                    var education = await _context.Educations.AsNoTracking()
                                    .FirstOrDefaultAsync(x => x.ProviderId == providerId.Value);

                    if (education == null)
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
                                Url = "/services/data/v59.0/sobjects/Education__c",
                                ReferenceId = "eduRecord",
                                Body = new EducationDto
                                {
                                    Credentialing_Profile_ID__c = credentialingProfileId,
                                    Degree__c = education.Degree,
                                    College_University_Program_Name__c = education.CollegeUniversityProgramName,
                                    College_University_Program_Address__c = education.CollegeUniversityProgramAddress,
                                    Graduation_Date__c = education.GraduationDate
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
