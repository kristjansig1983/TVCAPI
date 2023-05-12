using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TVCAPI.Interfaces;
using TVCAPI.Models;
using TVCAPI.Data;

namespace TVCAPI.Controllers
{
    [Route("api")]
    [ApiController]
    public class MerchController : ControllerBase
    {

        private ITVCRepository _repo;

        public MerchController(ITVCRepository repo) 
        { 
            _repo = repo;
        }

        [HttpGet]
        [Route("merch")]
        public List<Merch> GetAllMerch()
        {
            return _repo.GetAllMerch();
            
        }
    }
}
