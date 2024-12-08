using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ModelsPOO.models.Auth;

namespace ModelsPOO.models.Facade
{
    public class Login_Facade
    {
        private readonly AuthService _authService;

        /// <summary>
        /// Initializes a new instance of the LoginFacade.
        /// </summary>
        public Login_Facade()
        {
            _authService = new AuthService();
        }

        /// <summary>
        /// Loads the list of users asynchronously.
        /// </summary>
        public async Task<List<User>> LoadUsersAsync()
        {
            return await _authService.LoadUsersAsync();
        }

        /// <summary>
        /// Validates the credentials of a user.
        /// </summary>
        /// <param name="username">The username to validate.</param>
        /// <param name="password">The password to validate.</param>
        /// <param name="users">The list of users to validate against.</param>
        /// <returns>True if credentials are valid; otherwise, false.</returns>
        public bool ValidateCredentials(string username, string password, List<User> users)
        {
            return _authService.ValidateCredentials(username, password, users);
        }

        /// <summary>
        /// Checks if the provided user has admin privileges.
        /// </summary>
        /// <param name="username">The username to check.</param>
        /// <param name="password">The password to check.</param>
        /// <param name="users">The list of users to check against.</param>
        /// <returns>True if the user is an admin; otherwise, false.</returns>
        public bool VerifyAdmin(string username, string password, List<User> users)
        {
            return _authService.VerifyAdmin(username, password, users);
        }


    }
}
