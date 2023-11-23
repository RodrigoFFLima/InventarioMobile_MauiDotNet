using InventarioMobile.Models.Response;
using InventarioMobile.Repositorios.Product;

namespace InventarioMobile.ViewModels
{
    public partial class ProductsViewModel : BaseViewModel
    {
        public ObservableCollection<ProductResponse> Products { get; set; }
            = new ObservableCollection<ProductResponse>();

        private readonly IProductRepositorio _productRepositorio;
        public ProductsViewModel(IProductRepositorio productRepositorio)
        {
            _productRepositorio = productRepositorio;
        }

        internal async Task InitiAsync()
        {
            IsBusy = true;

            var products = await _productRepositorio.GetProductsAsync();

            Products.Clear();

            foreach (var product in products)
                Products.Add(product);

            IsBusy = false;
        }
    }
}
