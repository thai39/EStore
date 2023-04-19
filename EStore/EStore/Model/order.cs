using System.ComponentModel.DataAnnotations;

namespace EStore.Model
{
    public class order
    {
        [Key]
        public int id { get; set; }
        public int id_staff { get; set; }
        public int id_customer { get; set; }
        public DateTime order_date { get; set; }
    }
}
