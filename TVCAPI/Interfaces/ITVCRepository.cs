using TVCAPI.Models;

namespace TVCAPI.Interfaces
{
    public interface ITVCRepository
    {
        List<Album> GetAllAlbums();
        List<Song> GetAllSongs();
        Album? GetALbumById(int id);
    }
}
