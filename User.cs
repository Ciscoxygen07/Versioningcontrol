using System;
using System.Collections.Generic;
public class User
{
   static List<User> user = new();
    public string Firstname {get ; set ;}
    public string LastName { get ; set ;}
    public string Email { get; set;} 
    public DateTime DateOfBirth {get; set; }
    public string PhoneNumber { get; set; }
    public string Address { get; set; }
    public string State { get; set; }
    public string Country { get; set; }
    public string Gender { get; set; }
    public string Password {get; set;}

       public  void GetRegister()
    {
       Console.WriteLine("Enter your firstname ");
        string firstname = Console.ReadLine();
        Console.WriteLine("Enter your lastname ");
        string lastname = Console.ReadLine();
        Console.WriteLine("Enter your Email ");
        string email = Console.ReadLine();
         Console.WriteLine("create password");
        string password = Console.ReadLine();
         Console.WriteLine("Enter your Gender");
        string gender = Console.ReadLine();
         Console.WriteLine("Enter your address");
        string address = Console.ReadLine();
         Console.WriteLine("Enter your date of birth");
        DateTime dateofbirth = DateTime.Parse( Console.ReadLine());
        Console.WriteLine("Enter your phone number");
        string phonenumber = Console.ReadLine(); 
         Console.WriteLine("Enter your state");
        string state = Console.ReadLine();
         Console.WriteLine("Enter your country");
        string country = Console.ReadLine();
       
        User user2= new User();
        user2.Firstname = firstname;
        user2.LastName = lastname;
        user2.Address = address; 
         user2.Email = email;
        user2.Gender = gender;
        user2.State = state;
        user2.Country = country;
        user2.DateOfBirth = dateofbirth; 
        
        user.Add(user2);
       
    }

     public  bool GetLogin()
    {

        Console.WriteLine("Enter your Email ");
        string email = Console.ReadLine();
         Console.WriteLine(" enter your password");
        string password = Console.ReadLine();
        Console.WriteLine(" you have login successfully");
         foreach(var use in user)
         {
         if ( use.Email == email && use.Password == password)
         {
            Console.WriteLine("Login successful");
            return  true;
         }
         }
            return false;
        }
}