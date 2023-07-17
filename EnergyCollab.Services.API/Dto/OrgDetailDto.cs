using EnergyCollab.Services.API.Models;

namespace EnergyCollab.Services.API.Dto
{
    public class OrgDetailDto
    {
        
        public OrgSummaryDto OrgSummary { get; set; }
        
        public int Id { get; set; }        

        // Company Profile Tab
        public string PrimaryContact { get; set; }
        public string Email { get; set; }
        public string Package { get; set; } // Gold , Platinum , Silver
        public int AdministratorCount { get; set; }
        public int ExecutiveCount { get; set; }
        public int AnnuallyJobPostCount { get; set; }
        public string TimeZone { get; set; }
        public string Logo { get; set; }
        public string Url { get; set; }
        public string FacebookURL { get; set; }
        public string AddressOne { get; set; }
        public string AddressTwo { get; set; }
        public string PostCode { get; set; }
        public string PrimayContactNumber { get; set; }
        public string SecondaryContactNumber { get; set; }
        public bool ActivationStatus { get; set; }

        //Invitation Tab 
        public string InviteLink { get; set; }

        //Users Tab
        string PendingUser { get; set; }
        public string Approve { get; set; }

        //Community Network Tab
        public string Region { get; set; }
        public string ExpertiseIndustry { get; set; }
        public string Position { get; set; }
        public string CommPostCode { get; set; }
        public string Description { get; set; }
        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public string CommDescription { get; set; }

    }
}
