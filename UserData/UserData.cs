using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UserVerifier;


namespace UserData
{
    public class UserDataDL
    {
        List<User> dummyUsers = new List<User>();
        
        public UserDataDL()
        {
            CreateDummyData();
        }
        private void CreateDummyData()
        {

            User user1 = new User()
            {
                username = "Razzi",
                password = "Sabdani",
            };

            User user2 = new User()
            {
                username = "Yonex",
                password = "Astrox88",

            };
            User user3 = new User()
            {
                username = "Java",
                password = "Rice",

            };
            dummyUsers.Add(user1);
            dummyUsers.Add(user2);
            dummyUsers.Add(user3);
        }
        public User GetUser(string username,string password)
        {
            User foundUser = new User();
            foreach (var user in dummyUsers)
            {
                if (user.username == username && password == user.password)
                {
                    foundUser = user;
                }
            }

            return foundUser;
        }

    }
}
