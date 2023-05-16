using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThreeTiersApp.DAL;
using ThreeTiersApp.DataEntities;

namespace ThreeTiersApp.BL
{
   public class ProductsManager
    {
       public List<Product> GetAllProducts()
       {
           using (NorthwindEntities db = new NorthwindEntities())
           {
               return db.Products.ToList();
           }
       }

       public List<Product> GetProductsByCategoryID(int catID)
       {
           using (NorthwindEntities db = new NorthwindEntities())
           {
               return db.Products.Where(x => x.CategoryID == catID).ToList();
           }
       }

       public void Update(Product p)
       {
           using (NorthwindEntities db = new NorthwindEntities())
           {
               db.Products.Attach(p);
               db.Entry(p).State = System.Data.EntityState.Modified;
               db.SaveChanges();
           }
        
       }

       public void Insert(Product p)
       {
           using (NorthwindEntities db = new NorthwindEntities())
           {
               db.Products.Add(p);
               db.SaveChanges();
           }

       }




    }
}