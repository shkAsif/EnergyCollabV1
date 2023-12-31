﻿using EnergyCollab.Web.Models;
namespace EnergyCollab.Web.Service.IService
{
    public interface IJobSearch
    {
        Task<ResponseDto?> Country();
        Task<ResponseDto?> SearchJob();
        Task<ResponseDto?> FilterBasicSearchJob(QuickJobSearch quickjobData);
        Task<ResponseDto?> CompleteJobSearch(CompleteSearchVacancyDto completeSearch );
    }
}
