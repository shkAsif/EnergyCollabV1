using EnergyCollab.Services.API.Models;

namespace EnergyCollab.Services.API.Dto
{
    public class UserGroupDto
    {
        public string UserGroupName { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public List<string> UserEmails { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
        public DateTime LastUpdatedDateTime { get; set; } = DateTime.Now;
    }

    public class UserGroupDtov2
    {

        public int Id { get; set; }
        public string UserGroupName { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public ICollection<UserEmailDtov2> UserEmails { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
        public DateTime LastUpdatedDateTime { get; set; } = DateTime.Now;
    }

    public class UserEmailDtov2
    {
        public int Id { get; set; }
        public string Email { get; set; }

        public int UserGroupId { get; set; }        
    }


}
