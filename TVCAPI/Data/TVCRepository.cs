using Microsoft.EntityFrameworkCore;
using TVCAPI.Interfaces;
using TVCAPI.Models;

namespace TVCAPI.Data
{
    public class TVCRepository : ITVCRepository
    {

        private TVCDBContext _dbContext;

        public TVCRepository()
        {
          _dbContext = new TVCDBContext();
               
        }

        public List<Album> GetAllAlbums()
        {
           return _dbContext.Albums.Include(x => x.Songs).ToList();

        }

        public Album? GetALbumById(int id)
        {
            return _dbContext.Albums.Where(a => a.AlbumId == id).FirstOrDefault();
        }

        public List<Song> GetAllSongs()
        {
            throw new NotImplementedException();
        }
    }
}
