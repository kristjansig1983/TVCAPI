using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TVCAPI.Models;

namespace TVCAPI.Controllers
{
    [Route("api/[album]")]
    [ApiController]
    public class AlbumController : ControllerBase
    {

        public List<Album> GetAllAlbums()
        {
            return new List<Album>() { };
        }
    }
}
