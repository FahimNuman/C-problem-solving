using CrickbazZ;
using CrickbazZ.DB;
using Microsoft.Identity.Client;
using System.Security.Principal;




for (int id = 1; id < 2; id++)

{
    //==========from input part ==========
    Account account = new Account();
    Console.WriteLine("input Account Owners Name");
    account.Name = Console.ReadLine();
    account.OpeningDate = DateTime.Now;
    CricBuzApplicationDb cricBuzApplicationDb = new CricBuzApplicationDb();
    cricBuzApplicationDb.Accounts.Add(account);
    cricBuzApplicationDb.SaveChanges();

    //==========Show input List part ==========

    CricBuzApplicationDb cricBuzApplicationDb1 = new CricBuzApplicationDb();
    List<Account> accounts = new List<Account> { account };
    accounts = cricBuzApplicationDb.Accounts.ToList();
    foreach (Account account1 in accounts)
    {
        Console.WriteLine($"{account1.Id} =====>  {account1.Name}  =====>  {account1.OpeningDate}");

    }

    Console.WriteLine("Deposite Please:");


    //==========from deposite input part ==========
    Deposite deposite = new Deposite();
    Console.WriteLine("Input AccountId ");
    deposite.AccountId = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input Amount ");
    deposite.Amount = Convert.ToInt32(Console.ReadLine());

    CricBuzApplicationDb db1 = new CricBuzApplicationDb();
    db1.Deposites.Add(deposite);
    db1.SaveChanges();
    CricBuzApplicationDb db = new CricBuzApplicationDb();
    List<Deposite> deposites = new List<Deposite> { deposite };
    deposites = db.Deposites.ToList();
   
        Console.WriteLine($"{deposite.AccountId} =====>  {deposite.Amount}");
        
        Withdraw withdraw = new Withdraw();
        Console.WriteLine("Input AccountId for withdrawn");
        withdraw.AccountId = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Withdraw Amount :");
        withdraw.Amount = Convert.ToInt32(Console.ReadLine());

        CricBuzApplicationDb cricBuzApplicationDb2 = new CricBuzApplicationDb();
        cricBuzApplicationDb2.Withdraws.Add(withdraw);
        cricBuzApplicationDb2.SaveChanges();

        List<Withdraw> withdraws = new List<Withdraw>();
        withdraws = db.Withdraws.ToList();
        foreach (Withdraw withdraw1 in withdraws)
        {
            

        Console.WriteLine("Balance Account:");
            Console.WriteLine(deposite.Amount - withdraw1.Amount);

        
        Console.ReadKey();
        }
        Console.WriteLine(account.Name, account.OpeningDate);



    Console.ReadKey();

}






Console.ReadKey();










