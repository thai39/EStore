using EStore.Model;
using EStore.pagination;

namespace EStore.Service
{
    public interface IProductService
    {
        Task<Pagination<product>> GetListProduct(PageParameter pageParameters);
        public product GetProduct(int id);
        public void AddProduct(product product);
        public void UpdateProduct(product product);
        public void DeleteProduct(int id);
        public List<product> SearchPro(string text);
    }
}
