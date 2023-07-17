using EnergyCollab.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnergyCollab.Web.Models;
using EnergyCollab.Services.API.Models;
namespace EnergyCollab.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<CandidateProfile> CandidateProfiles { get; set; }
        public DbSet<SignUp> SignUps { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<Vacancy> Vacancies { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<ClientSignup> ClientSignups { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<OrgDetail> OrgDetails { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
       // public DbSet<EnergyCollab.Web.Models.JobSeekerLogin> JobSeekerLogin { get; set; } = default!;
    }
}
