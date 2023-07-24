using EnergyCollab.API.Dto;
using EnergyCollab.Web.Models;
using System.IO;

namespace EnergyCollab.Services.API.HelperMethod
{
    public static class Helper
    {
        public static string GetCategoryName(int categoryId)
        {
            string result = categoryId switch
            {
                1 => "Contract",
                2 => "FullTime",
                3 => "PartTime"
            };
            return result;
        }
        public enum FileType
        {
            PDF = 1,
            DOCX = 2
        }

        public static byte[] FileDetails(IFormFile formFile)
        {
            byte[]? fileData;
            using (var stream = new MemoryStream())
            {
                formFile.CopyTo(stream);
                fileData = stream.ToArray();
            }
            return fileData;
        }
    }
}
