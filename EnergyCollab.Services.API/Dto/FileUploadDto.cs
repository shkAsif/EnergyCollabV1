using static EnergyCollab.Services.API.HelperMethod.Helper;

namespace EnergyCollab.Services.API.Dto
{
    public class FileUploadDto
    {
        public IFormFile FileDetails { get; set; }
        public FileType FileType { get; set; }
    }
}
