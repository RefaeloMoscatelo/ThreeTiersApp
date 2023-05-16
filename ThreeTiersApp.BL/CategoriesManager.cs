using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThreeTiersApp.DAL;
using ThreeTiersApp.DataEntities;

namespace ThreeTiersApp.BL
{
    public class CategoriesManager
    {
       public List<Category> GetAllCategories()
       {
           using (NorthwindEntities db = new NorthwindEntities())
           {
               return db.Categories.ToList();
           }
       }

    }
}