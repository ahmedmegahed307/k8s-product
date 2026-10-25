
using System.Net.Http.Json;
using ProductFrontend.Models;

namespace ProductFrontend.Services;

public class ProductService
{
    private readonly HttpClient _httpClient;

    public ProductService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<Product>> GetProductsAsync()
    {
        return await _httpClient.GetFromJsonAsync<List<Product>>(
            "api/products"
        ) ?? new List<Product>();
    }

    public async Task<Product?> GetProductByIdAsync(int id)
    {
        return await _httpClient.GetFromJsonAsync<Product>(
            $"api/products/{id}"
        );
    }
}
