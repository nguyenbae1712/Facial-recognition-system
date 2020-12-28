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
        Model1 db = new Model1();
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
            return db.Categories.Distinct().ToList();
        }
        public List<Product> GetProducts()
        {
            return db.Products.ToList();
        }
        public object GetNSX()
        {
            return db.Products.Select(p => p.NSX).Distinct().ToList();
        }
        public List<Product> GetProductsbyCatId(int id)
        {
            return db.Products.Where(p => p.CatId == id).ToList();
        }
        public Product GetProductByID(int id)
        {
            return db.Products.Where(p => p.ProdID == id).SingleOrDefault();
        }
        public object GetRecordProduct()
        {
            var record = db.Products.Select(p => new
            {
                ProdId = p.ProdID,
                ProdName = p.ProdName,
                NSX = p.NSX,
                DateIn = p.DateIn,
                CatName = p.Category.CatName,
                State = p.State
            }) ;
            return record.ToList();
        }
        public bool Update(Product prod)
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
            }
            catch
            {
                return false;
            }
        }
        public bool Add(Product prod)
        {
            try
            {
                db.Products.Add(prod);
                db.SaveChanges();
                return true;
            }
            catch { return false; }
        }
        public bool Delete(int id)
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
