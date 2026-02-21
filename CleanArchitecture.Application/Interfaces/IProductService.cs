using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Application.DTOs;

namespace CleanArchitecture.Application.Interfaces;

public interface IProductService
{
    Task<List<Product>> GetAllAsync();
    Task AddAsync(ProductDto dto);
}