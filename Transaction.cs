using System;
using System.Collections.Generic;
public class Transaction
{
       List<Transaction> transaction = new();
    public string Date {get ; set ;}
    public int sendingAccount { get ; set ;}
    public int ReceivingAccount { get; set;} 
    public string TransactionReference {get; set; }
    public string TransactionStatus { get; set; }
    public decimal TransactionAmount { get; set; }
    public string TransactionNarration { get; set; }

    public  void ViewTransactions(string date, string sendingaccount, int receivingaccount , string transactionreference )
{
      Transaction transaction2 = new Transaction();
      transaction2.Date = date;
      transaction2.TransactionReference = transactionreference;
      transaction2.ReceivingAccount = receivingaccount;
}

  public  void ViewAllTransactions(string date, int sendingaccount, int receivingaccount , string transactionreference )
{
      Transaction transaction1 = new Transaction();
      transaction1.Date = date;
      transaction1.TransactionReference = transactionreference;
      transaction1.sendingAccount = sendingaccount;
      transaction1.ReceivingAccount = receivingaccount;
}
}