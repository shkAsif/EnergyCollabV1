using NuGet.Protocol.Core.Types;

namespace EnergyCollab.Services.API.Models
{
    public class Experience
    {
        public int Id { get; set; }

        public string Range { get; set; }

        public ICollection<Vacancy> Vacancies { get; set; }
    }
}
