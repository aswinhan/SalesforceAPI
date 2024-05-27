﻿using System.ComponentModel.DataAnnotations;

namespace SalesforceAPI.Models
{
    public class Education
    {
        [Key]
        public int Id { get; set; }
        public int ProviderId { get; set; } 
        public string? Degree { get; set; }
        public string? CollegeUniversityProgramName { get; set; }
        public string? CollegeUniversityProgramAddress { get; set; }
        public DateTime GraduationDate { get; set; }
    }
}
