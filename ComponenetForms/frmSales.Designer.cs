namespace Sale_Store_Management.ComponenetForms
{
    partial class frmSales
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            button1 = new Button();
            comboBox1 = new ComboBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label7 = new Label();
            label6 = new Label();
            label9 = new Label();
            label8 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            SALE_ID = new DataGridViewTextBoxColumn();
            PRODUCT = new DataGridViewTextBoxColumn();
            QTY = new DataGridViewTextBoxColumn();
            UNIT_PRICE = new DataGridViewTextBoxColumn();
            TOTAL = new DataGridViewTextBoxColumn();
            DATE_TIME = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Location = new Point(28, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(1358, 270);
            panel1.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(5, 223, 114);
            button1.ForeColor = Color.White;
            button1.Location = new Point(20, 183);
            button1.Name = "button1";
            button1.Size = new Size(1303, 54);
            button1.TabIndex = 15;
            button1.Text = "✔️ Sale Process";
            button1.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(20, 121);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(480, 34);
            comboBox1.TabIndex = 14;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(1073, 121);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(250, 34);
            textBox3.TabIndex = 13;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(783, 121);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 34);
            textBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(542, 121);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(203, 34);
            textBox1.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1073, 74);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(84, 26);
            label5.TabIndex = 10;
            label5.Text = "TOTAL";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(542, 74);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(128, 26);
            label7.TabIndex = 8;
            label7.Text = "QUANTITY";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(783, 74);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(135, 26);
            label6.TabIndex = 9;
            label6.Text = "UNIT PRICE";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(20, 17);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(194, 39);
            label9.TabIndex = 6;
            label9.Text = "\U0001f9fe New Sale";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(20, 74);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(117, 26);
            label8.TabIndex = 7;
            label8.Text = "PRODUCT";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(49, 327);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(230, 39);
            label1.TabIndex = 16;
            label1.Text = "📃 Sale History";
            label1.Click += label1_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { SALE_ID, PRODUCT, QTY, UNIT_PRICE, TOTAL, DATE_TIME });
            dataGridView1.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridView1.GridColor = SystemColors.InactiveBorder;
            dataGridView1.Location = new Point(28, 379);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 100;
            dataGridView1.Size = new Size(1358, 348);
            dataGridView1.TabIndex = 17;
            dataGridView1.VirtualMode = true;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // SALE_ID
            // 
            dataGridViewCellStyle1.Padding = new Padding(10);
            SALE_ID.DefaultCellStyle = dataGridViewCellStyle1;
            SALE_ID.FillWeight = 60F;
            SALE_ID.Frozen = true;
            SALE_ID.HeaderText = "SALE ID";
            SALE_ID.MinimumWidth = 10;
            SALE_ID.Name = "SALE_ID";
            SALE_ID.ReadOnly = true;
            SALE_ID.Width = 200;
            // 
            // PRODUCT
            // 
            PRODUCT.Frozen = true;
            PRODUCT.HeaderText = "PRODUCT";
            PRODUCT.MinimumWidth = 10;
            PRODUCT.Name = "PRODUCT";
            PRODUCT.ReadOnly = true;
            PRODUCT.Width = 400;
            // 
            // QTY
            // 
            QTY.Frozen = true;
            QTY.HeaderText = "QTY";
            QTY.MinimumWidth = 10;
            QTY.Name = "QTY";
            QTY.ReadOnly = true;
            QTY.Width = 125;
            // 
            // UNIT_PRICE
            // 
            UNIT_PRICE.Frozen = true;
            UNIT_PRICE.HeaderText = "UNIT PRICE";
            UNIT_PRICE.MinimumWidth = 10;
            UNIT_PRICE.Name = "UNIT_PRICE";
            UNIT_PRICE.ReadOnly = true;
            UNIT_PRICE.Width = 200;
            // 
            // TOTAL
            // 
            TOTAL.Frozen = true;
            TOTAL.HeaderText = "TOTAL";
            TOTAL.MinimumWidth = 10;
            TOTAL.Name = "TOTAL";
            TOTAL.ReadOnly = true;
            TOTAL.Width = 125;
            // 
            // DATE_TIME
            // 
            DATE_TIME.Frozen = true;
            DATE_TIME.HeaderText = "DATE & TIME";
            DATE_TIME.MinimumWidth = 10;
            DATE_TIME.Name = "DATE_TIME";
            DATE_TIME.ReadOnly = true;
            DATE_TIME.Width = 210;
            // 
            // frmSales
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1432, 763);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "frmSales";
            Text = "frmSales";
            Load += frmSales_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Label label7;
        private Label label6;
        private Label label9;
        private Label label8;
        private ComboBox comboBox1;
        private Button button1;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn SALE_ID;
        private DataGridViewTextBoxColumn PRODUCT;
        private DataGridViewTextBoxColumn QTY;
        private DataGridViewTextBoxColumn UNIT_PRICE;
        private DataGridViewTextBoxColumn TOTAL;
        private DataGridViewTextBoxColumn DATE_TIME;
    }
}