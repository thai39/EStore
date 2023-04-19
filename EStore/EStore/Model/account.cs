using System.ComponentModel.DataAnnotations;

namespace EStore.Model
{
    public class account
    {
        [Key]
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public bool isAdmin { get; set; }
    }
}
