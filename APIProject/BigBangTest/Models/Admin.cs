using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BigBangTest.Models
{
    public class Admin
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Admin_id { get; set; }

        [Required]
        public string? Admin_name { get; set; }

        [Required]
        public string? Password { get; set; }
    }
}
