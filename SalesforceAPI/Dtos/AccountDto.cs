using SalesforceAPI.Models;

namespace SalesforceAPI.Dtos
{
    public class AccountDto
    {
        public AccountAttributesDto? attributes { get; set; }
        public string? Id { get; set; }
        public string? Name { get; set; }
        public bool isAgency__c { get; set; }
        public bool isSite__c { get; set; }
        public bool isCMHSP__c { get; set; }
        public ShippingAddressDto? ShippingAddress { get; set; }
    }
}
