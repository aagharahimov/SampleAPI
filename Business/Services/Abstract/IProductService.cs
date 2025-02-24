using Common.Entities;
using Data.Repositories.Base;

namespace Business.Services.Abstract;

public interface IProductService : IBaseRepository<Product>
{
    Task CreateAync();
    
} 