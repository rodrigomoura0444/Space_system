using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ModelsPOO.models.Auth
{
    public class AuthService
    {
        #region Private Fields
        private readonly string _usersFilePath = Fpm.Instance.UsersFilePath; // Path to the users data file
        #endregion

        #region Public Methods
        /// <summary>
        /// Asynchronously loads the list of users from the data file.
        /// </summary>
        /// <returns>A task that represents the asynchronous operation. The task result contains a list of users.</returns>
        public async Task<List<User>> LoadUsersAsync()
        {
            // Check if the users file exists
            if (!File.Exists(_usersFilePath))
                return new List<User>(); // Return an empty list if no file is found

            // Read the file and deserialize the JSON content into a list of users
            using (StreamReader reader = new StreamReader(_usersFilePath))
            {
                string json = await reader.ReadToEndAsync();
                return JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>(); // Deserialize and return users
            }
        }

        /// <summary>
        /// Validates user credentials by checking the username and password against the list of users.
        /// </summary>
        /// <param name="username">The username to validate.</param>
        /// <param name="password">The password to validate.</param>
        /// <param name="users">The list of users to validate against.</param>
        /// <returns>True if the credentials are valid, otherwise false.</returns>
        public bool ValidateCredentials(string username, string password, List<User> users)
        {
            return users.Any(user => user.Name == username && user.Password == password); // Check if any user matches
        }

        public bool VerifyAdmin(string username, string password, List<User> users)
        {
            if (users.Any(user => user.Name == username && user.Password == password && user.Admin == true))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Asynchronously saves the list of users to the data file.
        /// </summary>
        /// <param name="users">The list of users to save.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        public async Task SaveUsersAsync(List<User> users)
        {
            // Serialize the list of users to JSON
            string json = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });

            // Write the JSON string to the file
            using (StreamWriter writer = new StreamWriter(_usersFilePath))
            {
                await writer.WriteAsync(json);
            }
        }

        /// <summary>
        /// Asynchronously registers a new user by adding their credentials to the users list.
        /// </summary>
        /// <param name="username">The username of the user to register.</param>
        /// <param name="password">The password of the user to register.</param>
        /// <param name="phone"></param>
        /// <param name="isAdmin"></param>
        /// <returns>True if registration is successful, false if the username already exists.</returns>
        public async Task<bool> RegisterUserAsync(string username, string password, string phone, bool isAdmin)
        {
            var users = await LoadUsersAsync(); // Load existing users

            // Check if the username already exists
            if (users.Exists(u => u.Name == username))
            {
                return false; // Username already exists, return false
            }

            // Add the new user to the list and save the list back to the file
            users.Add(new User { Name = username, Password = password, Phone = phone, Admin = isAdmin });
            await SaveUsersAsync(users);
            return true; // Return true to indicate successful registration
        }

        #endregion

    }
}
