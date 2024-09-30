using System;

namespace Banking_App
{
    class Program
    {
        static void Main(string[] args)
        {

           User userManager = new User();
         Transaction transactionManager = new Transaction();
          Account accountManager = new Account();
          bool running = true;

while (running)
{
    Console.Clear();
   Console.WriteLine("Welcome to MY BANKING APP");
   Console.WriteLine("1. SIGN UP");
   Console.WriteLine("2. LOGIN");
    Console.WriteLine("3. Open Acoount");
   Console.WriteLine("4. Transfer");
   Console.WriteLine("5. Exit");

   Console.WriteLine("Choose an option");

   string option = Console.ReadLine();

   switch (option)
   {
    case "1":
       userManager.GetRegister();
       break;
    case "2":
        userManager.GetLogin();
        break;  
        case "3":
       accountManager.GetAccount();
       break;
    case "4":
        accountManager.GetAccount();
        break;  
    case "5":
        running = false;
         break;
    
    default:
        Console.WriteLine("Invalid option, try again");
        break;
   }
        }

     

    }
}
    }

    

