namespace BankApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var myAccount = new Account();
            myAccount.AccountNumber = 123456;
            myAccount.AccountName = "My checking";
        }
    }
}