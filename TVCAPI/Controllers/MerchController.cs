using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TVCAPI.Models;

namespace TVCAPI.Controllers
{
    [Route("api/merch")]
    [ApiController]
    public class MerchController : ControllerBase
    {
        public List<Merch> GetAllMerch()
        {
            return new List<Merch>();
            {

            }
        }
    }
}
