using EStore.Data;
using EStore.Model;
using Microsoft.EntityFrameworkCore;

namespace EStore.Repository.Implement
{
    public class ProductRepo : IProductRepo
    {
        private readonly DBConnect _dbConnect;

        public ProductRepo(DBConnect dbConnect)
        {
            _dbConnect = dbConnect;
        }
        public void AddProduct(product pro)
        {
            _dbConnect.product.Add(pro);
            _dbConnect.SaveChanges();
        }

        public void DeleteProduct(int id)
        {
            var rs = _dbConnect.product.FirstOrDefault(x => x.id == id);
            if (rs != null)
            {
                _dbConnect.product.Remove(rs);
                _dbConnect.SaveChanges();
            }
        }

        public product GetProductById(int id)
        {
            return _dbConnect.product.FirstOrDefault(x => x.id == id);
        }

        public IQueryable<product> GetProducts()
        {
            return _dbConnect.Set<product>().AsNoTracking();

        }

        public List<product> SearchProduct(string text)
        {
            return _dbConnect.product.Where(
            x => x.title.Trim().Contains(text)
            || x.thumnail.Trim().Contains(text)
            || x.price.Equals(text)
            ).ToList();
        }

        public void UpdateProduct(product product)
        {
            var rs = _dbConnect.product.FirstOrDefault(x => x.id == product.id);
            if (rs != null)
            {
                rs.title = product.title;
                rs.thumnail = product.thumnail;
                rs.description = product.description;
                rs.price = product.price;
                _dbConnect.product.Update(rs);
                _dbConnect.SaveChanges();
            }
        }
    }
}
