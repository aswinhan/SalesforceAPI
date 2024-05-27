using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace SalesforceAPI.Models
{
    public class AccountAttributes
    {
        [Key]
        public int Id { get; set; }
        public string? Type { get; set; }
        public string? Url { get; set; }
    }
}
