namespace Sale_Store_Management.ComponenetForms
{
    partial class FormProductManagement
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            btnCancel = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            label5 = new Label();
            label4 = new Label();
            txtQuantity = new TextBox();
            txtPrice = new TextBox();
            label3 = new Label();
            txtProductName = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            dgvProducts = new DataGridView();
            clProduct = new DataGridViewTextBoxColumn();
            clPrice = new DataGridViewTextBoxColumn();
            clQty = new DataGridViewTextBoxColumn();
            clStatus = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(245, 245, 244);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1384, 67);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(220, 252, 231);
            label1.Font = new Font("Segoe UI", 14F);
            label1.ForeColor = Color.FromArgb(0, 166, 62);
            label1.Location = new Point(529, 17);
            label1.Name = "label1";
            label1.Padding = new Padding(5);
            label1.Size = new Size(210, 42);
            label1.TabIndex = 0;
            label1.Text = "Manage Products";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtQuantity);
            panel2.Controls.Add(txtPrice);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtProductName);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(28, 86);
            panel2.Name = "panel2";
            panel2.Size = new Size(1326, 249);
            panel2.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(224, 231, 255);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnCancel.ForeColor = Color.FromArgb(127, 34, 254);
            btnCancel.Location = new Point(424, 176);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(105, 45);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(254, 242, 242);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnDelete.ForeColor = Color.FromArgb(251, 44, 54);
            btnDelete.Image = Properties.Resources.icons8_delete_32;
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(287, 176);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(118, 45);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Deleted";
            btnDelete.TextAlign = ContentAlignment.MiddleRight;
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(240, 253, 244);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.FromArgb(0, 201, 80);
            btnUpdate.Image = Properties.Resources.icons8_pen_32__1_;
            btnUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdate.Location = new Point(147, 176);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(118, 45);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Edit";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(219, 234, 254);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            btnAdd.ForeColor = Color.FromArgb(21, 93, 252);
            btnAdd.Location = new Point(25, 176);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(105, 45);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "+ Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.ForeColor = SystemColors.GrayText;
            label5.Location = new Point(901, 68);
            label5.Name = "label5";
            label5.Size = new Size(106, 32);
            label5.TabIndex = 7;
            label5.Text = "Quantity";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.ForeColor = SystemColors.GrayText;
            label4.Location = new Point(561, 70);
            label4.Name = "label4";
            label4.Size = new Size(102, 32);
            label4.TabIndex = 6;
            label4.Text = "Prices($)";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtQuantity
            // 
            txtQuantity.BorderStyle = BorderStyle.FixedSingle;
            txtQuantity.Font = new Font("Segoe UI", 14F);
            txtQuantity.Location = new Point(901, 111);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(367, 39);
            txtQuantity.TabIndex = 5;
            // 
            // txtPrice
            // 
            txtPrice.BorderStyle = BorderStyle.FixedSingle;
            txtPrice.Font = new Font("Segoe UI", 14F);
            txtPrice.Location = new Point(561, 111);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(269, 39);
            txtPrice.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = SystemColors.GrayText;
            label3.Location = new Point(25, 72);
            label3.Name = "label3";
            label3.Size = new Size(138, 28);
            label3.TabIndex = 3;
            label3.Text = "Product Name";
            // 
            // txtProductName
            // 
            txtProductName.BorderStyle = BorderStyle.FixedSingle;
            txtProductName.Font = new Font("Segoe UI", 14F);
            txtProductName.Location = new Point(25, 111);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(504, 39);
            txtProductName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(56, 19);
            label2.Name = "label2";
            label2.Size = new Size(200, 32);
            label2.TabIndex = 1;
            label2.Text = "Manage Products";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.nventory_64;
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Location = new Point(7, 19);
            panel3.Name = "panel3";
            panel3.Size = new Size(43, 32);
            panel3.TabIndex = 0;
            // 
            // dgvProducts
            // 
            dgvProducts.BackgroundColor = SystemColors.ButtonFace;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { clProduct, clPrice, clQty, clStatus });
            dgvProducts.Location = new Point(27, 371);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.Size = new Size(1327, 184);
            dgvProducts.TabIndex = 2;
            dgvProducts.Font = new Font("Segoe UI", 12);
            // 
            // clProduct
            // 
            clProduct.HeaderText = "Products";
            clProduct.MinimumWidth = 10;
            clProduct.Name = "clProduct";
            clProduct.Width = 600;
            // 
            // clPrice
            // 
            clPrice.HeaderText = "Price";
            clPrice.MinimumWidth = 10;
            clPrice.Name = "clPrice";
            clPrice.Width = 250;
            // 
            // clQty
            // 
            clQty.HeaderText = "QTY";
            clQty.MinimumWidth = 10;
            clQty.Name = "clQty";
            clQty.Width = 200;
            // 
            // clStatus
            // 
            clStatus.HeaderText = "Status";
            clStatus.MinimumWidth = 10;
            clStatus.Name = "clStatus";
            clStatus.Width = 220;
            // 
            // FormProductManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1382, 599);
            Controls.Add(dgvProducts);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = SystemColors.AppWorkspace;
            Name = "FormProductManagement";
            Text = "FormProductManagement";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Label label2;
        private Label label5;
        private Label label4;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private Label label3;
        private TextBox txtProductName;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Button btnCancel;
        private DataGridView dgvProducts;
        private DataGridViewTextBoxColumn clProduct;
        private DataGridViewTextBoxColumn clPrice;
        private DataGridViewTextBoxColumn clQty;
        private DataGridViewTextBoxColumn clStatus;
    }
}