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
        
        
        
    }
}
