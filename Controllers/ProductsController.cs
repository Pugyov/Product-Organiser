using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Homework3.Data;
using Homework3.Models;

namespace Homework3.Controllers
{
    public class ProductsController : Controller
    {
        private readonly AppDbContext _context;

        public ProductsController(AppDbContext context)
        {
            _context = context;
        }

        // Home Page
        public async Task<IActionResult> Index()
        {
            var cheapestProducts = await _context.Products.OrderBy(p => p.Price).Take(3).ToListAsync();
            return View(cheapestProducts);
        }

        //List All Products
        public async Task<IActionResult> List()
        {
            var products = await _context.Products.OrderBy(p => p.Name).ToListAsync();
            return View(products);
        }

        //Product Details
        public async Task<IActionResult> Details(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null) return NotFound();
            return View(product);
        }

        //Add Product (GET)
        public IActionResult Add()
        {
            return View();
        }

        //Add Product (POST)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(List));
            }
            return View(product);
        }

        //Delete Product
        public async Task<IActionResult> Delete(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null) return NotFound();

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(List));
        }
    }
}
