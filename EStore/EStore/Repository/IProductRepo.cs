using EStore.Model;

namespace EStore.Repository
{
    public interface IProductRepo
    {
        
        public void AddProduct(product pro);
        public void UpdateProduct(product product);
        public void DeleteProduct(int id);
    }
}
