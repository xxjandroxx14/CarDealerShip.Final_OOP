using System.IO;
using System;
using System.Collections.Generic;
using SQLite;
using System.Linq; // Added for FirstOrDefault

namespace CarDealerShip.Final_OOP
{
    public class UserRepository
    {
        private readonly SQLiteConnection _connection;

        public UserRepository()
        {
            string dataBasePath = Path.Combine(Environment.GetFolderPath
                (Environment.SpecialFolder.MyDocuments), "UserData.db");

            _connection = new SQLiteConnection(dataBasePath);
            _connection.CreateTable<UserModel>();
        }

        public bool Add(string email, string password)
        {
            var existingUser = _connection.Table<UserModel>().FirstOrDefault(u => u.Email == email);
            if (existingUser != null)
            {
                return false;
            }

            var newUserModel = new UserModel
            {
                Password = password,
                Email = email
            };

            _connection.Insert(newUserModel);
            return true;
        }

        public bool Authenticate(string email, string password)
        {
            var user = _connection.Table<UserModel>()
                                     .FirstOrDefault(u => u.Email == email && u.Password == password);

            return user != null;
        }

        public List<UserModel> GetAllUsers()
        {
            return _connection.Table<UserModel>().ToList();
        }

       
        public bool Update(string oldEmail, string newEmail, string newPassword)
        {
            var userToUpdate = _connection.Table<UserModel>().FirstOrDefault(u => u.Email == oldEmail);

            if (userToUpdate == null) return false;

            try
            {
              
                if (oldEmail.Equals(newEmail, StringComparison.OrdinalIgnoreCase))
                {
                   
                    userToUpdate.Password = newPassword;
                    int rowsAffected = _connection.Update(userToUpdate);
                    return rowsAffected > 0;
                }
                else
                {
                  
                    _connection.Delete(userToUpdate);

                
                    var newUserModel = new UserModel
                    {
                        Email = newEmail,
                        Password = newPassword
                    };

                    int rowsAffected = _connection.Insert(newUserModel);
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
  
                Console.WriteLine($"Error updating user: {ex.Message}");
                return false;
            }
        }

     
        public bool Delete(string email)
        {
            var userToDelete = _connection.Table<UserModel>().FirstOrDefault(u => u.Email == email);

            if (userToDelete == null) return false;

            try
            {
                int rowsAffected = _connection.Delete(userToDelete);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting user: {ex.Message}");
                return false;
            }
        }
    }
}