﻿using BusinessObject.Objects;

namespace DataAccess.Repository;

public interface IProductRepository
{
    List<Product> GetProducts();
    void AddProduct(Product product);
    void UpdateProduct(Product product);
    void DeleteProduct(int productId);
}
