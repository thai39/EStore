using System.ComponentModel.DataAnnotations;

namespace EStore.Model
{
    public class customer
    {
        [Key]
        public int id { get; set; }
        public string fullname { get; set; }
        public DateTime dob { get; set; }
        public string gender { get; set; }
        public string? address { get; set; }
        public string? email { get; set; }
        public string? city { get; set; }
        public string phone { get; set; }
    }
}
