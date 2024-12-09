
using System.Security.Cryptography.X509Certificates;
using ModelsPOO.Controllers;
using ModelsPOO.Forms;
using ModelsPOO.Interfaces;

namespace trab_poo
{
    public partial class Form_login : Form, Ilogin
    {
        public string User => textBox1.Text;
        public string Password => textBox2.Text;
        public Form_login()
        {
            InitializeComponent();

        }

        public void NavigateToRegister()
        {


        }


        public void NavigateToMainForm(string username, bool admin)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            Hide();

        }

        public void DisplayMessage(string message, string caption, MessageBoxIcon icon)
        {
            MessageBox.Show(message, caption, MessageBoxButtons.OK, icon);

        }


        public void ClearInputs()
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {




        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {

            LoginController controller = new LoginController(this);
            await controller.HandleLoginAsync();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

           
            Register register = new Register();
            register.Show();
            Hide();
        }
    }
}
