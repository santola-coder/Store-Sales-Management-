using Authentication_Winform.Models;
using Authentication_Winform.Service;
using Sale_Store_Management.ComponenetForms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Sale_Store_Management
{
    public partial class Loginform : Form
    {
        private readonly AuthApi _authApi;
        public Loginform()
        {

            _authApi = new AuthApi();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbUsername_Click(object sender, EventArgs e)
        {

        }

        private void ClearForm()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
        }



        private async void btnLogin_Click(object sender, EventArgs e)
        {
            var username = textBox1.Text.Trim();
            var password = textBox2.Text.Trim();

            ClearForm();

            try
            {
                LoginResponse? result = await _authApi.LoginAsync(username, password);

                bool isLogged = result != null;

                Form nextForm = isLogged ? new MainForm() : new Loginform();

                if (isLogged)
                {
                    MessageBox.Show("Login Successful");
                    nextForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login Failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
