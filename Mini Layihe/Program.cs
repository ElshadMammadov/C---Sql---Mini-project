

using System;
using System.Threading.Tasks;
using Service.Services.Interfaces;
using Service.Services; // Ensure this namespace contains your service implementations
using Domain.Entities; // Ensure this namespace contains your entity definitions
using Mini_Layihe.Controllers;
using Repository.Repositories.Interfaces;
using Repository.Repositories;
using Mini_Layihe.Helpers.Extentions;

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
                ConsoleColor.Red.WriteConsole("Choose an option:");
                ConsoleColor.Green.WriteConsole("1. Create Category");
                ConsoleColor.Green.WriteConsole("2. Get Categories");
                ConsoleColor.Green.WriteConsole("3. Get Category By ID");       
                ConsoleColor.Green.WriteConsole("4. Update Category");
                ConsoleColor.Green.WriteConsole("5. Delete Category");
                ConsoleColor.Green.WriteConsole("6. Search Categories");
                ConsoleColor.Green.WriteConsole("7. Get Categories with Products");
                ConsoleColor.Green.WriteConsole("8. Sort Categories by Created Date");
                ConsoleColor.Green.WriteConsole("9. Get Archive Categories");   
                Console.WriteLine("");
                ConsoleColor.Red.WriteConsole("Choose an option:");
                ConsoleColor.Cyan.WriteConsole("10. Create Product");
                ConsoleColor.Cyan.WriteConsole("11. Get Products");
                ConsoleColor.Cyan.WriteConsole("12. Update Product");
                ConsoleColor.Cyan.WriteConsole("13. Delete Product");
                ConsoleColor.Cyan.WriteConsole("14. Search Products by Name");
                ConsoleColor.Cyan.WriteConsole("15. Filter Products by Category Name");
                ConsoleColor.Cyan.WriteConsole("16. Sort Products by Price");
                ConsoleColor.Cyan.WriteConsole("17. Sort Products by Created Date");
                ConsoleColor.Cyan.WriteConsole("18. Search Products by Color");
                ConsoleColor.Cyan.WriteConsole("19. Delete Product By ID"); 
                ConsoleColor.Cyan.WriteConsole("20. Update Product By ID"); 
                ConsoleColor.Red.WriteConsole("21. Exit");

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
                        Console.WriteLine("Enter Category ID to get:");
                        int categoryId = int.Parse(Console.ReadLine());
                        await categoryController.GetByIdAsync(categoryId); // Added
                        break;
                    case "4":
                        Console.WriteLine("Enter Category ID to update:");
                        int updateCategoryId = int.Parse(Console.ReadLine());
                        await categoryController.UpdateCategoryAsync(updateCategoryId);
                        break;
                    case "5":
                        Console.WriteLine("Enter Category ID to delete:");
                        int deleteCategoryId = int.Parse(Console.ReadLine());
                        await categoryController.DeleteCategoryAsync(deleteCategoryId);
                        break;
                    case "6":
                        await categoryController.SearchAsync();
                        break;
                    case "7":
                        await categoryController.GetAllWithProducts();
                        break;
                    case "8":
                        await categoryController.SortWithCreatedDateAsync();
                        break;
                    //case "9":
                    //    await categoryController.GetArchiveCategoriesAsync(); // Added
                    //    break;
                    case "10":
                       await productController.CreateProduct();
                        break;
                    case "11":
                        await productController.GetAllProductsAsync();
                        break;
                    //case "12":
                    //    Console.WriteLine("Enter Product ID to update:");
                    //    int updateProductId = int.Parse(Console.ReadLine());
                    //    await productController.UpdateProductAsync(updateProductId); // Updated to async
                    //    break;
                    //case "13":
                    //    Console.WriteLine("Enter Product ID to delete:");
                    //    int deleteProductId = int.Parse(Console.ReadLine());
                    //    await productController.DeleteProductAsync(deleteProductId); // Updated to async
                    //    break;
                    case "14":
                        await productController.SearchByNameAsync();
                        break;
                    //case "15":
                    //    Console.WriteLine("Enter Category Name to filter products:");
                    //    string categoryName = Console.ReadLine();
                    //    var filteredProducts = await productController.FilterByCategoryNameAsync(categoryName); // Updated to async
                    //    foreach (var product in filteredProducts)
                    //    {
                    //        Console.WriteLine($"Filtered Product: {product.Name}");
                    //    }
                    //    break;
                    //case "16":
                    //    var sortedByPrice = await productController.SortWithPriceAsync(); // Updated to async
                    //    foreach (var product in sortedByPrice)
                    //    {
                    //        Console.WriteLine($"Product: {product.Name}, Price: {product.Price}");
                    //    }
                    //    break;
                    //case "17":
                    //    var sortedByDate = await productController.SortByCreatedDateAsync(); // Updated to async
                    //    foreach (var product in sortedByDate)
                    //    {
                    //        Console.WriteLine($"Product: {product.Name}, Created Date: {product.CreatedDate}");
                    //    }
                    //    break;
                    //case "18":
                    //    Console.WriteLine("Enter color to search for products:");
                    //    string color = Console.ReadLine();
                    //    var colorSearchedProducts = await productController.SearchByColorAsync(color); // Updated to async
                    //    foreach (var product in colorSearchedProducts)
                    //    {
                    //        Console.WriteLine($"Found Product by Color: {product.Name}");
                    //    }
                    //    break;                                     
                    //case "19":
                    //    Console.WriteLine("Enter Product ID to delete:");
                    //    int prodIdToDelete = int.Parse(Console.ReadLine());
                    //    await productController.DeleteProductAsync(prodIdToDelete); // Added
                    //    break;
                    //case "20":
                    //    Console.WriteLine("Enter Product ID to update:");
                    //    int prodIdToUpdate = int.Parse(Console.ReadLine());
                    //    await productController.UpdateProductAsync(prodIdToUpdate); // Added
                    //    break;
                    case "21":
                        return; // Exit the application
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
        }
    }
}