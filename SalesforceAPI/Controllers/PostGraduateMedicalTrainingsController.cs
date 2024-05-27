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
    public class PostGraduateMedicalTrainingsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly ProviderService _providerService;
        private readonly ILogger<PostGraduateMedicalTrainingsController> _logger;
        public PostGraduateMedicalTrainingsController(ApplicationDbContext context, ProviderService providerService, ILogger<PostGraduateMedicalTrainingsController> logger)
        {
            _context = context;
            _providerService = providerService;
            _logger = logger;
        }

        // GET: PostGraduateMedicalTraining/5
        [HttpGet("PostGraduateMedicalTraining/{credentialingProfileId}")]
        public async Task<ActionResult> GetPostGraduateMedicalTraining(string credentialingProfileId)
        {
            try
            {
                int? providerId = await _providerService.GetProviderIdAsync(credentialingProfileId);

                if (providerId.HasValue)
                {
                    var postGraduateMedicalTraining = await _context.PostGraduateMedicalTrainings.AsNoTracking()
                                    .FirstOrDefaultAsync(x => x.ProviderId == providerId.Value);

                    if (postGraduateMedicalTraining == null)
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
                                Url = "/services/data/v59.0/sobjects/Post_Graduate_Medical_Training__c",
                                ReferenceId = "PGMT1",
                                Body = new PostGraduateMedicalTrainingDto
                                {
                                    Credentialing_Profile_Id__c = credentialingProfileId,
                                    Medical_Training_Hospital_Address__c = postGraduateMedicalTraining.MedicalTrainingHospitalAddress,
                                    Medical_Training_Hospital_Name__c = postGraduateMedicalTraining.MedicalTrainingHospitalName,
                                    Medical_Training_Type__c = postGraduateMedicalTraining.MedicalTrainingType,
                                    Specialty__c = postGraduateMedicalTraining.Specialty,
                                    Training_Start_Date__c = postGraduateMedicalTraining.TrainingStartDate,
                                    Training_End_Date__c = postGraduateMedicalTraining.TrainingEndDate
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
