
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
        public bool Add( string email, string password)
        {
            var UserModel = new UserModel
            {
             
                Password = password,
                Email = email
            };
            _connection.Insert(UserModel);
            return true;
        }

        public List<UserModel> GetAllUsers()
        {
            return _connection.Table<UserModel>().ToList();
        }
    }
}

