using EStore.Model;
using EStore.pagination;
using EStore.Repository;

namespace EStore.Service.Implement
{
    public class ProductService : IProductService
    {
        private readonly IProductRepo _productRepo;

        public ProductService(IProductRepo productRepo)
        {
            _productRepo = productRepo;
        }
        public void AddProduct(product product)
        {
            _productRepo.AddProduct(product);
        }

        public void DeleteProduct(int id)
        {
            _productRepo.DeleteProduct(id);
        }

        public Task<Pagination<product>> GetListProduct(PageParameter pageParameters)
        {
            return Task.FromResult(Pagination<product>.GetPageList(_productRepo.GetProducts(),
                pageParameters.PageNumber, pageParameters.PageSize));
        }

        public product GetProduct(int id)
        {
            return _productRepo.GetProductById(id);
        }

        public List<product> SearchPro(string text)
        {
            return _productRepo.SearchProduct(text);
        }

        public void UpdateProduct(product product)
        {
            _productRepo.UpdateProduct(product);
        }
    }
}
