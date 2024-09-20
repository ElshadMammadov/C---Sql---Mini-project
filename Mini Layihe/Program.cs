

using System;
using System.Threading.Tasks;
using Service.Services.Interfaces;
using Service.Services; // Ensure this namespace contains your service implementations
using Domain.Entities; // Ensure this namespace contains your entity definitions
using Mini_Layihe.Controllers;
using Repository.Repositories.Interfaces;
using Repository.Repositories;

namespace Mini_Layihe
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Create repository instances
            IProductRepository productRepository = new ProductRepository(); // Ensure this is your actual implementation
            ICategoryRepository categoryRepository = new CategoryRepository(); // Ensure this is your actual implementation

            // Create service instances
            ICategoryService categoryService = new CategoryService(categoryRepository);
            IProductService productService = new ProductService(productRepository);

            // Create controllers
            var categoryController = new CategoryController(categoryService);
            var productController = new ProductController(productService);

            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Create Category");
                Console.WriteLine("2. Get Categories");
                Console.WriteLine("3. Update Category");
                Console.WriteLine("4. Delete Category");
                Console.WriteLine("5. Search Categories");
                Console.WriteLine("6. Get Categories with Products");
                Console.WriteLine("7. Sort Categories by Created Date");
                Console.WriteLine("8. Create Product");
                Console.WriteLine("9. Get Products");
                Console.WriteLine("10. Update Product");
                Console.WriteLine("11. Delete Product");
                Console.WriteLine("12. Search Products by Name");
                Console.WriteLine("13. Filter Products by Category Name");
                Console.WriteLine("14. Sort Products by Price");
                Console.WriteLine("15. Sort Products by Created Date");
                Console.WriteLine("16. Search Products by Color");
                Console.WriteLine("17. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        await categoryController.CreateCategory();
                        break;
                    case "2":
                        await categoryController.GetCategoriesAsync();                      
                        break;
                    case "3":
                        Console.WriteLine("Enter Category ID to update:");
                        int updateCategoryId = int.Parse(Console.ReadLine());
                        await categoryController.UpdateCategoryAsync(updateCategoryId);
                        break;
                    case "4":
                        Console.WriteLine("Enter Category ID to delete:");
                        int deleteCategoryId = int.Parse(Console.ReadLine());
                        await categoryController.DeleteCategoryAsync(deleteCategoryId);
                        break;
                    //case "5":
                    //    Console.WriteLine("Enter search text for categories:");
                    //    string searchText = Console.ReadLine();
                    //    var searchedCategories = await categoryController.Search(searchText);
                    //    foreach (var category in searchedCategories)
                    //    {
                    //        Console.WriteLine($"Found Category: {category.Name}");
                    //    }
                    //    break;
                    //case "6":
                    //    var categoriesWithProducts = await categoryController.GetAllWithProducts();
                    //    foreach (var category in categoriesWithProducts)
                    //    {
                    //        Console.WriteLine($"Category: {category.Name}, Products: {category.Products.Count}");
                    //    }
                    //    break;
                    //case "7":
                    //    var sortedCategories = await categoryController.SortWithCreatedDate();
                    //    foreach (var category in sortedCategories)
                    //    {
                    //        Console.WriteLine($"Category: {category.Name}, Created Date: {category.CreatedDate}");
                    //    }
                    //    break;
                    case "8":
                        await productController.CreateProduct();
                        break;
                    case "9":
                        var products = await productController.GetProducts();
                        foreach (var product in products)
                        {
                            Console.WriteLine($"Product: {product.Name}, Price: {product.Price}");
                        }
                        break;
                    case "10":
                        Console.WriteLine("Enter Product ID to update:");
                        int updateProductId = int.Parse(Console.ReadLine());
                        await productController.UpdateProduct(updateProductId);
                        break;
                    case "11":
                        Console.WriteLine("Enter Product ID to delete:");
                        int deleteProductId = int.Parse(Console.ReadLine());
                        await productController.DeleteProduct(deleteProductId);
                        break;
                    //case "12":
                    //    Console.WriteLine("Enter search text for products:");
                    //    string productSearchText = Console.ReadLine();
                    //    var searchedProducts = await productController.SearchByName(productSearchText);
                    //    foreach (var product in searchedProducts)
                    //    {
                    //        Console.WriteLine($"Found Product: {product.Name}");
                    //    }
                    //    break;
                    //case "13":
                    //    Console.WriteLine("Enter Category Name to filter products:");
                    //    string categoryName = Console.ReadLine();
                    //    var filteredProducts = await productController.FilterByCategoryName(categoryName);
                    //    foreach (var product in filteredProducts)
                    //    {
                    //        Console.WriteLine($"Filtered Product: {product.Name}");
                    //    }
                    //    break;
                    //case "14":
                    //    var sortedByPrice = await productController.SortWithPrice();
                    //    foreach (var product in sortedByPrice)
                    //    {
                    //        Console.WriteLine($"Product: {product.Name}, Price: {product.Price}");
                    //    }
                    //    break;
                    //case "15":
                    //    var sortedByDate = await productController.SortByCreatedDate();
                    //    foreach (var product in sortedByDate)
                    //    {
                    //        Console.WriteLine($"Product: {product.Name}, Created Date: {product.CreatedDate}");
                    //    }
                    //    break;
                    //case "16":
                    //    Console.WriteLine("Enter color to search for products:");
                    //    string color = Console.ReadLine();
                    //    var colorSearchedProducts = await productController.SearchByColor(color);
                    //    foreach (var product in colorSearchedProducts)
                    //    {
                    //        Console.WriteLine($"Found Product by Color: {product.Name}");
                    //    }
                    //    break;
                    case "17":
                        return; // Exit the application
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
        }
    }
}