using Microsoft.AspNetCore.SignalR;
using System.Drawing;

namespace EnergyCollab.Services.API.Models
{
    public class Vacancy
    {
        public int Id { get; set; }
        public string JobTitle { get; set; } = string.Empty;
        public string Responsibilities { get; set; } = string.Empty;
        public string ScopeofResponsibilities { get; set; } = string.Empty;
        public string EntryRequirements { get; set; }
        public string AdditionalInformation { get; set; } = string.Empty;
        public bool Visa { get; set; }
        public bool ActivationStatus { get; set; }
        public bool IsActive { get; set; }
        public int VacancyAdvertLength { get; set; }
        public int IndustryExperience { get; set; }
        public int Salary { get; set; }
        public string Education { get; set; } = string.Empty;
        public string ExperienceSummary { get; set; }
        public Category EmpCategory { get; set; }
        public string SubCategory { get; set; } = string.Empty;

    }

    public enum Category
    {
        Contract,
        FullTime,
        PartTime
    }

}
