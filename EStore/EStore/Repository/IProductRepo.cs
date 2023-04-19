using EStore.Model;

namespace EStore.Repository
{
    public interface IProductRepo
    {
        public IQueryable<product> GetProducts();
        public product GetProductById(int id);
        public List<product> SearchProduct(string text);
        public void AddProduct(product pro);
        public void UpdateProduct(product product);
        public void DeleteProduct(int id);
    }
}
