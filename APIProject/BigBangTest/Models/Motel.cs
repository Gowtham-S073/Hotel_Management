using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BigBangTest.Models
{
    public class Motel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int motel_Id { get; set; }

        public string? Name { get; set; }
        [Required]
        public string? Location { get; set; } = string.Empty;

        [Required]
        public string Amenities { get; set; } = string.Empty;
        
        public string RoomOptions { get; set; } = string.Empty;
        
        public string Rating { get; set; } = string.Empty;

        

    }
}
