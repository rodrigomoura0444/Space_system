using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelsPOO.Interfaces;
using ModelsPOO.models.Auth;


namespace ModelsPOO.Controllers
{
    internal class RegisterController
    {
        #region Fields and Properties

        private readonly IRegister _view;  // Interface for the Register View
        private readonly AuthService _userService;  // Service responsible for user operations

#endregion

        #region Constructor

        /// <summary>
        /// Constructor to initialize the RegisterController with the specified view.
        /// </summary>
        /// <param name="view">The view that the controller will interact with.</param>
        public RegisterController(IRegister view)
        {
            _view = view;  // Assign the view
            _userService = new AuthService();  // Initialize the UserService
        }

        #endregion

        #region Methods

        /// <summary>
        /// Handles the user registration process asynchronously.
        /// </summary>
        public async Task HandleRegistrationAsync()
        {
            // Check if any required fields are empty
            if (string.IsNullOrWhiteSpace(_view.Username) ||
                string.IsNullOrWhiteSpace(_view.Password) ||
                string.IsNullOrWhiteSpace(_view.ConfirmPassword) || _view.Phone == null)
            {
                _view.DisplayMessage("Username and Password fields cannot be empty.", "Sign Up Failed", MessageBoxIcon.Error);
                return;
            }

            // Check if passwords match
            if (_view.Password != _view.ConfirmPassword)
            {
                _view.DisplayMessage("Passwords do not match. Please re-enter.", "Sign Up Failed", MessageBoxIcon.Error);
                _view.ClearInputs();  // Clear the inputs to prompt user for new data
                return;
            }

            try
            {
                // Attempt to register the user
                bool registrationSuccess = await _userService.RegisterUserAsync(_view.Username, _view.Password, _view.Phone, _view.IsAdmin);

                if (registrationSuccess)
                {
                    _view.ClearInputs();  // Clear inputs after successful registration
                    _view.DisplayMessage("Your account has been successfully created.", "Registration Success", MessageBoxIcon.Information);
                }
                else
                {
                    // If username already exists, show error
                    _view.DisplayMessage("Username already exists.", "Sign Up Failed", MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Display any errors that occur during the registration process
                _view.DisplayMessage($"An error occurred: {ex.Message}", "Error", MessageBoxIcon.Error);
            }
        }

        #endregion

    }
}
