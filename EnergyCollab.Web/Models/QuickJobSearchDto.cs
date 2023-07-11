using Microsoft.Build.Graph;

namespace EnergyCollab.Web.Models
{
    public class QuickJobSearch
    {
        public string Country { get; set; } = string.Empty;
        public string OrderBy { get; set; } = string.Empty;
        public string CountryCode { get; set; } = string.Empty;
        public string? SearchPhrase { get; set; } = string.Empty;
    }
}
