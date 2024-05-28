using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace SalesforceAPI.Dtos
{
    public class PractitionerCredentialingProfileDto
    {
        public string? First_Name__c { get; set; }
        public string? Last_Name__c { get; set; }
        public DateTime Date_of_Birth__c { get; set; }
        public int? Tax_ID__c { get; set; }
        public bool? Medicare_Provider__c { get; set; }
        public int? Medicare_Number__c { get; set; }
        public string? Practitioner_NPI__c { get; set; }
        public string? Office_Address_Street_1__c { get; set; }
        public string? Office_Address_Street_2__c { get; set; }
        public string? Office_Address_City__c { get; set; }
        public string? Office_Address_Zipcode__c { get; set; }
        public string? Office_Address_State__c { get; set; }
        public string? Office_Address_County__c { get; set; }
        public string? Home_Address_Street_1__c { get; set; }
        public string? Home_Address_Street_2__c { get; set; }
        public string? Home_Address_City__c { get; set; }
        public string? Home_Address_Zipcode__c { get; set; }
        public string? Home_Address_State__c { get; set; }
        public string? Home_Address_County__c { get; set; }
        public SpecialtiesCEnum? Specialties__c { get; set; }
        public string? Other_Specialty__c { get; set; }
        public bool Certificate_of_Liability__c { get; set; }
        public DateTime Certificate_of_Liability_Expiration_Date__c { get; set; }
        public CurrentMalpracticeInsuranceCoverageCEnum? Current_Malpractice_Insurance_Coverage__c { get; set; }
        public string? Explanation_Current_Malpractice__c { get; set; }
        public bool File_Malpractice_Insurance_Coverage__c { get; set; }
        public DateTime MalpracticeInsurance_Coverage_Expiration__c { get; set; }
        public string? Languages_Spoken__c { get; set; }
        public string? Cultural_Competences__c { get; set; }
        public bool Five_year_work_history__c { get; set; }
        public X6MonthGapInEmploymentSinceProfessCEnum? X6_month_gap_in_employment_since_profess__c { get; set; }
        public DateTime X6_Month_Gap_Start_Date__c { get; set; }
        public DateTime X6_Month_Gap_End_Date__c { get; set; }
        public string? X6_Month_Gap_Activity__c { get; set; }
        public string? X6_Month_Gap_Reason__c { get; set; }
        public CanYouPerformTheEssentialDutiesOfCEnum? Can_you_perform_the_essential_duties_of__c { get; set; }
        public string? Reason_for_inability_to_perform_essentia__c { get; set; }
        public LackOfPresentIllegalDrugUseCEnum? Lack_of_present_illegal_drug_use__c { get; set; }
        public string? Explanation_Lackofpresentillegaldrug__c { get; set; }
        public HistoryOfLossOfLicenseCEnum? History_of_loss_of_license__c { get; set; }
        public string? ExplanationHistoryoflossoflicense__c { get; set; }
        public string? History_of_felony_convictions__c { get; set; }
        public string? ExplanationHistory_of_felony_convictions__c { get; set; }
        public string? History_of_loss_or_limitations_of_privil__c { get; set; }
        public string? ExplanationHistory_of_loss__c { get; set; }
        public string? Attestation_by_the_applicant_of_the_corr__c { get; set; }
        public CulturalCompetenciesPicklistCEnum? Cultural_Competencies_Picklist__c { get; set; }
        public bool Please_acknowledge_If_denied_credential__c { get; set; }
        public string? Summary_of_Changes__c { get; set; }
        public DateTime Submission_Date__c { get; set; }
        public string? Provider_Name__c { get; set; }

        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum SpecialtiesCEnum
        {
            [EnumMember(Value = "Adult Psych")]
            AdultPsychEnum = 0,
            [EnumMember(Value = "Child Psych")]
            ChildPsychEnum = 1,
            [EnumMember(Value = "Co-occuring (MH & SUD)")]
            CoOccuringMHSUDEnum = 2,
            [EnumMember(Value = "Eating Disorders")]
            EatingDisordersEnum = 3,
            [EnumMember(Value = "Eye Movement Desensitization and Reprocessing (EMDR)")]
            EyeMovementDesensitizationAndReprocessingEMDREnum = 4,
            [EnumMember(Value = "Infant Mental Health")]
            InfantMentalHealthEnum = 5,
            [EnumMember(Value = "Prolonged Exposure Therapy")]
            ProlongedExposureTherapyEnum = 6,
            [EnumMember(Value = "Women's Specialty (SUD)")]
            WomensSpecialtySUDEnum = 7,
            [EnumMember(Value = "SUD Detox")]
            SUDDetoxEnum = 8,
            [EnumMember(Value = "Opiod/Methadone Treatment Program (OTP)")]
            OpiodMethadoneTreatmentProgramOTPEnum = 9,
            [EnumMember(Value = "Other")]
            OtherEnum = 10
        }

        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum CurrentMalpracticeInsuranceCoverageCEnum
        {
            [EnumMember(Value = "Yes")]
            YesEnum = 0,
            [EnumMember(Value = "No")]
            NoEnum = 1
        }

        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum X6MonthGapInEmploymentSinceProfessCEnum
        {
            [EnumMember(Value = "Yes")]
            YesEnum = 0,
            [EnumMember(Value = "No")]
            NoEnum = 1
        }

        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum CanYouPerformTheEssentialDutiesOfCEnum
        {
            [EnumMember(Value = "Yes")]
            YesEnum = 0,
            [EnumMember(Value = "No")]
            NoEnum = 1
        }

        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum LackOfPresentIllegalDrugUseCEnum
        {
            [EnumMember(Value = "Yes")]
            YesEnum = 0,
            [EnumMember(Value = "No")]
            NoEnum = 1
        }

        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum HistoryOfLossOfLicenseCEnum
        {
            [EnumMember(Value = "Yes")]
            YesEnum = 0,
            [EnumMember(Value = "No")]
            NoEnum = 1
        }

        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum CulturalCompetenciesPicklistCEnum
        {
            [EnumMember(Value = "Yes")]
            YesEnum = 0,
            [EnumMember(Value = "No")]
            NoEnum = 1
        }
    }
}
