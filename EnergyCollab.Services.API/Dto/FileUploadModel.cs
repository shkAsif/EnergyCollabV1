using static EnergyCollab.Services.API.HelperMethod.Helper;

namespace EnergyCollab.Services.API.Dto
{
    public class FileUploadModel
    {
        public IFormFile FileDetails { get; set; }
        public FileType FileType { get; set; }
    }
}
