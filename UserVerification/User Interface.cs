
using UserBusiness;


namespace UserVerification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter username: ");
            string username = Console.ReadLine();

            Console.WriteLine("Enter password: ");
            string password = Console.ReadLine();
            BusinessService userService = new BusinessService();
            bool result = userService.VerifyingUser(username, password);

            if (result)
            {
                Console.WriteLine("Login Successful");
            }
            else
            {
                Console.WriteLine("Unsucessful");
            }

        }
    }
}
