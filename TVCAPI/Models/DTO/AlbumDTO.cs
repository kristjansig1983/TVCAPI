using System.ComponentModel.DataAnnotations;

namespace TVCAPI.Models
{
    public class AlbumDTO
    {

        public AlbumDTO() 
            { 

}
        public int AlbumId { get; set; }
        [MaxLength(255)]
        public string AlbumName { get; set; }
        
        public List<Song> Songs { get; set; } = new();
        
    }
}
