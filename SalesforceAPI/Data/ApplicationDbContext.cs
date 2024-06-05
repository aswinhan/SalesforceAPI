using Microsoft.EntityFrameworkCore;
using SalesforceAPI.Models;

namespace SalesforceAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountAttributes> AccountAttributes { get; set; }
        public DbSet<ClientInfo> ClientInfos { get; set; }
        public DbSet<ClientProviderInfo> ClientProviderInfos { get; set; }
        public DbSet<CredentialingContact> CredentialingContacts { get; set; }
        public DbSet<DirectService> DirectServices { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<HospitalAffiliation> HospitalAffiliations { get; set; }
        public DbSet<PostGraduateMedicalTraining> PostGraduateMedicalTrainings { get; set; }
        public DbSet<OrganizationalPrimarySourceVerification> OrganizationalPrimarySourceVerifications { get; set; }
        public DbSet<PractitionerLicenseCertification> PractitionerLicenseCertifications { get; set; }
        public DbSet<PractitionerPrimarySourceVerification> PractitionerPrimarySourceVerifications { get; set; }
        public DbSet<PractitionerCredentialingProfile> PractitionerCredentialingProfiles { get; set; }
        public DbSet<ServiceLocation> ServiceLocations { get; set; }
        public DbSet<ServiceLocationLicense> ServiceLocationLicenses { get; set; }
        public DbSet<ProviderKey> ProviderKeys { get; set; }
        public DbSet<ShippingAddress> ShippingAddress { get; set; }
        public DbSet<ContentVersion> ContentVersions { get; set; }
    }
}
