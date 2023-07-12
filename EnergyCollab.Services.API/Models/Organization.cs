using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EnergyCollab.Services.API.Models
{
    public class Organization
    {
        public int Id { get; set; }
        public Guid? CompanyId { get; set; }
        public string Name { get; set; } = string.Empty;    
        public Country country { get; set; } 
        public int? countryId { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public  DateTime Updated { get; set; }= DateTime.Now;
        public ICollection<Vacancy> Vacancies { get; set; }
        public partial class OrganizationConfiguration : IEntityTypeConfiguration<Organization>
        {
            public void Configure(EntityTypeBuilder<Organization> modelBuilder)
            {
                modelBuilder.HasIndex(e => e.Id);
                //Country
                modelBuilder.HasOne(pt => pt.country)
                    .WithMany(t => t.organizations)
                    .HasForeignKey(p => p.countryId);
            }
        }
    }
}
