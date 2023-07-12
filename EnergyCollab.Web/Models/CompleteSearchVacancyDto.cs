namespace EnergyCollab.Web.Models
{
    public class CompleteSearchVacancyDto
    {
        public string CountryCode { get; set; }
        public string IndustryExperience { get; set; }
        public string EmploymentCategory { get; set; }
        public string Education { get; set; }
        public string SalaryAmount { get; set; }
        public string SalaryCurrency { get; set; }
        public string SummaryOfExperienceCategory { get; set; }

        public string OrderBy { get; set; }
        public string SearchPhrase { get; set; }
    }
}
