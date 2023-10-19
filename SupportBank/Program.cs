namespace SupportBank;

using NLog;
using NLog.Config;
using NLog.Targets;

internal class Program
{
    static void Main(string[] args)
    {
        var config = new LoggingConfiguration();
        var target = new FileTarget { FileName = @"C:\Users\megan\OneDrive\Documents\Training\Boot Camp\SupportBank\Logs\supportbank.log", Layout = @"${longdate} ${level} - ${logger}: ${message}" };
        config.AddTarget("File Logger", target);
        config.LoggingRules.Add(new LoggingRule("*", LogLevel.Debug, target));
        LogManager.Configuration = config;
        
        var bank = new Bank("C:\\Training\\Boot Camp\\SupportBank\\DodgyTransactions2015.csv");

        bank.ListAll();

        bank.ListAccount("Tim L");
        
    }
}