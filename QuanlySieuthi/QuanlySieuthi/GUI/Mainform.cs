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
using QuanlySieuthi.DTO;

namespace QuanlySieuthi
{
    public partial class fMain : Form
    {
        BindingSource data = new BindingSource();
        Model1 mol = new Model1();
        public fMain()
        {
            InitializeComponent();
            load();
        }

        private void load()
        {
            LoadCategories();
            LoadRecord();
            LoadNSX();
        }
        public void LoadRecord()
        {
            dgvProduct.AllowUserToAddRows = false;
            dgvProduct.DataSource = DBBLL.Instance.LoadRecordProduct();
        }
        void LoadCategories()
        {
            cbCat.DataSource = DBBLL.Instance.LoadCategories();
            cbCat.DisplayMember = "CatName";
            cbCat.ValueMember = "CatId";
        }
        void LoadNSX()
        {
            cbNSX.DataSource = DBBLL.Instance.LoadNSX();
            
        }
        private void addBinding()
        {
            tbIdProd.DataBindings.Add(new Binding("Text", dgvProduct.DataSource, "ProdId", true, DataSourceUpdateMode.Never));
            tbProdName.DataBindings.Add(new Binding("Text", dgvProduct.DataSource, "ProdName", true, DataSourceUpdateMode.Never));
            cbNSX.DataBindings.Add(new Binding("Text", dgvProduct.DataSource, "NSX", true, DataSourceUpdateMode.Never));
            cbCat.DataBindings.Add(new Binding("Text", dgvProduct.DataSource, "CatName", true, DataSourceUpdateMode.Never));
            dtDateIn.DataBindings.Add(new Binding("Text", dgvProduct.DataSource, "DateIn", true, DataSourceUpdateMode.Never));
            if (dgvProduct.Rows[0] != null)
            {
                if ((bool)dgvProduct.Rows[0].Cells[7].Value == true)
                {
                    rbStock.DataBindings.Add(new Binding("Checked", dgvProduct.DataSource, "State"));
                }
                else
                {
                    rbSold.DataBindings.Add(new Binding("Checked", dgvProduct.DataSource, "State"));
                }
            }
        }
        private void Add()
        {
            fAdd f = new fAdd();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }


        //private void UpdateSinhVien()
        //{
        //    try
        //    {
        //        int id = (int)dgvProduct.SelectedCells[0].Value;
        //        if ((bool)dgvProduct.CurrentRow.Cells[7].Value == true)
        //        {
        //            if (DBBLL.Instance.Update())
        //            {
        //                MessageBox.Show("Cap nhap thanh cong");
        //                LoadRecord();
        //            }
        //            else
        //            {
        //                MessageBox.Show("Loi!!!");
        //            }
        //        }
        //        else
        //        {
        //            if (DBBLL.Instance.Update(id, Convert.ToInt32(tbIdProd.Text), tbProdName.Text, cbNSX.Text, cbCat.Text, dtDateIn.Value, true))
        //            {
        //                MessageBox.Show("Cap nhap thanh cong");
        //                LoadRecord();
        //            }
        //            else
        //            {
        //                MessageBox.Show("Loi!!!");
        //            }
        //        }
        //    }
        //    catch { MessageBox.Show("Loi!!"); }
        //}

        private void Delete()
        {
            try
            {
                int id = (int)dgvProduct.SelectedCells[0].Value;
                if (DBBLL.Instance.Delete(id))
                {
                    MessageBox.Show("Xoa thanh cong");
                    LoadRecord();
                }
                else
                {
                    MessageBox.Show("Loi!!!");
                }
            }
            catch { MessageBox.Show("Loi!!"); }
        }
        private void Search()
        {
            List<Product> list = DBBLL.Instance.LoadProduct();
            dgvProduct.DataSource = DBBLL.Instance.Search(list, tbSearch.Text);
        }
    }
}
