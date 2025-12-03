using SQLite;

namespace CarDealerShip.Final_OOP
{
public class UserModel
    {
         
            [PrimaryKey]
        
        public string Email { get; set; }
        public string Password { get; set; }

    }
}
