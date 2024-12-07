using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelsPOO.models.Auth;

namespace ModelsPOO.models.Facade
{
    public class Register_Facade
    {
        #region Private Fields
        private readonly AuthService _authService; // Service for user-related operations
        #endregion

        #region Constructor
        /// <summary>
        /// Initializes the RegisterFacade with necessary services.
        /// </summary>
        public Register_Facade()
        {
            _authService = new AuthService(); // Initialize the UserService dependency
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Registers a new user asynchronously.
        /// </summary>
        /// <param name="username">The username of the user to be registered.</param>
        /// <param name="password">The password of the user to be registered.</param>
        /// <returns>A task that represents the asynchronous operation. The task result is true if registration is successful, false otherwise.</returns>
        public async Task<bool> RegisterUserAsync(string username, string password)
        {
            return await _authService.RegisterUserAsync(username, password, "1", true); // Call the service method to register the user
        }
        #endregion

    }
}
