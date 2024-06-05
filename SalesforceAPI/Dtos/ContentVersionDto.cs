using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace SalesforceAPI.Dtos
{
    public class ContentVersionDto
    {
        public string? Title { get; set; }
        public string? PathOnClient { get; set; }
        public string? VersionData { get; set; }
        public string? FirstPublishLocationId { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public UCDocumentTypeCEnum? UC_Document_Type__c { get; set; }
        public string? LinkedEntityId__c { get; set; }
        public string? Associated_Provider__c { get; set; }
        public enum UCDocumentTypeCEnum
        {
            [EnumMember(Value = "Commercial Liability")]
            CommercialLiabilityEnum = 0,
            [EnumMember(Value = "Disclosure Form")]
            DisclosureFormEnum = 1,
            [EnumMember(Value = "Workers' Compensation")]
            WorkersCompensationEnum = 2,
            [EnumMember(Value = "Cyber Liability (if applicable)")]
            CyberLiabilityIfApplicableEnum = 3,
            [EnumMember(Value = "Professional Liability")]
            ProfessionalLiabilityEnum = 4,
            [EnumMember(Value = "Proof of Accreditation")]
            ProofOfAccreditationEnum = 5,
            [EnumMember(Value = "W9")]
            W9Enum = 6,
            [EnumMember(Value = "Five year work history")]
            FiveYearWorkHistoryEnum = 7,
            [EnumMember(Value = "Certificate of Liability")]
            CertificateOfLiabilityEnum = 8,
            [EnumMember(Value = "Current Malpractice Insurance Coverage")]
            CurrentMalpracticeInsuranceCoverageEnum = 9,
            [EnumMember(Value = "Disciplinary Status")]
            DisciplinaryStatusEnum = 10,
            [EnumMember(Value = "Office of Inspector General Check")]
            OfficeOfInspectorGeneralCheckEnum = 11,
            [EnumMember(Value = "SAM.gov Check")]
            SAMGovCheckEnum = 12,
            [EnumMember(Value = "LARA License")]
            LARALicenseEnum = 13,
            [EnumMember(Value = "Organizational Liability Claims")]
            OrganizationalLiabilityClaimsEnum = 14,
            [EnumMember(Value = "On-Site Quality Assessment")]
            OnSiteQualityAssessmentEnum = 15,
            [EnumMember(Value = "MDHHS Sanctioned Provider Check")]
            MDHHSSanctionedProviderCheckEnum = 16,
            [EnumMember(Value = "Medicare Base Enrollment")]
            MedicareBaseEnrollmentEnum = 17,
            [EnumMember(Value = "AOA Profile Verification")]
            AOAProfileVerificationEnum = 18,
            [EnumMember(Value = "Medicare Opt Out")]
            MedicareOptOutEnum = 19,
            [EnumMember(Value = "National Student Clearinghouse Degree Verification")]
            NationalStudentClearinghouseDegreeVerificationEnum = 20,
            [EnumMember(Value = "Official Transcript from Accredited School")]
            OfficialTranscriptFromAccreditedSchoolEnum = 21,
            [EnumMember(Value = "AMA Profile Verification")]
            AMAProfileVerificationEnum = 22,
            [EnumMember(Value = "National Sex Offender Registry Check")]
            NationalSexOffenderRegistryCheckEnum = 23,
            [EnumMember(Value = "MI Public Sex Offender Registry Check")]
            MIPublicSexOffenderRegistryCheckEnum = 24,
            [EnumMember(Value = "Workforce Background Check")]
            WorkforceBackgroundCheckEnum = 25,
            [EnumMember(Value = "Ichat Background Check")]
            IchatBackgroundCheckEnum = 26,
            [EnumMember(Value = "MCBAP Verification")]
            MCBAPVerificationEnum = 27,
            [EnumMember(Value = "ECFMG")]
            ECFMGEnum = 28
        }
    }
}
