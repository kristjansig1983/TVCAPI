using System.ComponentModel.DataAnnotations;

namespace TVCAPI.Models
{
    public class Album
    {
        public int AlbumId { get; set; }
        [MaxLength(255)]
        public string AlbumName { get; set; }
        public int AlbumYear { get; set; }
        public List<Song> Songs { get; set; } = new();
        public string AlbumCoverUrl { get; set; }
    }
}
