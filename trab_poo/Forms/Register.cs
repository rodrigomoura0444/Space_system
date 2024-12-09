using System.Windows.Forms;
using ModelsPOO.Controllers;
using ModelsPOO.Interfaces;
using trab_poo;




namespace ModelsPOO.Forms
{
    public partial class Register : Form, IRegister
    {
        #region Constructor
        /// <summary>
        /// Initializes the registration form.
        /// </summary>
        public Register()
        {
            InitializeComponent();
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets the entered username from the input field.
        /// </summary>
        public string Username => textBox1.Text;

        /// <summary>
        /// Gets the entered password from the input field.
        /// </summary>
        public string Password => textBox2.Text;



        /// <summary>
        /// Gets the entered confirmation password from the input field.
        /// </summary>
        public string ConfirmPassword => textBox3.Text;

        public string Phone => textBox5.Text;

        public bool IsAdmin => checkBox1.Checked;

        #endregion


        #region Public Methods (IRegister Implementation)
        /// <summary>
        /// Displays a message box with the specified message, caption, and icon.
        /// </summary>
        public void DisplayMessage(string message, string caption, MessageBoxIcon icon)
        {
            MessageBox.Show(message, caption, MessageBoxButtons.OK, icon);
        }

        /// <summary>
        /// Clears the username, password, and confirm password input fields and sets focus to the username field.
        /// </summary>
        public void ClearInputs()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox5.Text = string.Empty;
            checkBox1.Focus();
        }

        /// <summary>
        /// Navigates to the login form.
        /// </summary>
        public void NavigateToLogin()
        {
            new Form_login().Show();
            this.Hide();
        }
        #endregion

        private async void bt_signup_Click(object sender, EventArgs e)
        {
            RegisterController controller = new RegisterController(this);
            await controller.HandleRegistrationAsync();

        }

        private void lb_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NavigateToLogin();
        }
        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            RegisterController controller = new RegisterController(this);
            await controller.HandleRegistrationAsync();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form_login form_Login = new Form_login();
            form_Login.Show();
            Hide();
        }
    }
    }

