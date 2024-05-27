
using AutoMapper;
using SalesforceAPI.Dtos;
using SalesforceAPI.Models;
namespace SalesforceAPI.Profiles
{
    public class DtoProfile: Profile
    {
        public DtoProfile()
        {
            CreateMap<AccountAttributes, AccountAttributesDto>();
            CreateMap<Account, AccountDto>();
            CreateMap<CredentialingContact, CredentialingContactDto>();
            CreateMap<DirectService, DirectServiceDto>();
            CreateMap<Education, EducationDto>();
            CreateMap<HospitalAffiliation, HospitalAffiliationDto>();
            CreateMap<PostGraduateMedicalTraining, PostGraduateMedicalTrainingDto>();
            CreateMap<ServiceLocation, ServiceLocationDto>();
            CreateMap<ServiceLocationLicense, ServiceLocationLicenseDto>();
            CreateMap<ShippingAddress, ShippingAddressDto>();
        }
    }
}
