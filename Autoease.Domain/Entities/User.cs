using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Autoease.Domain.Entities
{
    public class UserEntity
    {
        private readonly List<string> errors = new List<string>();

        [Key]
        public string UserIdCard { get; private set; }
        public string Username { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Role { get; private set; }

        // Construtor privado para evitar criação de instâncias sem parâmetros
        private UserEntity() { }

        public UserEntity(string userIdCard, string username, string email, string password, string firstName, string lastName, string role)
        {
            UserIdCard = userIdCard;
            Username = username;
            Email = email;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
            Role = role;

            Validate();
        }

        public bool IsValid()
        {
            return errors.Count == 0;
        }

        private void Validate()
        {
            if (string.IsNullOrEmpty(UserIdCard) || UserIdCard.Length < 11)
                errors.Add("User Id Card cannot be empty and must have 8 or more characters");

            if (string.IsNullOrEmpty(Username) || Username.Length < 3)
                errors.Add("Username cannot be empty and must have 3 or more characters");

            if (string.IsNullOrEmpty(Email))
            errors.Add("Email cannot be empty.");
            else
            {
                string regexPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9]+\.[a-zA-Z]{2,}$";
                if (!Regex.IsMatch(Email, regexPattern))
                    errors.Add("Invalid email format.");
            }

            if(string.IsNullOrEmpty(Password))
                errors.Add("Password cannot be empty");
            else
            {
                string regexPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{8,}$";
                if(!Regex.IsMatch(Password, regexPattern))
                    errors.Add("Invalid password format");
            }
        }

        public List<string> GetErrors()
        {
            return errors;
        }
    }
}
