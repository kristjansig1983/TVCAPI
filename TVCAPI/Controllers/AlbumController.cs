using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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


        public AlbumController(ITVCRepository repo)
        {
            _repo = repo;
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

        [HttpPost]
        [Route("albums")]
        public ActionResult<Album> CreateAlbum(Album album)
        {

            _repo.CreateAlbum(album);
            
             

            //return CreatedAtAction("GetTodoItem", new { id = todoItem.Id }, todoItem);
            return CreatedAtAction(nameof(GetALbumById), new { id = album.AlbumId }, album);
        }

        [HttpGet]
        [Route("songs")]
        public List<Song> GetAllSongs()
        {

            return _repo.GetAllSongs();
        }


    }

}
