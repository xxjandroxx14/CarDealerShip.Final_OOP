using System.IO;
using System;
using System.Collections.Generic;
using SQLite;

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

            var UserModel = new UserModel
            {
                Password = password,
                Email = email
            };

            _connection.Insert(UserModel);
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

    }
}