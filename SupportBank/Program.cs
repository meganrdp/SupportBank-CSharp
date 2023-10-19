namespace SupportBank;

internal class Program
{
    static void Main(string[] args)
    {
        
        var bank = new Bank("C:\\Training\\Boot Camp\\SupportBank\\DodgyTransactions2015.csv");

        bank.ListAll();

        bank.ListAccount("Tim L");
        
    }
}