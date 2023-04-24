using System.ComponentModel.DataAnnotations;

namespace EStore.Model
{
    public class category
    {
        [Key]
        public int Id { get; set; }
        public string cName { get; set; }

        
    }
}
