namespace EnergyCollab.Web.Models
{
    public class QuickJobSearch
    {
        public required string Country { get; set; }
        public required string OrderBy { get; set; }
        public string? SearchPhrase { get; set; }
    }
}
