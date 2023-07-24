
namespace EnergyCollab.Web.Models

{
    public class OrganizationDto
    {
        public int Id { get; set; }
        public Guid? CompanyId { get; set; }
        public string Name { get; set; } = string.Empty;    
        public CountryDto country { get; set; } 
        public int? countryId { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public  DateTime Updated { get; set; }= DateTime.Now;
        public ICollection<VacancyDto> Vacancies { get; set; }
        public OrgDetail OrgDetails { get; set; }       

       
    }
}
