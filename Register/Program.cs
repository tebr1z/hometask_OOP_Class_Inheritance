namespace Register
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Account account = new Account();
            Register register = new Register();

            Console.WriteLine("1 -Log in");
            Console.WriteLine("2 - Register");
            Console.WriteLine("Sechim edin");
            int chookie = Convert.ToInt32(Console.ReadLine());
            
            switch (chookie) { 
            case 1:
                    Console.WriteLine("User Name or E-mail");
                    string Username = Console.ReadLine();

                    Console.WriteLine("Password");
                    String Password = Console.ReadLine();
                    account.Login(Username, Password);
                    break;

                    case 2:
                    Console.WriteLine("isfadechi adi");
                    string newUserName = Console.ReadLine();
                    Console.WriteLine("Password");
                    string newPassword = Console.ReadLine();

                    register.RegisterUser(newUserName, newPassword);
                    break;

                    default: Console.WriteLine("Sef sechim");
                    break;
            }

        }
    }
}
