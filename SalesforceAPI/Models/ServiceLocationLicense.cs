﻿using System.ComponentModel.DataAnnotations;
using static SalesforceAPI.Dtos.ServiceLocationLicenseDto;

namespace SalesforceAPI.Models
{
    public class ServiceLocationLicense
    {
        [Key]
        public int Id { get; set; }
        public int ProviderId { get; set; }
        public string? ServiceLocations { get; set; }
        public string? ServiceName { get; set; }
        public DateTime? ServiceLicenseExpirationifapplicabl { get; set; }
        public string? ServiceLicenseNumberifapplicable { get; set; }
        public ServiceLicenseStatusIfApplicableCEnum? ServiceLicenseStatusifapplicable { get; set; }

    }
}
