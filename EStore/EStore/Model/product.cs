using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EStore.Model
{
    public class product
    {
        [Key]
        public int id { get; set; }
        public string? title { get; set; }
        public string? thumnail { get; set; }
        public string? description { get; set; }
        public float price { get; set; }
        public int discount { get; set; }
        public string? image { get; set; }
        public int id_category { get; set; }
        

        [NotMapped]
        public IFormFile? ImageFile { get; set; }
         
    }
}
