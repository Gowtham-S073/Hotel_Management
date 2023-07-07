using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BigBangTest.Models
{
    public class Room
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int room_Id { get; set; }
        public int? room_Number { get; set; }

        [Required]
        public string? Room_Type { get; set; }

        [Required]
        public string? Property_Type { get; set; }

        [Required]
        public bool Available_Status { get; set; }

        [Required]
        public double price { get; set; }

        public Motel? motel_ID { get; set; }
     
    }
}
