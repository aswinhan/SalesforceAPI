using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesforceAPI.Migrations
{
    /// <inheritdoc />
    public partial class addtablesnew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OrganizationalPrimarySourceVerifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProviderId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PSVStatus = table.Column<int>(type: "int", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CompletionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VerifiersCredentialingOrganization = table.Column<int>(type: "int", nullable: true),
                    OtherAccred = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimarySourceVerifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CredentialingProfile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OwnerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LARALicense = table.Column<int>(type: "int", nullable: true),
                    MDHHSSanctionedProviderCheck = table.Column<bool>(type: "bit", nullable: true),
                    OfficeofInspectorGeneralCheck = table.Column<bool>(type: "bit", nullable: true),
                    SAMgovCheck = table.Column<bool>(type: "bit", nullable: true),
                    ProofofAccreditation = table.Column<bool>(type: "bit", nullable: true),
                    Disciplinarystatuswithregulatoryboar = table.Column<bool>(type: "bit", nullable: true),
                    Atleastfiveyearhistoryoforganizati = table.Column<bool>(type: "bit", nullable: true),
                    OnSiteQualityAssessmentRecredential = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizationalPrimarySourceVerifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PractitionerCredentialingProfiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProviderId = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateofBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TaxID = table.Column<int>(type: "int", nullable: true),
                    MedicareProvider = table.Column<bool>(type: "bit", nullable: true),
                    MedicareNumber = table.Column<int>(type: "int", nullable: true),
                    ProviderName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PractitionerNPI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HomeAddressStreet1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HomeAddressStreet2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HomeAddressCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HomeAddressZipcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HomeAddressState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HomeAddressCounty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Specialties = table.Column<int>(type: "int", nullable: true),
                    OtherSpecialty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CertificateofLiability = table.Column<bool>(type: "bit", nullable: false),
                    CertificateofLiabilityExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CurrentMalpracticeInsuranceCoverage = table.Column<int>(type: "int", nullable: true),
                    ExplanationCurrentMalpractice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileMalpracticeInsuranceCoverage = table.Column<bool>(type: "bit", nullable: false),
                    MalpracticeInsuranceCoverageExpiration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LanguagesSpoken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CulturalCompetences = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fiveyearworkhistory = table.Column<bool>(type: "bit", nullable: false),
                    X6monthgapinemploymentsinceprofess = table.Column<int>(type: "int", nullable: true),
                    X6MonthGapStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    X6MonthGapEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    X6MonthGapActivity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    X6MonthGapReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Canyouperformtheessentialdutiesof = table.Column<int>(type: "int", nullable: true),
                    Reasonforinabilitytoperformessentia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lackofpresentillegaldruguse = table.Column<int>(type: "int", nullable: true),
                    ExplanationLackofpresentillegaldrug = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Historyoflossoflicense = table.Column<int>(type: "int", nullable: false),
                    ExplanationHistoryoflossoflicense = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Historyoffelonyconvictions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExplanationHistoryoffelonyconvictions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Historyoflossorlimitationsofprivil = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExplanationHistoryofloss = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AttestationByTheApplicantOfTheCorr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CulturalCompetenciesPicklist = table.Column<int>(type: "int", nullable: true),
                    OfficeAddressStreet1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OfficeAddressStreet2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OfficeAddressCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OfficeAddressZipcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OfficeAddressState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OfficeAddressCounty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PleaseacknowledgeIfdeniedcredential = table.Column<bool>(type: "bit", nullable: false),
                    SummaryofChanges = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubmissionDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PractitionerCredentialingProfiles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PractitionerLicenseCertifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProviderId = table.Column<int>(type: "int", nullable: false),
                    RecordTypeId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LicenseCertificationType = table.Column<int>(type: "int", nullable: true),
                    LicenseTypesLARA = table.Column<int>(type: "int", nullable: true),
                    OtherLicenseType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoardCertifications = table.Column<int>(type: "int", nullable: true),
                    OtherBoardCertification = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NursingCertifications = table.Column<int>(type: "int", nullable: true),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FileUploaded = table.Column<bool>(type: "bit", nullable: false),
                    LicenseCertificationStatus = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PractitionerLicenseCertifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PractitionerPrimarySourceVerifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProviderId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PSVStatus = table.Column<int>(type: "int", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CompletionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VerifiersCredentialingOrganization = table.Column<int>(type: "int", nullable: true),
                    OtherAccred = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimarySourceVerifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OwnerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LARALicense = table.Column<int>(type: "int", nullable: true),
                    MDHHSSanctionedProviderCheck = table.Column<bool>(type: "bit", nullable: false),
                    OfficeofInspectorGeneralCheck = table.Column<bool>(type: "bit", nullable: false),
                    SAMgovCheck = table.Column<bool>(type: "bit", nullable: false),
                    IchatBackgroundCheck = table.Column<bool>(type: "bit", nullable: false),
                    WorkforceBackgroundCheck = table.Column<bool>(type: "bit", nullable: false),
                    MedicareBaseEnrollment = table.Column<bool>(type: "bit", nullable: false),
                    MedicareOptOut = table.Column<bool>(type: "bit", nullable: false),
                    LARAUploaded = table.Column<bool>(type: "bit", nullable: false),
                    OfficialTranscriptfromAccreditedScho = table.Column<bool>(type: "bit", nullable: false),
                    DegreeVerification = table.Column<bool>(type: "bit", nullable: false),
                    ECFMG = table.Column<bool>(type: "bit", nullable: false),
                    AMAVerification = table.Column<bool>(type: "bit", nullable: false),
                    AOAVerification = table.Column<bool>(type: "bit", nullable: false),
                    MCBAPVerification = table.Column<bool>(type: "bit", nullable: false),
                    MIPublicSexOffenderRegistryCheck = table.Column<bool>(type: "bit", nullable: false),
                    NationalSexOffenderRegistryCheck = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PractitionerPrimarySourceVerifications", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrganizationalPrimarySourceVerifications");

            migrationBuilder.DropTable(
                name: "PractitionerCredentialingProfiles");

            migrationBuilder.DropTable(
                name: "PractitionerLicenseCertifications");

            migrationBuilder.DropTable(
                name: "PractitionerPrimarySourceVerifications");
        }
    }
}
