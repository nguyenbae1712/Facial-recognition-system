using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanlySieuthi.DTO;
using QuanlySieuthi.DAL;

namespace QuanlySieuthi.BLL
{
    public class DBBLL
    {
        private static DBBLL instance;
        public static DBBLL Instance
        {
            get
            {
                if (instance == null) instance = new DBBLL();
                return instance;
            }
            private set { DBBLL.instance = value; }
        }
        private DBBLL() { }
        public List<Category> LoadCategories()
        {
            return DBDAL.Instance.GetCategories();
        }
        public List<Product> LoadProductsbyCatId(int id)
        {
            return DBDAL.Instance.GetProductsbyCatId(id);
        } 
        public Product LoadProductsbyId(int id)
        {
            return DBDAL.Instance.GetProductByID(id);
        }
        public object LoadNSX()
        {
            return DBDAL.Instance.GetNSX();
        }
        public List<Product> LoadProduct()
        {
            return DBDAL.Instance.GetProducts();
        }
        public object LoadRecordProduct()
        {
            return DBDAL.Instance.GetRecordProduct();
        }
        public bool Add(Product prod)
        {
            return DBDAL.Instance.Add(prod);
        }
        //public bool Update(int prodId, string prodname, DateTime DateIn, string NSX, bool state, int catid )
        //{
        //    return DBDAL.Instance.Update(prodId,prodname,DateIn,NSX,state,catid);
        //}
        public bool Update(Product prod)
        {
            return DBDAL.Instance.Update(prod);
        }
        public bool Delete(int id)
        {
            return DBDAL.Instance.Delete(id);
        }
        public List<Product> Search(List<Product> list, string str)
        {
            return list.Where(p => p.ProdName.Contains(str)).ToList();
        }
    }
}
