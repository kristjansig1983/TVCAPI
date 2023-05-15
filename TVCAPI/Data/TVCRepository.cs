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
            return _dbContext.Songs.ToList();
        }

        public List<Merch> GetAllMerch()
        {
            return _dbContext.Merches.ToList();

        }

        public void CreateAlbum(Album album)
        {
            _dbContext.Albums.Add(album);
            _dbContext.SaveChanges();
        }

        public Merch? GetMerchById(int id)
        {
            throw new NotImplementedException();
        }

        public void CreateMerch(Merch merch)
        {
            throw new NotImplementedException();
        }

        public Album? UpdateAlbum(int id, Album albumFromBody)
        {
            Album? albumFromDB = GetALbumById(id);

            if (albumFromDB == null)
            {
                return null;
            }

            albumFromDB.AlbumName = albumFromBody.AlbumName;
            albumFromDB.AlbumYear = albumFromBody.AlbumYear;
            albumFromDB.AlbumCoverUrl = albumFromBody.AlbumCoverUrl;
            albumFromDB.Songs = albumFromBody.Songs;

            _dbContext.SaveChanges();

            return albumFromDB;
        }

        public bool DeleteAlbum(Album album)
        {
            try
            {
                _dbContext.Albums.Remove(album);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception) 
            {
                return false;
            }

            
        }
    }
}
