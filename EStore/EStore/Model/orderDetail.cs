using System.ComponentModel.DataAnnotations;

namespace EStore.Model
{
    public class orderDetail
    {
        [Key]
        public int id { get; set; }
        public int id_order { get; set; }
        public int id_product { get; set; }
        public float price { get; set; }
        public int amount { get; set; }
        public float total_price { get; set; }

        
    }
}
