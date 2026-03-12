namespace Sale_Store_Management
{
    partial class Loginform
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            panel1 = new Panel();
            lbUsername = new Label();
            lbPassword = new Label();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(433, 132);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(279, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(433, 214);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(279, 27);
            textBox2.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSteelBlue;
            panel1.Location = new Point(-4, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(337, 454);
            panel1.TabIndex = 2;
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbUsername.Location = new Point(433, 101);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(99, 28);
            lbUsername.TabIndex = 3;
            lbUsername.Text = "Username";
            lbUsername.Click += lbUsername_Click;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbPassword.Location = new Point(433, 183);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(93, 28);
            lbPassword.TabIndex = 4;
            lbPassword.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.LightSteelBlue;
            btnLogin.Location = new Point(433, 277);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(279, 42);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // Loginform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogin);
            Controls.Add(lbPassword);
            Controls.Add(lbUsername);
            Controls.Add(panel1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            ForeColor = Color.RoyalBlue;
            Name = "Loginform";
            Text = "LoginForm";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Panel panel1;
        private Label lbUsername;
        private Label lbPassword;
        private Button btnLogin;
    }
}
