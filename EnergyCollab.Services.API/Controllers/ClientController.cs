using AutoMapper;
using EnergyCollab.API.Data;
using EnergyCollab.API.Dto;
using EnergyCollab.Models;
using EnergyCollab.Services.API.Dto;
using EnergyCollab.Services.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EnergyCollab.Services.API.Controllers
{
    [Route("api/client")]    
    public class ClientController : Controller
    {
        private readonly AppDbContext _db;
        private ResponseDto _response;
        private IMapper _mapper;

        public ClientController(AppDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
            _response = new ResponseDto();
        }
       

        // POST: ClientController/Create
        [HttpPost]
        [Route("ClientSignUp")]
        public ResponseDto ClentSignUp([FromBody] ClientSignupDto clientDto)
        {
            try
            {
                var obj = _mapper.Map<ClientSignup>(clientDto);
                _db.ClientSignups.Add(obj);
                _db.SaveChanges();

                _response.Result = _mapper.Map<ClientSignupDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        // GET: ClientController/Edit/5
       
        
    }
}
