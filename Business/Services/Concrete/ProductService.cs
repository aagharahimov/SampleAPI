using Business.Services.Abstract;
using Common.Entities;
using Data.Repositories.Abstract;

namespace Business.Services.Concrete;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;
    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }
    public Task CreateAync()
    {
        throw new NotImplementedException();
    }

    public Task<List<Product>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Product> GetAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task CreateAsync(Product data)
    {
        throw new NotImplementedException();
    }

    public void Update(Product data)
    {
        throw new NotImplementedException();
    }

    public void Delete(Product data)
    {
        throw new NotImplementedException();
    }
}