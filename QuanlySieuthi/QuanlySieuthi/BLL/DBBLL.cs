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
        public bool Edit(Product prod)
        {
            return DBDAL.Instance.Edit(prod);
        }
        public bool Delete(int id)
        {
            return DBDAL.Instance.Delete(id);
        }
    }
}
