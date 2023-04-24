using System.ComponentModel.DataAnnotations;

namespace EStore.Model
{
    public class feedback
    {
        [Key]
        public int id { get; set; }
        public string? fullname { get; set; }
        public string? email { get; set; }
        public string? phone { get; set; }
        public string? subject_name { get; set; }
        public string? note { get; set; }
    }
}
