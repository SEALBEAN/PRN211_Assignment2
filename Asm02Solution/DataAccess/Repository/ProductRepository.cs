using BusinessObject.Objects;

namespace DataAccess.Repository;

public class ProductRepository : IProductRepository
{
    private FstoreContext _db;
    public ProductRepository()
    {
        _db = new();
    }
    public void AddProduct(Product product)
    {
        if(product != null)
        {
            _db.Products.Add(product);
            _db.SaveChanges();
        }
    }

    public void DeleteProduct(int productId)
    {
        var product = _db.Products.Find(productId);
        if (product != null)
        {
            _db.Products.Add(product);
            _db.SaveChanges();
        }
    }

    public List<Product> GetProducts() => _db.Products.ToList();

    public void UpdateProduct(Product product)
    {
        if (product != null)
        {
            _db.Products.Update(product);
            _db.SaveChanges();
        }
    }
}
