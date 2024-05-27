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
    public class CredentialingContactsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly ProviderService _providerService;
        private readonly ILogger<CredentialingContactsController> _logger;
        public CredentialingContactsController(ApplicationDbContext context, ProviderService providerService, ILogger<CredentialingContactsController> logger)
        {
            _context = context;
            _providerService = providerService;
            _logger = logger;
        }

        // GET: CredentialingContact/5
        [HttpGet("CredentialingContact/{credentialingProfileId}")]
        public async Task<ActionResult> GetCredentialingContact(string credentialingProfileId)
        {
            try
            {
                int? providerId = await _providerService.GetProviderIdAsync(credentialingProfileId);

                if (providerId.HasValue)
                {
                    var credentialingContact = await _context.CredentialingContacts.AsNoTracking()
                                    .FirstOrDefaultAsync(x => x.ProviderId == providerId.Value);

                    if (credentialingContact == null)
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
                                Url = "/services/data/v52.0/sobjects/Credentialing_Contacts__c",
                                ReferenceId = "CredContact",
                                Body = new CredentialingContactDto
                                {
                                    Credentialing_Profile_Id__c = credentialingProfileId,
                                    Contact_First_Name__c = credentialingContact.ContactFirstName,
                                    Contact_Last_Name__c = credentialingContact.ContactLastName,
                                    Contact_Email__c = credentialingContact.ContactEmail,
                                    Contact_Person_Role__c = credentialingContact.ContactPersonRole,
                                    Contact_Phone__c = credentialingContact.ContactPhone,
                                    Primary_Contact__c = credentialingContact.PrimaryContact
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
