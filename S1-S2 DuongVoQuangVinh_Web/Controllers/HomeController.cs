using Microsoft.AspNetCore.Mvc;
using S1_S2_DuongVoQuangVinh__Web__.Models;
using S1_S2_DuongVoQuangVinh__Web__.Models.Interfaces;
using System.Diagnostics;

namespace S1_S2_DuongVoQuangVinh__Web__.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IProductRepository productRepository;

        public HomeController
        (
            ILogger<HomeController> logger,
            IProductRepository productRepository
        )
        {
            _logger = logger;

            this.productRepository = productRepository;
        }

        public IActionResult Index()
        {
            var trendingProducts =
                productRepository.GetTrendingProducts();

            return View(trendingProducts);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0,
            Location = ResponseCacheLocation.None,
            NoStore = true)]

        public IActionResult Error()
        {
            return View
            (
                new ErrorViewModel
                {
                    RequestId =
                    Activity.Current?.Id
                    ?? HttpContext.TraceIdentifier
                }
            );
        }
    }
}
