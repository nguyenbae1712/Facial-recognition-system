namespace QuanlySieuthi
{
    partial class fAdd
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
            this.btCancel = new System.Windows.Forms.Button();
            this.btOK = new System.Windows.Forms.Button();
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
            this.gbInfor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btCancel);
            this.panel1.Controls.Add(this.btOK);
            this.panel1.Controls.Add(this.gbInfor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 217);
            this.panel1.TabIndex = 0;
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(419, 169);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(117, 30);
            this.btCancel.TabIndex = 3;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(247, 169);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(117, 30);
            this.btOK.TabIndex = 2;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
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
            this.gbInfor.TabIndex = 1;
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
            // fAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 217);
            this.Controls.Add(this.panel1);
            this.Name = "fAdd";
            this.Text = "Addform";
            this.panel1.ResumeLayout(false);
            this.gbInfor.ResumeLayout(false);
            this.gbInfor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btOK;
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
    }
}