using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanlySieuthi.BLL;
using QuanlySieuthi.DAL;

namespace QuanlySieuthi
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
            LoadCategories();
        }

        void LoadCategories()
        {
            cbCat.DataSource = DBBLL.Instance.LoadCategories();
           // cbCat.DisplayMember = "TenMathang";
            //cbCat.ValueMember = "MaMathang";
        }
        void LoadNSX()
        {

        }
    }
}
