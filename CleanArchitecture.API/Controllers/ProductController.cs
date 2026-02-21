using Microsoft.AspNetCore.Mvc;
using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.DTOs;

namespace CleanArchitecture.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly IProductService _service;
    
    public ProductsController(IProductService service)
    {
        _service = service;
    }
    [HttpGet]
    public async Task<IActionResult> Get()
        => Ok(await _service.GetAllAsync());

    [HttpPost]
    public async Task<IActionResult> Create(ProductDto dto)
    {
        await _service.AddAsync(dto);
        return Ok("Product Added");
    }
}