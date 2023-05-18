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
            return _dbContext.Merches.Where(m => m.MerchId == id).FirstOrDefault();
        }

        public void CreateMerch(Merch merch)
        {
            _dbContext.Merches.Add(merch);
            _dbContext.SaveChanges();
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

        public Song? GetSongById(int id)
        {
            return _dbContext.Songs.Where(s => s.SongId == id).FirstOrDefault();
        }

        public bool DeleteSong(Song song)
        {
            try
            {
                _dbContext.Songs.Remove(song);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void CreateSong(Song song)
        {
            _dbContext.Songs.Add(song);
            _dbContext.SaveChanges();
        }

        public Song? UpdateSong(int id, Song songFromBody)
        {
            Song? songFromDB = GetSongById(id);

            if (songFromDB == null)
            {
                return null;
            }

            songFromDB.SongName = songFromBody.SongName;
            songFromDB.AlbumId = songFromBody.AlbumId;
            
            _dbContext.SaveChanges();

            return songFromDB;
        }

        public bool DeleteMerch(Merch merch)
        {
            try
            {
                _dbContext.Merches.Remove(merch);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Merch? UpdateMerch(int id, Merch merchFromBody)
        {
            Merch? merchFromDB = GetMerchById(id);

            if (merchFromDB == null)
            {
                return null;
            }

            merchFromDB.MerchName = merchFromBody.MerchName;
            

            _dbContext.SaveChanges();

            return merchFromDB;
        }
    }
}
