

using Microsoft.VisualBasic.ApplicationServices;
using ModelsPOO.Forms;

namespace trab_poo
{
    public partial class Form_login : Form
    {
        public Form_login()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {




        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            string username = textBox1.Text; 
            string password = textBox2.Text; 

            
            if (username == "admin" && password == "123")
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new Dashboard().Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
    }
}
