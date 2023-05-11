namespace TVCAPI.Models
{
    public class Songs
    {

public int SongId { get; set; }
        public string SongName { get; set;}
        public List<Album> Albums { get; set; } = new();
    }
}
