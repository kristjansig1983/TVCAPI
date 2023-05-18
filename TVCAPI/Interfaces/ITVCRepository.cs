using Microsoft.AspNetCore.Mvc;
using TVCAPI.Models;

namespace TVCAPI.Interfaces
{
    public interface ITVCRepository
    {
        List<Album> GetAllAlbums();
        
        Album? GetALbumById(int id);
        
        void CreateAlbum(Album album);

        void CreateMerch(Merch merch);
        Album? UpdateAlbum(int id, Album albumFromBody);

        bool DeleteAlbum(Album album);

        List<Song> GetAllSongs();

        List<Merch> GetAllMerch();
        Merch? GetMerchById(int id);
    }
}
