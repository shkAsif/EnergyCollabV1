using Microsoft.AspNetCore.Razor.Language.Intermediate;
using Microsoft.Build.Evaluation;
using Microsoft.CodeAnalysis.FlowAnalysis.DataFlow;
using System.ComponentModel.DataAnnotations;
namespace EnergyCollab.Web.Models
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
