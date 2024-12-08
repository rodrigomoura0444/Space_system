using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelsPOO.models;

namespace ModelsPOO.models.Auth
{
    public class User 
    {
        #region Properties
        // Property to store the user's password.
        public string Password { get; set; }

        // Boolean property to indicate whether the user has administrative privileges (true for Admin, false for regular users).
        public bool Admin { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }
        #endregion

        #region Constructor
        /// <summary>  
        /// Constructor  
        /// </summary>  
        /// <param name="name">The username entered by the user.</param>  
        /// <param name="pass">The password entered by the user.</param>  
        /// <param name="admin">Specifies whether the user is an admin (not currently validated in this method).</param>  
        /// <returns>It calls the base constructor from the Person class to initialize shared properties (name,phone,).</returns>  
        // Parameterized constructor to initialize a User object with the given details.
        // It calls the base constructor from the Person class to initialize shared properties (name and phone).
        public User(string name, string phone, string pass, bool admin) 
        {
            Password = pass;       // Assigns the password to the user.
            Admin = admin;       // Sets whether the user is an administrator or not.
           Name= name;
            Phone = phone;
        }

        public User() { }
        #endregion
    }
}
