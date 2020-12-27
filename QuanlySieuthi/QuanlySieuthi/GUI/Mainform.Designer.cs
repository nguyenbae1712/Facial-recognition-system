namespace QuanlySieuthi
{
    partial class fMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbSort = new System.Windows.Forms.ComboBox();
            this.btSort = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btShow = new System.Windows.Forms.Button();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.gbInfor = new System.Windows.Forms.GroupBox();
            this.rbSold = new System.Windows.Forms.RadioButton();
            this.rbStock = new System.Windows.Forms.RadioButton();
            this.cbNSX = new System.Windows.Forms.ComboBox();
            this.cbCat = new System.Windows.Forms.ComboBox();
            this.dtDateIn = new System.Windows.Forms.DateTimePicker();
            this.tbProdName = new System.Windows.Forms.TextBox();
            this.tbIdProd = new System.Windows.Forms.TextBox();
            this.lbState = new System.Windows.Forms.Label();
            this.lbNSX = new System.Windows.Forms.Label();
            this.lbCat = new System.Windows.Forms.Label();
            this.lbDateIn = new System.Windows.Forms.Label();
            this.lbProdName = new System.Windows.Forms.Label();
            this.lbIdProd = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.gbInfor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.gbInfor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbSort);
            this.panel2.Controls.Add(this.btSort);
            this.panel2.Controls.Add(this.tbSearch);
            this.panel2.Controls.Add(this.btSearch);
            this.panel2.Controls.Add(this.btDelete);
            this.panel2.Controls.Add(this.btUpdate);
            this.panel2.Controls.Add(this.btAdd);
            this.panel2.Controls.Add(this.btShow);
            this.panel2.Controls.Add(this.dgvProduct);
            this.panel2.Location = new System.Drawing.Point(12, 151);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 287);
            this.panel2.TabIndex = 1;
            // 
            // cbSort
            // 
            this.cbSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSort.FormattingEnabled = true;
            this.cbSort.Location = new System.Drawing.Point(121, 245);
            this.cbSort.Name = "cbSort";
            this.cbSort.Size = new System.Drawing.Size(200, 28);
            this.cbSort.TabIndex = 10;
            // 
            // btSort
            // 
            this.btSort.Location = new System.Drawing.Point(15, 245);
            this.btSort.Name = "btSort";
            this.btSort.Size = new System.Drawing.Size(90, 29);
            this.btSort.TabIndex = 9;
            this.btSort.Text = "Sort";
            this.btSort.UseVisualStyleBackColor = true;
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(543, 205);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(211, 27);
            this.tbSearch.TabIndex = 8;
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(446, 203);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(90, 33);
            this.btSearch.TabIndex = 7;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = true;
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(340, 203);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(90, 33);
            this.btDelete.TabIndex = 6;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(231, 203);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(90, 33);
            this.btUpdate.TabIndex = 5;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(120, 203);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(90, 33);
            this.btAdd.TabIndex = 4;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            // 
            // btShow
            // 
            this.btShow.Location = new System.Drawing.Point(15, 203);
            this.btShow.Name = "btShow";
            this.btShow.Size = new System.Drawing.Size(90, 33);
            this.btShow.TabIndex = 3;
            this.btShow.Text = "Show";
            this.btShow.UseVisualStyleBackColor = true;
            // 
            // dgvProduct
            // 
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(3, 3);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowHeadersWidth = 51;
            this.dgvProduct.RowTemplate.Height = 24;
            this.dgvProduct.Size = new System.Drawing.Size(773, 185);
            this.dgvProduct.TabIndex = 2;
            // 
            // gbInfor
            // 
            this.gbInfor.Controls.Add(this.rbSold);
            this.gbInfor.Controls.Add(this.rbStock);
            this.gbInfor.Controls.Add(this.cbNSX);
            this.gbInfor.Controls.Add(this.cbCat);
            this.gbInfor.Controls.Add(this.dtDateIn);
            this.gbInfor.Controls.Add(this.tbProdName);
            this.gbInfor.Controls.Add(this.tbIdProd);
            this.gbInfor.Controls.Add(this.lbState);
            this.gbInfor.Controls.Add(this.lbNSX);
            this.gbInfor.Controls.Add(this.lbCat);
            this.gbInfor.Controls.Add(this.lbDateIn);
            this.gbInfor.Controls.Add(this.lbProdName);
            this.gbInfor.Controls.Add(this.lbIdProd);
            this.gbInfor.Location = new System.Drawing.Point(12, 12);
            this.gbInfor.Name = "gbInfor";
            this.gbInfor.Size = new System.Drawing.Size(776, 137);
            this.gbInfor.TabIndex = 0;
            this.gbInfor.TabStop = false;
            this.gbInfor.Text = "Thông tin";
            // 
            // rbSold
            // 
            this.rbSold.AutoSize = true;
            this.rbSold.Location = new System.Drawing.Point(645, 101);
            this.rbSold.Name = "rbSold";
            this.rbSold.Size = new System.Drawing.Size(87, 21);
            this.rbSold.TabIndex = 12;
            this.rbSold.TabStop = true;
            this.rbSold.Text = "Hết hàng";
            this.rbSold.UseVisualStyleBackColor = true;
            // 
            // rbStock
            // 
            this.rbStock.AutoSize = true;
            this.rbStock.Location = new System.Drawing.Point(529, 101);
            this.rbStock.Name = "rbStock";
            this.rbStock.Size = new System.Drawing.Size(90, 21);
            this.rbStock.TabIndex = 11;
            this.rbStock.TabStop = true;
            this.rbStock.Text = "Còn hàng";
            this.rbStock.UseVisualStyleBackColor = true;
            // 
            // cbNSX
            // 
            this.cbNSX.FormattingEnabled = true;
            this.cbNSX.Location = new System.Drawing.Point(510, 68);
            this.cbNSX.Name = "cbNSX";
            this.cbNSX.Size = new System.Drawing.Size(244, 24);
            this.cbNSX.TabIndex = 10;
            // 
            // cbCat
            // 
            this.cbCat.FormattingEnabled = true;
            this.cbCat.Location = new System.Drawing.Point(510, 34);
            this.cbCat.Name = "cbCat";
            this.cbCat.Size = new System.Drawing.Size(244, 24);
            this.cbCat.TabIndex = 9;
            // 
            // dtDateIn
            // 
            this.dtDateIn.Location = new System.Drawing.Point(121, 101);
            this.dtDateIn.Name = "dtDateIn";
            this.dtDateIn.Size = new System.Drawing.Size(244, 22);
            this.dtDateIn.TabIndex = 8;
            // 
            // tbProdName
            // 
            this.tbProdName.Location = new System.Drawing.Point(121, 68);
            this.tbProdName.Name = "tbProdName";
            this.tbProdName.Size = new System.Drawing.Size(244, 22);
            this.tbProdName.TabIndex = 7;
            // 
            // tbIdProd
            // 
            this.tbIdProd.Location = new System.Drawing.Point(121, 34);
            this.tbIdProd.Name = "tbIdProd";
            this.tbIdProd.Size = new System.Drawing.Size(244, 22);
            this.tbIdProd.TabIndex = 6;
            // 
            // lbState
            // 
            this.lbState.AutoSize = true;
            this.lbState.Location = new System.Drawing.Point(404, 103);
            this.lbState.Name = "lbState";
            this.lbState.Size = new System.Drawing.Size(73, 17);
            this.lbState.TabIndex = 5;
            this.lbState.Text = "Tình trạng";
            // 
            // lbNSX
            // 
            this.lbNSX.AutoSize = true;
            this.lbNSX.Location = new System.Drawing.Point(404, 68);
            this.lbNSX.Name = "lbNSX";
            this.lbNSX.Size = new System.Drawing.Size(56, 17);
            this.lbNSX.TabIndex = 4;
            this.lbNSX.Text = "Nhà SX";
            // 
            // lbCat
            // 
            this.lbCat.AutoSize = true;
            this.lbCat.Location = new System.Drawing.Point(404, 34);
            this.lbCat.Name = "lbCat";
            this.lbCat.Size = new System.Drawing.Size(67, 17);
            this.lbCat.TabIndex = 3;
            this.lbCat.Text = "Mặt hàng";
            // 
            // lbDateIn
            // 
            this.lbDateIn.AutoSize = true;
            this.lbDateIn.Location = new System.Drawing.Point(12, 105);
            this.lbDateIn.Name = "lbDateIn";
            this.lbDateIn.Size = new System.Drawing.Size(77, 17);
            this.lbDateIn.TabIndex = 2;
            this.lbDateIn.Text = "Ngày nhập";
            // 
            // lbProdName
            // 
            this.lbProdName.AutoSize = true;
            this.lbProdName.Location = new System.Drawing.Point(12, 71);
            this.lbProdName.Name = "lbProdName";
            this.lbProdName.Size = new System.Drawing.Size(99, 17);
            this.lbProdName.TabIndex = 1;
            this.lbProdName.Text = "Tên sản phẩm";
            // 
            // lbIdProd
            // 
            this.lbIdProd.AutoSize = true;
            this.lbIdProd.Location = new System.Drawing.Point(12, 37);
            this.lbIdProd.Name = "lbIdProd";
            this.lbIdProd.Size = new System.Drawing.Size(93, 17);
            this.lbIdProd.TabIndex = 0;
            this.lbIdProd.Text = "Mã sản phẩm";
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "fMain";
            this.Text = "Mainform";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.gbInfor.ResumeLayout(false);
            this.gbInfor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.GroupBox gbInfor;
        private System.Windows.Forms.RadioButton rbSold;
        private System.Windows.Forms.RadioButton rbStock;
        private System.Windows.Forms.ComboBox cbNSX;
        private System.Windows.Forms.ComboBox cbCat;
        private System.Windows.Forms.DateTimePicker dtDateIn;
        private System.Windows.Forms.TextBox tbProdName;
        private System.Windows.Forms.TextBox tbIdProd;
        private System.Windows.Forms.Label lbState;
        private System.Windows.Forms.Label lbNSX;
        private System.Windows.Forms.Label lbCat;
        private System.Windows.Forms.Label lbDateIn;
        private System.Windows.Forms.Label lbProdName;
        private System.Windows.Forms.Label lbIdProd;
        private System.Windows.Forms.ComboBox cbSort;
        private System.Windows.Forms.Button btSort;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btShow;
    }
}

