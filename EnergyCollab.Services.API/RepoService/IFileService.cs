

namespace EnergyCollab.Services.API.RepoService
{
    public interface IFileService
    {
        //public Task PostFileAsync(IFormFile fileData, FileType fileType, CancellationToken cancellationToken = default);
        //public Task PostMultiFileAsync(List<FileUploadModel> fileData, CancellationToken cancellationToken = default);

        public Task DownloadCVById(int fileName, CancellationToken cancellationToken = default);
    }
}
