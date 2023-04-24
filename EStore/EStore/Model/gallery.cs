using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EStore.Model
{
    public class gallery
    {
        [Key]
        public int id { get; set; }
        public int proId { get; set; }
        public string? images { get; set; }
        

        [NotMapped]
        public IFormFile? files { get; set; }
    }
}
