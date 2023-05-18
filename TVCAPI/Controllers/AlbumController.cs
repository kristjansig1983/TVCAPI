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

            try
            {


                Album? album = _repo.GetALbumById(id);

                if (album == null)
                {
                    return NotFound();

                }

                // Nota til að fá þær upplýsingar sem þú vilt upp úr gagnagrunninum
                // AlbumDTO albumDTO = new AlbumDTO() { AlbumName = album.AlbumName, Songs = album.Songs };

                return album;
            }
            catch (Exception)
            {
                return StatusCode(500);
            }

            
        }

        [HttpDelete]
        [Route("albums/{id}")]
        public ActionResult<Album> DeleteAlbumById(int id)
        {

            try
            {


                Album? album = _repo.GetALbumById(id);

                if (album == null)
                {
                    return NotFound();

                }
                bool success = _repo.DeleteAlbum(album);

                if (!success)
                {
                    return StatusCode(500);
                }
                return Ok();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }


        }

        [HttpPost]
        [Route("albums")]
        public ActionResult<Album> CreateAlbum(Album album)
        {
            try
            {

            
            _repo.CreateAlbum(album);
            }
            catch (Exception) 
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }



            //return CreatedAtAction("GetTodoItem", new { id = todoItem.Id }, todoItem);
            return CreatedAtAction(nameof(GetALbumById), new { id = album.AlbumId }, album);
        }

        [HttpPut]
        [Route("albums/{id}")]
        public IActionResult UpdateAlbum(int id, Album albumFromBody)
        {
            if (id != albumFromBody.AlbumId)
            {
                return BadRequest();
            }

            



            try
            {

                Album? updated = _repo.UpdateAlbum(id, albumFromBody);
                if (updated == null)
                {
                    return NotFound();
                }

                return NoContent();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

            
        }

        [HttpGet]
        [Route("songs")]
        public List<Song> GetAllSongs()
        {

            return _repo.GetAllSongs();
        }

        [HttpGet]
        [Route("songs/{id}")]
        public ActionResult<Song> GetSongById(int id)
        {

            try
            {


                Song? song = _repo.GetSongById(id);

                if (song == null)
                {
                    return NotFound();

                }

                // Nota til að fá þær upplýsingar sem þú vilt upp úr gagnagrunninum
                // AlbumDTO albumDTO = new AlbumDTO() { AlbumName = album.AlbumName, Songs = album.Songs };

                return song;
            }
            catch (Exception)
            {
                return StatusCode(500);
            }


        }

        [HttpDelete]
        [Route("Songs/{id}")]
        public ActionResult<Album> DeleteSongById(int id)
        {

            try
            {


                Song? song = _repo.GetSongById(id);

                if (song == null)
                {
                    return NotFound();

                }
                bool success = _repo.DeleteSong(song);

                if (!success)
                {
                    return StatusCode(500);
                }
                return Ok();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }


        }

        [HttpPost]
        [Route("songs")]
        public ActionResult<Album> CreateSong(Song song)
        {
            try
            {


                _repo.CreateSong(song);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }



            //return CreatedAtAction("GetTodoItem", new { id = todoItem.Id }, todoItem);
            return CreatedAtAction(nameof(GetSongById), new { id = song.SongId }, song);
        }

        [HttpPut]
        [Route("songs/{id}")]
        public IActionResult UpdateSong(int id, Song songFromBody)
        {
            if (id != songFromBody.SongId)
            {
                return BadRequest();
            }





            try
            {

                Song? updated = _repo.UpdateSong(id, songFromBody);
                if (updated == null)
                {
                    return NotFound();
                }

                return NoContent();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }


        }


    }

}
