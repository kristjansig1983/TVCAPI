using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TVCAPI.Models;
using static System.Net.WebRequestMethods;

namespace TVCAPI.Controllers
{
    [Route("api/albums")]
    [ApiController]
    public class AlbumController : ControllerBase
    {
        [HttpGet]
        public List<Album> GetAllAlbums()
        {
            return new List<Album>()
            {
            new Album() { AlbumID = 1, AlbumName = "The Vintage Caravan", AlbumYear = 2009, AlbumCoverUrl = "https://www.spirit-of-metal.com/les%20goupes/T/The%20Vintage%20Caravan/The%20Vintage%20Caravan/The%20Vintage%20Caravan.jpg"},
            };
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<Album> GetALbumById(int id)
        {
            List<Album> albums = new List<Album>()
            {
            new Album() { AlbumID = 1, AlbumName = "The Vintage Caravan", AlbumYear = 2009, AlbumCoverUrl = "https://www.spirit-of-metal.com/les%20goupes/T/The%20Vintage%20Caravan/The%20Vintage%20Caravan/The%20Vintage%20Caravan.jpg"},
            };

            foreach (Album album in albums)
            {
                if (album.AlbumID == id)
                {
                    return album;
                }
            }

            return NotFound();
        }
    }

}
