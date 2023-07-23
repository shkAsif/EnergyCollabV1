using EnergyCollab.Services.API.HelperMethod;
using System.ComponentModel.DataAnnotations.Schema;
using static EnergyCollab.Services.API.HelperMethod.Helper;

namespace EnergyCollab.Services.API.Dto
{
    public class FileDetailDto
    {
        //public int Id { get; set; }
        public string? FileName { get; set; } = string.Empty; //initialize default 
        //[NotMapped]
        public byte[]? FileData { get; set; } //= Array.Empty<byte>(); //initialize default 
        public FileType? FileType { get; set; }  //initialize default 
    }
}
