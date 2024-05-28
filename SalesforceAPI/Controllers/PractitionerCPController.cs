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
    public class PractitionerCPController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly ProviderService _providerService;
        private readonly ILogger<PractitionerCPController> _logger;
        public PractitionerCPController(ApplicationDbContext context, ProviderService providerService, ILogger<PractitionerCPController> logger)
        {
            _context = context;
            _providerService = providerService;
            _logger = logger;
        }

        // GET: PractitionerCP/5
        [HttpGet("PractitionerCP/{credentialingProfileId}")]
        public async Task<ActionResult> GetPractitionerCP(string credentialingProfileId)
        {
            try
            {
                int? providerId = await _providerService.GetProviderIdAsync(credentialingProfileId);

                if (providerId.HasValue)
                {
                    var practitionerCP = await _context.PractitionerCredentialingProfiles.AsNoTracking()
                                    .FirstOrDefaultAsync(x => x.ProviderId == providerId.Value);

                    if (practitionerCP == null)
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
                                Url = "/services/data/v59.0/sobjects/Credentialing_Profile__c",
                                ReferenceId = "thisCredentialingProfile",
                                Body = new PractitionerCredentialingProfileDto
                                {
                                    First_Name__c = practitionerCP.FirstName,
                                    Last_Name__c = practitionerCP.LastName,
                                    Date_of_Birth__c = practitionerCP.DateofBirth,
                                    Tax_ID__c = practitionerCP.TaxID,
                                    Medicare_Provider__c = practitionerCP.MedicareProvider,
                                    Medicare_Number__c = practitionerCP.MedicareNumber,
                                    Provider_Name__c = practitionerCP.ProviderName,
                                    Practitioner_NPI__c = practitionerCP.PractitionerNPI,
                                    Office_Address_Street_1__c = practitionerCP.OfficeAddressStreet1,
                                    Office_Address_Street_2__c = practitionerCP.OfficeAddressStreet2,
                                    Office_Address_City__c = practitionerCP.OfficeAddressCity,
                                    Office_Address_Zipcode__c = practitionerCP.OfficeAddressZipcode,
                                    Office_Address_State__c = practitionerCP.OfficeAddressState,
                                    Office_Address_County__c = practitionerCP.OfficeAddressCounty,
                                    Home_Address_Street_1__c = practitionerCP.HomeAddressStreet1,
                                    Home_Address_Street_2__c = practitionerCP.HomeAddressStreet2,
                                    Home_Address_City__c = practitionerCP.HomeAddressCity,
                                    Home_Address_Zipcode__c = practitionerCP.HomeAddressZipcode,
                                    Home_Address_State__c = practitionerCP.HomeAddressState,
                                    Home_Address_County__c = practitionerCP.HomeAddressCounty,
                                    Specialties__c = practitionerCP.Specialties,
                                    Other_Specialty__c = practitionerCP.OtherSpecialty,
                                    Certificate_of_Liability__c = practitionerCP.CertificateofLiability,
                                    Certificate_of_Liability_Expiration_Date__c = practitionerCP.CertificateofLiabilityExpirationDate,
                                    Current_Malpractice_Insurance_Coverage__c = practitionerCP.CurrentMalpracticeInsuranceCoverage,
                                    Explanation_Current_Malpractice__c = practitionerCP.ExplanationCurrentMalpractice,
                                    File_Malpractice_Insurance_Coverage__c = practitionerCP.FileMalpracticeInsuranceCoverage,
                                    MalpracticeInsurance_Coverage_Expiration__c = practitionerCP.MalpracticeInsuranceCoverageExpiration,
                                    Languages_Spoken__c = practitionerCP.LanguagesSpoken,
                                    Cultural_Competences__c = practitionerCP.CulturalCompetences,
                                    Five_year_work_history__c = practitionerCP.Fiveyearworkhistory,
                                    X6_month_gap_in_employment_since_profess__c = practitionerCP.X6monthgapinemploymentsinceprofess,
                                    X6_Month_Gap_Start_Date__c = practitionerCP.X6MonthGapStartDate,
                                    X6_Month_Gap_End_Date__c = practitionerCP.X6MonthGapEndDate,
                                    X6_Month_Gap_Activity__c = practitionerCP.X6MonthGapActivity,
                                    X6_Month_Gap_Reason__c = practitionerCP.X6MonthGapReason,
                                    Can_you_perform_the_essential_duties_of__c = practitionerCP.Canyouperformtheessentialdutiesof,
                                    Reason_for_inability_to_perform_essentia__c = practitionerCP.Reasonforinabilitytoperformessentia,
                                    Lack_of_present_illegal_drug_use__c = practitionerCP.Lackofpresentillegaldruguse,
                                    Explanation_Lackofpresentillegaldrug__c = practitionerCP.ExplanationLackofpresentillegaldrug,
                                    History_of_loss_of_license__c = practitionerCP.Historyoflossoflicense,
                                    ExplanationHistoryoflossoflicense__c = practitionerCP.ExplanationHistoryoflossoflicense,
                                    History_of_felony_convictions__c = practitionerCP.Historyoffelonyconvictions,
                                    ExplanationHistory_of_felony_convictions__c = practitionerCP.ExplanationHistoryoffelonyconvictions,
                                    History_of_loss_or_limitations_of_privil__c = practitionerCP.Historyoflossorlimitationsofprivil,
                                    ExplanationHistory_of_loss__c = practitionerCP.ExplanationHistoryofloss,
                                    Attestation_by_the_applicant_of_the_corr__c = practitionerCP.AttestationByTheApplicantOfTheCorr,
                                    Cultural_Competencies_Picklist__c = practitionerCP.CulturalCompetenciesPicklist,
                                    Please_acknowledge_If_denied_credential__c = practitionerCP.PleaseacknowledgeIfdeniedcredential,
                                    Summary_of_Changes__c = practitionerCP.SummaryofChanges,
                                    Submission_Date__c = practitionerCP.SubmissionDate
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
