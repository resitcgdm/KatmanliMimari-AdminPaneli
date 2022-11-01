using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Formats.Asn1;
using System.Reflection.Metadata;
using System.Threading;
using System.Xml.Linq;

namespace AdminUI.Controllers
{
    public class ProductController : Controller
    {
        IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService=productService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult UrunEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UrunEkle(Product product)
        {
             _productService.Ekle(product);
            return View();
        }
        [HttpGet]
        public IActionResult UrunSil()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UrunSil(Product product)
        {
            _productService.Sil(product);
            return View();
        }
        [HttpGet]
        public IActionResult UrunGuncelle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UrunGuncelle(Product product)
        {
            _productService.Guncelle(product);
            return View();
        }
        public IActionResult UrunListeleIdyeGore()
        {
            return View();

        }
        [HttpPost] 
        public IActionResult UrunListeleIdyeGore(int id)
        {
            var result = _productService.ProductGetirWithId(id);
            return View(result);
          
        }
        [HttpGet]
        public IActionResult UrunlerinHepsiniListele()
        {
            var result = _productService.ListGetir();
            return View(result);
        }
    }
}



