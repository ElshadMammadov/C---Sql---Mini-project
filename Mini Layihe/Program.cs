
using System;
using System.Threading.Tasks;
using Service.Services.Interfaces;
using Service.Services; // Ensure this namespace contains your service implementations
using Domain.Entities; // Ensure this namespace contains your entity definitions
using Mini_Layihe.Controllers;
using Repository.Repositories.Interfaces;
using Repository.Repositories;
using Mini_Layihe.Helpers.Extentions;
using Microsoft.Extensions.Options;
using Mini_Layihe.Helpers.Enum;


CategoryController categoryController = new ();
ProductController productController = new ();

GetMenues();

while (true)
{
   

Menu: string SelectedMenu = Console.ReadLine(); 

    bool isCorrectMenu = int.TryParse(SelectedMenu, out int menu);

    if (isCorrectMenu)
    {
        switch (menu)
        {
            case (int)Menues.CreateCategory:
                await categoryController.CreateCategory();
                break;
            case (int)Menues.GetAllCategory:
                await categoryController.GetCategoriesAsync();
                break;
            case (int)Menues.GetByIdCategory:
                Console.WriteLine("Enter Category ID to get:");
                int categoryId = int.Parse(Console.ReadLine());
                await categoryController.GetByIdAsync(categoryId); 
                break;
            case (int)Menues.UpdateCategory:
                Console.WriteLine("Enter Category ID to update:");
                int updateCategoryId = int.Parse(Console.ReadLine());
                await categoryController.UpdateCategoryAsync(updateCategoryId);
                break;
            case (int)Menues.DeleteCategory:
                Console.WriteLine("Enter Category ID to delete:");
                int deleteCategoryId = int.Parse(Console.ReadLine());
                await categoryController.DeleteCategoryAsync(deleteCategoryId);
                break;
            case (int)Menues.SearchCategories:
                await categoryController.SearchAsync();
                break;

            case (int)Menues.GetAllWithProducts:
                await categoryController.GetAllWithProducts();
                break;
            case (int)Menues.SortWithCreatedDate:
                await categoryController.SortWithCreatedDateAsync();
                break;
            //case (int)Menues.GetArchiveCategories: 
            //    await categoryController.GetArchiveCategoriesAsync();
            //    break;
            case (int)Menues.CreateProduct:
                await productController.CreateProduct();
                break;
            case (int)Menues.GetAllProduct:
                await productController.GetAllProductsAsync();
                break;
            case (int)Menues.UpdateProduct:
                Console.WriteLine("Enter Product ID to update:");
                int updateProductId = int.Parse(Console.ReadLine());
                await productController.UpdateProductAsync(updateProductId); // Updated to async
                break;
            //case (int)Menues.DeleteProduct:
             
            //    break;
            case (int)Menues.SearchByName:
                await productController.SearchByNameAsync();
                break;
            case (int)Menues.FilterByCategoryName:
                await productController.FilterByCategoryNameAsync();
                break;
            case (int)Menues.SortWithPrice:
                await productController.SortByPrice();
                break;
            case (int)Menues.SortByCreatedDate:
                productController.SortByCreateDate();
                break;
            //case (int)Menues.SearchByColor:

            //    break;
            //case (int)Menues.GetAllWithCategoryId:

            //    break;
            //case (int)Menues.GetByID:

            //    break;
            case (21):
                return;  //Exit the applicationthe application
            default:
                ConsoleColor.DarkRed.WriteConsole("Please select correct option from menu:");
                goto Menu;

        }
    }
    else
    {
        ConsoleColor.DarkRed.WriteConsole("Please select correct format option: (only digits)");
        goto Menu;
    }
}
    
static void GetMenues()
{
    ConsoleColor.Blue.WriteConsole("Please select one option");
    ConsoleColor.Red.WriteConsole("Category");
    ConsoleColor.Green.WriteConsole("\n  1. Create \n  2. GetAll \n  3. GetById \n  4. Update \n  5. Delete \n  6. Search \n  7. GetAllWithProducts \n  8. SortWithCreatedDate \n  9. GetArchiveCategories");
    Console.WriteLine();
    ConsoleColor.Blue.WriteConsole("Please select one option");
    ConsoleColor.Red.WriteConsole("Product");
    ConsoleColor.Green.WriteConsole(" \n  10. Create \n  11. GetAll \n  12. Update \n  13. Delete \n  14. SearchByName\n  15. FilterByCategoryName\n  16. SortWithPrice\n  17. SortByCreatedDate\n  18. SearchByColor\n  19. GetAllWithCategoryId\n  20. GetByID\n  21. Exit");

}
