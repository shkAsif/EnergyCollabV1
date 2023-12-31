﻿using EnergyCollab.Web.Models;
namespace EnergyCollab.Web.Service.IService
{
    public interface ISignUp
    {
        Task<ResponseDto?> CreateUserSignUp(SignUpDto signUp);
        Task<ResponseDto?> UserLogin(LoginDto userLogin);
        Task<ResponseDto?> CreateClientAccount(ClientSignUpDto client);
        Task<ResponseDto?> GetOrgShortSummary();
    }
}
