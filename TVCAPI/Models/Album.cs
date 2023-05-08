using System.ComponentModel.DataAnnotations;

namespace TVCAPI.Models
{
    public class Album
    {
        public int AlbumID { get; set; }
        [MaxLength(255)]
        public string AlbumName { get; set; }
        public int AlbumYear { get; set; }
    }
}
