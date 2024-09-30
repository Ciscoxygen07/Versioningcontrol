using System;
using System.Collections.Generic;
public class Account : Transaction
{
     List<Account> account = new();
    public int AccountNumber {get ; set ;}
    public string BVN  { get ; set ;}
    public string NIN { get; set;} 
    public int Balance {get; set; }
    public DateTime  DateOpened { get; set; }
    public string AccountType { get; set; }
    public string AccountStaus { get; set; }
    public int CardNumber { get; set; }
    public int Pin { get; set; }
    public string AccountHolder{get; set;}


// public Account(string accountnumber , int bvn , string nin  )
// {
     
// }
     public  void GetAccount()
    {
       Console.WriteLine("Enter your firstname ");
        string accountType = Console.ReadLine();
        Console.WriteLine("Enter your accountnumber ");
        string acctNumber = Console.ReadLine();
        Console.WriteLine("Enter your Email ");
        string bvn = Console.ReadLine();
         Console.WriteLine("Enter your address");
        string AccountType = Console.ReadLine();
         Console.WriteLine("Enter your date of birth");
        DateTime dateOpened = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Enter your phone number");
        int phonenumber = int.Parse(Console.ReadLine());  
         Console.WriteLine("Enter your NIN ");
        string nin = Console.ReadLine(); 
    }

    // public  void GetViewAccount(User user)
    // {
    //    foreach (var item in account)
    //    {
        
    //    }  
    // }
    
    public  void DoTransfer ()
    {
         Console.WriteLine("Enter receiving account");
         int receivingaccount1 = int.Parse(Console.ReadLine()); 
         Console.WriteLine("Enter amount to be transferred ");
        int transactionamount = int.Parse(Console.ReadLine()); 
        Console.WriteLine("Enter your narration/description ");
        string transactionreference = Console.ReadLine();
         Console.WriteLine("create password");
        int pin = int.Parse(Console.ReadLine()); 
         string status = Console.ReadLine();

        Account account1 = new Account();
        {
            account1.ReceivingAccount = receivingaccount1;
            account1.TransactionAmount= transactionamount;
            account1.TransactionNarration = transactionreference;
            account1.Pin = pin;
            account1.TransactionStatus = status;
        }
    }

}