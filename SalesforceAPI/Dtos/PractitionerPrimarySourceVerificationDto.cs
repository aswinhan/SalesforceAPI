using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace SalesforceAPI.Dtos
{
    public class PractitionerPrimarySourceVerificationDto
    {
        public string? Credentialing_Profile__c { get; set; }
        public string? Name { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public PSVStatusCEnum? PSV_Status__c { get; set; }
        public DateTime Creation_Date__c { get; set; }
        public DateTime Completion_Date__c { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public VerifierSCredentialingOrganizationCEnum? Verifier_s_Credentialing_Organization__c { get; set; }
        public string? Other_Accred__c { get; set; }
        public string? Provider_Name__c { get; set; }
        public string? Primary_Source_Verifier__c { get; set; }
        public string? OwnerId { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public LARALicenseCEnum? LARA_License__c { get; set; }
        public bool MDHHS_Sanctioned_Provider_Check__c { get; set; }
        public bool Office_of_Inspector_General_Check__c { get; set; }
        public bool SAM_gov_Check__c { get; set; }
        public bool Ichat_Background_Check__c { get; set; }
        public bool Workforce_Background_Check__c { get; set; }
        public bool Medicare_Base_Enrollment__c { get; set; }
        public bool Medicare_Opt_Out__c { get; set; }
        public bool LARA_Uploaded__c { get; set; }
        public bool Official_Transcript_from_Accredited_Scho__c { get; set; }
        public bool Degree_Verification__c { get; set; }
        public bool ECFMG__c { get; set; }
        public bool AMA_Verification__c { get; set; }
        public bool AOA_Verification__c { get; set; }
        public bool MCBAP_Verification__c { get; set; }
        public bool MI_Public_Sex_Offender_Registry_Check__c { get; set; }
        public bool National_Sex_Offender_Registry_Check__c { get; set; }
        public enum PSVStatusCEnum
        {
            [EnumMember(Value = "In-Progress")]
            InProgressEnum = 0,
            [EnumMember(Value = "Complete")]
            CompleteEnum = 1,
            [EnumMember(Value = "Expired Licensure/Certification")]
            ExpiredLicensureCertificationEnum = 2,
            [EnumMember(Value = "Expired")]
            ExpiredEnum = 3,
            [EnumMember(Value = "CVO In-Progress")]
            CVOInProgressEnum = 4
        }
        public enum VerifierSCredentialingOrganizationCEnum
        {
            [EnumMember(Value = "COA")]
            COAEnum = 0,
            [EnumMember(Value = "NCQA")]
            NCQAEnum = 1,
            [EnumMember(Value = "Joint Commission")]
            JointCommissionEnum = 2,
            [EnumMember(Value = "URAC")]
            URACEnum = 3,
            [EnumMember(Value = "Other")]
            OtherEnum = 4,
            [EnumMember(Value = "CARF")]
            CARFEnum = 5,
            [EnumMember(Value = "None")]
            NoneEnum = 6
        }
        public enum LARALicenseCEnum
        {
            [EnumMember(Value = "Acupuncture")]
            AcupunctureEnum = 0,
            [EnumMember(Value = "Audiology")]
            AudiologyEnum = 1,
            [EnumMember(Value = "Addiction Medicine")]
            AddictionMedicineEnum = 2,
            [EnumMember(Value = "Behavior Analysts")]
            BehaviorAnalystsEnum = 3,
            [EnumMember(Value = "Counseling")]
            CounselingEnum = 4,
            [EnumMember(Value = "Genetic Counseling")]
            GeneticCounselingEnum = 5,
            [EnumMember(Value = "Marriage and Family Therapy")]
            MarriageAndFamilyTherapyEnum = 6,
            [EnumMember(Value = "Massage Therapy")]
            MassageTherapyEnum = 7,
            [EnumMember(Value = "Medicine")]
            MedicineEnum = 8,
            [EnumMember(Value = "Nursing")]
            NursingEnum = 9,
            [EnumMember(Value = "Nursing Home Administrator")]
            NursingHomeAdministratorEnum = 10,
            [EnumMember(Value = "Occupational Therapy")]
            OccupationalTherapyEnum = 11,
            [EnumMember(Value = "Osteopathic Medicine & Surgery")]
            OsteopathicMedicineSurgeryEnum = 12,
            [EnumMember(Value = "Pharmacy")]
            PharmacyEnum = 13,
            [EnumMember(Value = "Physical Therapy")]
            PhysicalTherapyEnum = 14,
            [EnumMember(Value = "Physician Assistant (PA)")]
            PhysicianAssistantPAEnum = 15,
            [EnumMember(Value = "Psychology")]
            PsychologyEnum = 16,
            [EnumMember(Value = "Respiratory Care")]
            RespiratoryCareEnum = 17,
            [EnumMember(Value = "Social Worker")]
            SocialWorkerEnum = 18,
            [EnumMember(Value = "Speech-Language Pathology")]
            SpeechLanguagePathologyEnum = 19,
            [EnumMember(Value = "Nurse Practitioner (NP)")]
            NursePractitionerNPEnum = 20,
            [EnumMember(Value = "Other")]
            OtherEnum = 21
        }
    }
}
