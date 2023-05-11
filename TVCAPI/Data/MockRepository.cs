using Microsoft.AspNetCore.Mvc;
using TVCAPI.Models;
using TVCAPI.Interfaces;

namespace TVCAPI.Data
{
    public class MockRepository : ITVCRepository
    {

        List<Song> Songs = new List<Song>()
        {
            new Song() { SongId = 1, SongName = "Babylon", AlbumId = 1,}
        };

        List<Album> Albums = new List<Album>()
            {
            new Album() { AlbumId = 1, AlbumName = "Mock-The Vintage Caravan", AlbumYear = 2009, AlbumCoverUrl = "https://www.spirit-of-metal.com/les%20goupes/T/The%20Vintage%20Caravan/The%20Vintage%20Caravan/The%20Vintage%20Caravan.jpg"},
            };

        


        public List<Album> GetAllAlbums()
        {
            Albums[0].Songs = Songs;
            return Albums;

        }

        public List<Song> GetAllSongs()
        {
            return Songs;

        }

        public Album? GetALbumById(int id)
        {


            foreach (Album album in Albums)
            {
                if (album.AlbumId == id)
                {
                    return album;
                }
            }
            return null;
        }
    }
}
