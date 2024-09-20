using Domain.Entities;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Layihe.Controllers
{
    internal class ProductController
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }



        public async Task CreateProduct()
        {
            Console.WriteLine("Enter Product Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Product Price:");
            decimal price;
            while (!decimal.TryParse(Console.ReadLine(), out price))
            {
                Console.WriteLine("Please enter a valid price.");
            }

            await _productService.CreateAsync(new Product { Name = name, Price = price, CreatedDate = DateTime.Now });

            Console.WriteLine("Product created successfully.");
        }

        public async Task<List<Product>> GetProducts()
        {
            try
            {
                return (List<Product>)await _productService.GetAllAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving products: {ex.Message}");
                return new List<Product>();
            }
        }

        public async Task UpdateProduct(int id)
        {
            Console.WriteLine("Enter New Product Name:");
            string newName = Console.ReadLine();

            Console.WriteLine("Enter New Product Price:");
            decimal newPrice;
            while (!decimal.TryParse(Console.ReadLine(), out newPrice))
            {
                Console.WriteLine("Please enter a valid price.");
            }

            try
            {
                var product = await _productService.GetByIdAsync(id);
                if (product != null)
                {
                    product.Name = newName;
                    product.Price = newPrice;
                    await _productService.UpdateAsync(product);
                    Console.WriteLine("Product updated successfully.");
                }
                else
                {
                    Console.WriteLine("Product not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating product: {ex.Message}");
            }
        }


        public async Task DeleteProduct(int id)
        {
            try
            {
                await _productService.DeleteAsync(id);
                Console.WriteLine("Product deleted successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting product: {ex.Message}");
            }
        }
        //public async Task CreateProduct(int id)
        //{
        //    Console.WriteLine("Enter Product Name:");
        //    string name = Console.ReadLine();

        //    Console.WriteLine("Enter Product Price:");
        //    decimal price;

        //    // Validate the price input
        //    while (!decimal.TryParse(Console.ReadLine(), out price) || price <= 0)
        //    {
        //        Console.WriteLine("Please enter a valid price greater than zero.");
        //    }

        //    Console.WriteLine("Enter Product Color:");
        //    string color = Console.ReadLine();

        //    // Optionally, prompt for other fields like category, etc.

        //    // Create a new Product instance
        //    var newProduct = new Product
        //    {
        //        Name = name,
        //        Price = price,
        //        Color = color,
        //        CreatedDate = DateTime.Now // Assuming you want to set the creation date
        //    };

        //    // Call the service to create the product
        //    await _productService.CreateAsync(newProduct);
        //    Console.WriteLine("Product created successfully.");
        //}

    }
}