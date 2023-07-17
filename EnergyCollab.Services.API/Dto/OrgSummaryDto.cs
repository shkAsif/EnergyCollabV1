namespace EnergyCollab.Services.API.Dto
{
    public class OrgSummaryDto
    {

        public string OrgId { get; set; }   
        public string OrgName { get; set; } =string.Empty;
        public string OrgContactPerson { get; set; } = string.Empty;
        public string OrgEmail { get; set; } = string.Empty;

    }
}