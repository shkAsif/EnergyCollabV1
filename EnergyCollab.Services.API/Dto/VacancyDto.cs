using EnergyCollab.Services.API.Models;

namespace EnergyCollab.Services.API.Dto
{
    public class VacancyDto
    {
        public string CompanyName { get; set; } = string.Empty;
        public string JobTitle { get; set; } = string.Empty;
        public string Responsibilities { get; set; } = string.Empty;
        public int Salary { get; set; }
        public string Education { get; set; } = string.Empty;        
        public string EmpCategory { get; set; }
        public string Country { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;

    }
}
