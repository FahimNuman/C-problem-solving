using CrickbazZ;
using CrickbazZ.DB;
using Microsoft.Identity.Client;
using System.Security.Principal;



CricBuzApplicationDb cricBuzApplicationDb = new CricBuzApplicationDb();

for (int id = 0; id < 10; id++)
{

    Account account = new Account();
    Console.WriteLine("input Account Owners Name");
    account.Id = id;
    account.Name = Console.ReadLine();
    account.OpeningDate = DateTime.Now;
    Console.WriteLine("input Account Owners Balance");
    account.Balance = Convert.ToInt32(Console.ReadLine());

    cricBuzApplicationDb.Accounts.Add(account);
    cricBuzApplicationDb.SaveChanges();
}




for (int id = 0; id < 10; id++)
{
    Deposite deposite = new Deposite();
    Console.WriteLine("input Account Owners AccountId");
    deposite.AccountId = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("input Account Owners DepositeAmount");
    deposite.Amount = Convert.ToInt32(Console.ReadLine());


    Account account = cricBuzApplicationDb.Accounts.Find(deposite.AccountId);
    account.Balance += deposite.Amount;
    cricBuzApplicationDb.SaveChanges();

}


for (int i = 0; i < 5; i++)
{
    Console.WriteLine("For Withdraw===Enter Account ID:");
    int accountId = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("For Withdraw===Enter Withdrawal Amount:");
    int amount = Convert.ToInt32(Console.ReadLine());

    Withdraw withdraw = new Withdraw();
    withdraw.AccountId = accountId;
    withdraw.Amount = amount;
    Account account = cricBuzApplicationDb.Accounts.Find(accountId);
    account.Balance -= amount;

    cricBuzApplicationDb.Withdraws.Add(withdraw);
    cricBuzApplicationDb.SaveChanges();

    Console.WriteLine("Account Name: " + account.Name);
    Console.WriteLine("Opening Date: " + account.OpeningDate);
    Console.WriteLine("Current Balance: " + account.Balance);
}






Console.ReadKey();











