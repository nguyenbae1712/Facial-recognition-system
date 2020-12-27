using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanlySieuthi.DTO;

namespace QuanlySieuthi.DAL
{
    public class DBDAL
    {
        private static DBDAL instance;
        public static DBDAL Instance
        {
            get
            {
                if (instance == null) instance = new DBDAL();
                return instance;
            }
            private set { DBDAL.instance = value; }
        }
        private DBDAL() { }
        public List<Category> GetCategories()
        {
            using (Model1 db = new Model1())
            {
                return db.Categories.ToList();
            }
        }
        public List<Product> GetProductsbyCatId(int id)
        {
            using(Model1 db = new Model1())
            {
                return db.Products.Where(p => p.CatId == id).ToList();
            }
        }
        public Product GetProductByID(int id)
        {
            using (Model1 db = new Model1())
            {
                return db.Products.Where(p => p.ProdID == id).SingleOrDefault();
            }
        }
        public bool Edit(Product prod)
        {
            using (Model1 db = new Model1())
            {
                var e = db.Products.Where(p => p.ProdID == prod.ProdID).SingleOrDefault();
                e.ProdName = prod.ProdName;
                e.DateIn = prod.DateIn;
                e.State = prod.State;
                e.NSX = prod.NSX;
                e.CatId = prod.CatId;
                try 
                {
                    db.SaveChanges();
                    return true;
                } catch
                {
                    return false;
                }
            }
        }
        public bool Add(Product prod)
        {
            using(Model1 db = new Model1())
            {
                try
                {
                    db.Products.Add(prod);
                    db.SaveChanges();
                    return true;
                }
                catch { return false; }
            }
        }
        public bool Delete(int id)
        {
            using (Model1 db = new Model1())
            {
                var e = db.Products.Where(p => p.ProdID == id).SingleOrDefault();
                try
                {
                    db.Products.Remove(e);
                    db.SaveChanges();
                    return true;
                }
                catch { return false; }
            }
        }
    }
}
