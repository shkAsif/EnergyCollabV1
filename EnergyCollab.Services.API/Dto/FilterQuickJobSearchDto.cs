namespace EnergyCollab.Services.API.Dto
{
    public class FilterQuickJobSearchDto
    {
        public  string Country { get; set; } = string.Empty;
        public  string OrderBy { get; set; } = string.Empty;
        public string CountryCode { get; set; }
        public string? SearchPhrase { get; set; } = string.Empty;
    }
}
