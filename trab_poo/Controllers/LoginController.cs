using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;
using System.Windows.Forms;
using ModelsPOO.Interfaces;
using ModelsPOO.models.Facade;
using ModelsPOO.models.Auth;
using User = ModelsPOO.models.Auth.User;

namespace ModelsPOO.Controllers
{
    /// <summary>
    /// Controller responsible for handling the login logic.
    /// </summary>
    public class LoginController
    {
        #region Fields and Properties

        private readonly Ilogin _view;              // Interface for the Login View
        private readonly Login_Facade _loginFacade;  // Facade for handling login operations

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor to initialize the LoginController with the specified view.
        /// </summary>
        /// <param name="view">The view that the controller will interact with.</param>
        public LoginController(Ilogin view)
        {
            _view = view;                          // Assign the view
            _loginFacade = new Login_Facade();      // Initialize the LoginFacade
        }

        #endregion

        #region Methods

        /// <summary>
        /// Handles the login process asynchronously.
        /// </summary>
        public async Task HandleLoginAsync()
        {
            // Load the list of users from the LoginFacade
            List<User> users = await _loginFacade.LoadUsersAsync();

            // Check if there are no users in the system
            if (users.Count == 0)
            {
                _view.DisplayMessage("No user data file found. Please register first.", "Login Failed", MessageBoxIcon.Error);
                return;
            }

            // Validate the credentials entered by the user
            bool loginSuccess = _loginFacade.ValidateCredentials(_view.User, _view.Password, users);

            if (loginSuccess)
            {
                // Check if the user has admin privileges
                bool isAdmin = _loginFacade.VerifyAdmin(_view.User, _view.Password, users);

                // Navigate to the main form
                _view.NavigateToMainForm(_view.User, isAdmin);
            }
            else
            {
                // If login failed, show an error message and clear inputs
                _view.DisplayMessage("Invalid Credentials, please try again.", "Login Failed", MessageBoxIcon.Error);
                _view.ClearInputs();
            }
        }

        #endregion
    }
}
