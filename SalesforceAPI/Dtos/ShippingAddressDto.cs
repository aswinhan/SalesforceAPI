namespace SalesforceAPI.Dtos
{
    public class ShippingAddressDto
    {
        public string? city { get; set; }
        public string? country { get; set; }
        public string? geocodeAccuracy { get; set; }
        public double? latitude { get; set; }
        public double? longitude { get; set; }
        public string? postalCode { get; set; }
        public string? state { get; set; }
        public string? street { get; set; }
    }
}
