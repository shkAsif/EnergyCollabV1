﻿namespace EnergyCollab.Services.API.Models
{
    public class Country
    {
        public int Id { get; set; } 
        public string Name { get; set; } = string.Empty;            
        public string City { get; set; } = string.Empty;
        public string CountryCode { get; set; } = string.Empty;
        public ICollection<Vacancy> vacancies { get; set; }
        public ICollection<Organization>  organizations { get; set; }
    }
}
