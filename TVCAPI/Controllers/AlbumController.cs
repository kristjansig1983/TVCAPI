using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using TVCAPI.Data;
using TVCAPI.Interfaces;
using TVCAPI.Models;
using static System.Net.WebRequestMethods;

namespace TVCAPI.Controllers
{
    [Route("api/")]
    [ApiController]
    public class AlbumController : ControllerBase
    {

        private ITVCRepository _repo;


        public AlbumController()
        {
            _repo = new MockRepository();
        }
        [HttpGet]
        [Route("albums")]
        public List<Album> GetAllAlbums()
        {
           
           return _repo.GetAllAlbums();
        }

        [HttpGet]
        [Route("albums/{id}")]
        public ActionResult<Album> GetALbumById(int id)
        {
            

            Album? album = _repo.GetALbumById(id);

            if (album == null)
            {
                return NotFound();

            }

            return album;

            
        }

        [HttpGet]
        [Route("songs")]
        public List<Song> GetAllSongs()
        {

            return _repo.GetAllSongs();
        }


    }

}
