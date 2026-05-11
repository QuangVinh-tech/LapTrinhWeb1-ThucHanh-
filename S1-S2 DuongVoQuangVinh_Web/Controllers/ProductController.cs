using Microsoft.AspNetCore.Mvc;
using S1_S2_DuongVoQuangVinh__Web__.Models;
using S1_S2_DuongVoQuangVinh__Web__.Models.Interfaces;

namespace S1_S2_DuongVoQuangVinh__Web__.Controllers
{

    public class ProductController : Controller
    {
        private readonly IProductRepository productRepository;

        public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public IActionResult Shop()
        {
            var products = productRepository.GetAllProducts();

            return View(products);
        }
        public IActionResult Detail(int id)
        {
            var product = productRepository.GetProductDetail(id);

            if (product != null)
            {
                return View(product);
            }

            return NotFound();
        }
    }

}
