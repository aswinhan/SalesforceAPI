using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using static SalesforceAPI.Dtos.ContentVersionDto;

namespace SalesforceAPI.Models
{
    public class ContentVersion
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? PathOnClient { get; set; }
        public string? VersionData { get; set; }
        public string? FirstPublishLocationId { get; set; }
        public UCDocumentTypeCEnum? UCDocumentType { get; set; }
        public string? LinkedEntityId { get; set; }
        public string? AssociatedProvider { get; set; }
    }
}
