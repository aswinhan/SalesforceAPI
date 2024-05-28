﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SalesforceAPI.Data;

#nullable disable

namespace SalesforceAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240528063644_addtablesnew")]
    partial class addtablesnew
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SalesforceAPI.Models.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AttributesId")
                        .HasColumnType("int");

                    b.Property<bool>("IsAgency")
                        .HasColumnType("bit");

                    b.Property<bool>("IsCMHSP")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSite")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProviderId")
                        .HasColumnType("int");

                    b.Property<int?>("ShippingAddressId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AttributesId");

                    b.HasIndex("ShippingAddressId");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("SalesforceAPI.Models.AccountAttributes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AccountAttributes");
                });

            modelBuilder.Entity("SalesforceAPI.Models.ClientInfo", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClientId"));

                    b.Property<byte?>("ActiveInd")
                        .HasColumnType("tinyint");

                    b.Property<string>("ClientCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ClientGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ClientName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClientType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CredPeriod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DBAName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("EffectiveDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModUserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PanelSize")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ParentClientId")
                        .HasColumnType("int");

                    b.Property<byte?>("Selectable")
                        .HasColumnType("tinyint");

                    b.Property<DateTime?>("SignatureDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("TaxID")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClientId");

                    b.ToTable("ClientInfos");
                });

            modelBuilder.Entity("SalesforceAPI.Models.ClientProviderInfo", b =>
                {
                    b.Property<int>("ClientProviderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClientProviderId"));

                    b.Property<int?>("ClientId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModUserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProviderId")
                        .HasColumnType("int");

                    b.HasKey("ClientProviderId");

                    b.ToTable("ClientProviderInfos");
                });

            modelBuilder.Entity("SalesforceAPI.Models.CredentialingContact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ContactEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactFirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactLastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ContactPersonRole")
                        .HasColumnType("int");

                    b.Property<string>("ContactPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("PrimaryContact")
                        .HasColumnType("bit");

                    b.Property<int>("ProviderId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CredentialingContacts");
                });

            modelBuilder.Entity("SalesforceAPI.Models.DirectService", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsCertification")
                        .HasColumnType("bit");

                    b.Property<string>("Operator")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProviderId")
                        .HasColumnType("int");

                    b.Property<string>("Service")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DirectServices");
                });

            modelBuilder.Entity("SalesforceAPI.Models.Education", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CollegeUniversityProgramAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CollegeUniversityProgramName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Degree")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("GraduationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProviderId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Educations");
                });

            modelBuilder.Entity("SalesforceAPI.Models.HospitalAffiliation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CategoryofMembership")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDateofAffiliation")
                        .HasColumnType("datetime2");

                    b.Property<string>("HospitalAffiliationAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HospitalAffiliationName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProviderId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDateofAffiliation")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("HospitalAffiliations");
                });

            modelBuilder.Entity("SalesforceAPI.Models.OrganizationalPrimarySourceVerification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool?>("Atleastfiveyearhistoryoforganizati")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CompletionDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CredentialingProfile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Disciplinarystatuswithregulatoryboar")
                        .HasColumnType("bit");

                    b.Property<int?>("LARALicense")
                        .HasColumnType("int");

                    b.Property<bool?>("MDHHSSanctionedProviderCheck")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("OfficeofInspectorGeneralCheck")
                        .HasColumnType("bit");

                    b.Property<bool?>("OnSiteQualityAssessmentRecredential")
                        .HasColumnType("bit");

                    b.Property<string>("OtherAccred")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OwnerId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PSVStatus")
                        .HasColumnType("int");

                    b.Property<string>("PrimarySourceVerifier")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("ProofofAccreditation")
                        .HasColumnType("bit");

                    b.Property<int>("ProviderId")
                        .HasColumnType("int");

                    b.Property<string>("ProviderName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("SAMgovCheck")
                        .HasColumnType("bit");

                    b.Property<int?>("VerifiersCredentialingOrganization")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("OrganizationalPrimarySourceVerifications");
                });

            modelBuilder.Entity("SalesforceAPI.Models.PostGraduateMedicalTraining", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("MedicalTrainingHospitalAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MedicalTrainingHospitalName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MedicalTrainingType")
                        .HasColumnType("int");

                    b.Property<int>("ProviderId")
                        .HasColumnType("int");

                    b.Property<string>("Specialty")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TrainingEndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TrainingStartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("PostGraduateMedicalTrainings");
                });

            modelBuilder.Entity("SalesforceAPI.Models.PractitionerCredentialingProfile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AttestationByTheApplicantOfTheCorr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Canyouperformtheessentialdutiesof")
                        .HasColumnType("int");

                    b.Property<bool>("CertificateofLiability")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CertificateofLiabilityExpirationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CulturalCompetences")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CulturalCompetenciesPicklist")
                        .HasColumnType("int");

                    b.Property<int?>("CurrentMalpracticeInsuranceCoverage")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateofBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("ExplanationCurrentMalpractice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExplanationHistoryoffelonyconvictions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExplanationHistoryofloss")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExplanationHistoryoflossoflicense")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExplanationLackofpresentillegaldrug")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("FileMalpracticeInsuranceCoverage")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Fiveyearworkhistory")
                        .HasColumnType("bit");

                    b.Property<string>("Historyoffelonyconvictions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Historyoflossoflicense")
                        .HasColumnType("int");

                    b.Property<string>("Historyoflossorlimitationsofprivil")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomeAddressCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomeAddressCounty")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomeAddressState")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomeAddressStreet1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomeAddressStreet2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomeAddressZipcode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Lackofpresentillegaldruguse")
                        .HasColumnType("int");

                    b.Property<string>("LanguagesSpoken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("MalpracticeInsuranceCoverageExpiration")
                        .HasColumnType("datetime2");

                    b.Property<int?>("MedicareNumber")
                        .HasColumnType("int");

                    b.Property<bool?>("MedicareProvider")
                        .HasColumnType("bit");

                    b.Property<string>("OfficeAddressCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OfficeAddressCounty")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OfficeAddressState")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OfficeAddressStreet1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OfficeAddressStreet2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OfficeAddressZipcode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OtherSpecialty")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PleaseacknowledgeIfdeniedcredential")
                        .HasColumnType("bit");

                    b.Property<string>("PractitionerNPI")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProviderId")
                        .HasColumnType("int");

                    b.Property<string>("ProviderName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Reasonforinabilitytoperformessentia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Specialties")
                        .HasColumnType("int");

                    b.Property<DateTime>("SubmissionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SummaryofChanges")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TaxID")
                        .HasColumnType("int");

                    b.Property<string>("X6MonthGapActivity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("X6MonthGapEndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("X6MonthGapReason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("X6MonthGapStartDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("X6monthgapinemploymentsinceprofess")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("PractitionerCredentialingProfiles");
                });

            modelBuilder.Entity("SalesforceAPI.Models.PractitionerLicenseCertification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("BoardCertifications")
                        .HasColumnType("int");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("FileUploaded")
                        .HasColumnType("bit");

                    b.Property<int?>("LicenseCertificationStatus")
                        .HasColumnType("int");

                    b.Property<int?>("LicenseCertificationType")
                        .HasColumnType("int");

                    b.Property<int?>("LicenseTypesLARA")
                        .HasColumnType("int");

                    b.Property<int?>("NursingCertifications")
                        .HasColumnType("int");

                    b.Property<string>("OtherBoardCertification")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OtherLicenseType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProviderId")
                        .HasColumnType("int");

                    b.Property<string>("RecordTypeId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PractitionerLicenseCertifications");
                });

            modelBuilder.Entity("SalesforceAPI.Models.PractitionerPrimarySourceVerification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("AMAVerification")
                        .HasColumnType("bit");

                    b.Property<bool>("AOAVerification")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CompletionDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("DegreeVerification")
                        .HasColumnType("bit");

                    b.Property<bool>("ECFMG")
                        .HasColumnType("bit");

                    b.Property<bool>("IchatBackgroundCheck")
                        .HasColumnType("bit");

                    b.Property<int?>("LARALicense")
                        .HasColumnType("int");

                    b.Property<bool>("LARAUploaded")
                        .HasColumnType("bit");

                    b.Property<bool>("MCBAPVerification")
                        .HasColumnType("bit");

                    b.Property<bool>("MDHHSSanctionedProviderCheck")
                        .HasColumnType("bit");

                    b.Property<bool>("MIPublicSexOffenderRegistryCheck")
                        .HasColumnType("bit");

                    b.Property<bool>("MedicareBaseEnrollment")
                        .HasColumnType("bit");

                    b.Property<bool>("MedicareOptOut")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("NationalSexOffenderRegistryCheck")
                        .HasColumnType("bit");

                    b.Property<bool>("OfficeofInspectorGeneralCheck")
                        .HasColumnType("bit");

                    b.Property<bool>("OfficialTranscriptfromAccreditedScho")
                        .HasColumnType("bit");

                    b.Property<string>("OtherAccred")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OwnerId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PSVStatus")
                        .HasColumnType("int");

                    b.Property<string>("PrimarySourceVerifier")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProviderId")
                        .HasColumnType("int");

                    b.Property<string>("ProviderName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SAMgovCheck")
                        .HasColumnType("bit");

                    b.Property<int?>("VerifiersCredentialingOrganization")
                        .HasColumnType("int");

                    b.Property<bool>("WorkforceBackgroundCheck")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("PractitionerPrimarySourceVerifications");
                });

            modelBuilder.Entity("SalesforceAPI.Models.ProviderKey", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CredentialingProfileId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EncompassID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("PractitionerGUID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ProviderId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ProviderKeys");
                });

            modelBuilder.Entity("SalesforceAPI.Models.ServiceLocation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AccomodationsAccessibility")
                        .HasColumnType("int");

                    b.Property<string>("AccomodationsAccessibilityOther")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Account")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccountSite")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FacilityLicenseExpirationifapplicab")
                        .HasColumnType("datetime2");

                    b.Property<string>("FacilityLicenseNumberifapplicable")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FacilityLicenseStatusifapplicable")
                        .HasColumnType("int");

                    b.Property<bool>("FacilityLicenseifapplicable")
                        .HasColumnType("bit");

                    b.Property<string>("HoursofOperation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LicensedFacility")
                        .HasColumnType("bit");

                    b.Property<int>("ProviderId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ServiceLocations");
                });

            modelBuilder.Entity("SalesforceAPI.Models.ServiceLocationLicense", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ProviderId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ServiceLicenseExpirationifapplicabl")
                        .HasColumnType("datetime2");

                    b.Property<string>("ServiceLicenseNumberifapplicable")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ServiceLicenseStatusifapplicable")
                        .HasColumnType("int");

                    b.Property<string>("ServiceLocations")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServiceName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ServiceLocationLicenses");
                });

            modelBuilder.Entity("SalesforceAPI.Models.ShippingAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ProviderId")
                        .HasColumnType("int");

                    b.Property<string>("city")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("geocodeAccuracy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("latitude")
                        .HasColumnType("float");

                    b.Property<double?>("longitude")
                        .HasColumnType("float");

                    b.Property<string>("postalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("state")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("street")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ShippingAddress");
                });

            modelBuilder.Entity("SalesforceAPI.Models.Account", b =>
                {
                    b.HasOne("SalesforceAPI.Models.AccountAttributes", "Attributes")
                        .WithMany()
                        .HasForeignKey("AttributesId");

                    b.HasOne("SalesforceAPI.Models.ShippingAddress", "ShippingAddress")
                        .WithMany()
                        .HasForeignKey("ShippingAddressId");

                    b.Navigation("Attributes");

                    b.Navigation("ShippingAddress");
                });
#pragma warning restore 612, 618
        }
    }
}