using Flurl;
using Flurl.Http;
using InventarioMobile.Helpers;
using InventarioMobile.Models.Request;
using InventarioMobile.Models.Response;

namespace InventarioMobile.Repositorios.Product
{
    public class ProductRepositorio : IProductRepositorio
    {
        public async Task<IEnumerable<ProductResponse>> GetProductsAsync()
        {
            return await Constants.ApiUrl
                .AppendPathSegment("/products")
                .WithOAuthBearerToken(Preferences.Get("token", string.Empty))
                .GetJsonAsync<IEnumerable<ProductResponse>>();
        }

        public async Task<bool> AddAsync(ProductRequest productRequest)
        {
            var response = await Constants.ApiUrl
                .AppendPathSegment("/products")
                .WithOAuthBearerToken(Preferences.Get("token", string.Empty))
                .PostJsonAsync(productRequest);

            return response.ResponseMessage.IsSuccessStatusCode;
        }

        public Task<bool> UpdateAsync(ProductRequest productRequest)
        {
            throw new NotImplementedException();
        }
    }
}
