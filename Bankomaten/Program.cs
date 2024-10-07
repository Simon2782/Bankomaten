namespace Bankomaten
{
    internal class Program
    {
        class User
        {
            public string Username { get; set; }
            public string PinCode { get; set; }

            public User(string username, string pincode)
            {
                Username = username;
                PinCode = pincode;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till banken!");

            List<User> users = new List<User>
            {
                new User("Robert Gustaffson", "5555"),
                new User("Henrik Dorsin", "1234"),
                new User("Felix Herngren", "4321"),
                new User("Per Andersson", "7744"),
                new User("Johan Glans", "9999"), 

            };

            int logInAttempts = 0;
            bool loggedIn = false;

            while (logInAttempts < 3 && !loggedIn)
            {
                Console.WriteLine("Ange användarnamn: ");
                string inputUsername = Console.ReadLine();

                Console.WriteLine("Ange pinkod: ");
                string inputPinCode = Console.ReadLine();

                foreach (var user in users)
                {
                    if (user.Username == inputUsername && user.PinCode == inputPinCode)
                    {
                        Console.WriteLine($"Inloggad som {user.Username}");
                        loggedIn = true;
                        break;
                    }
                }
                if (!loggedIn)
                {
                    logInAttempts++;
                    Console.WriteLine($"Fel användarnamn eller pinkod. {3 - logInAttempts} försök kvar.");
                }
            }
        }
    }
}
