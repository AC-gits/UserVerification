using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UserData;

namespace UserBusiness
{ 
public class BusinessService 
{
    public bool VerifyingUser(string username, string password)
    {
        UserDataDL dataService = new UserDataDL();
        var result = dataService.GetUser(username,password);
        
        if (result.username == username && result.password == password)
            {
                return true;
            }
        else { return false; }

    }
}
}
