using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HajarShop.Domain.Dao;
using Microsoft.AspNetCore.Mvc;

namespace OnlineHajarShop.Web.Controllers
{
    [Route("api/[controller]")]
    //[ApiController]
    public class ProductController : Controller
    {
        [HttpGet("GetProduct")]
        public IActionResult GetProduct(int id)
        {
            if (Products.Find(x => x.ProductId == id) != null)
            {
                return Ok(Products.Find(x => x.ProductId == id));
            }

            return NotFound("Product non disponible pour l'instant");
        }

        [HttpGet("GetProductList")]
        public IActionResult GetProductList()
        {
            return Ok(Products);
        }

        [HttpPost("AddNewProduct")]
        public IActionResult AddNewProduct([FromBody]Product product)
        {
            if (product != null)
            {
                Products.Add(product);
            }
            
            return NoContent();
        }

        [HttpPost("AddNewProductList")]
        public IActionResult AddNewProductList([FromBody]IEnumerable<Product> productList)
        {
            if (productList?.Any() != null)
            {
                Products.AddRange(productList);
            }

            return NoContent();
        }

        [HttpPut("ModifyProduct")]
        public IActionResult ModifyProduct([FromBody]Product product)
        {
            Product existanceProduct = Products.FirstOrDefault(x => x.ProductId == product.ProductId);

            if (existanceProduct != null)
            {
                existanceProduct.Description = existanceProduct.Description + " " + product.Description;
            }

            return NoContent();
        }

        private List<Product> Products
        {
            get
            {
                return _product;
            }
            set
            {
                _product.AddRange(value);
            }
        }

        static List<Product> _product = new List<Product>
        {
                new Product {ProductId = 1, Title = "Clavier", Description = "HP 367778"},
                new Product {ProductId = 2, Title = "Souris", Description = "Dell 6634TZ3"},
                new Product {ProductId = 3, Title = "SM S6", Description = "Sumasung Phone"},
                new Product {ProductId = 4, Title = "J4", Description = "Sumasung j4 smart phone"}
         };
    }
}