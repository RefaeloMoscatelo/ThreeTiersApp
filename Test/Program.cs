using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThreeTiersApp.BL;
using ThreeTiersApp.DataEntities;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductsManager productsManager = new ProductsManager();
            CategoriesManager manager = new CategoriesManager();
            var allCats = manager.GetAllCategories();
            var allProducts = productsManager.GetAllProducts();
            var f = allProducts.First();
            f.ProductName = "NEW NAME4";
            //f.Category = new Category { CategoryName = "NEW CAT", Description = "111" };
            //f.Category = allCats[0];
            f.CategoryID = allCats[0].CategoryID;
            productsManager.Insert(f);
        }
    }
}
