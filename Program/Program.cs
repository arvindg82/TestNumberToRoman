using BusinessLogic;
using BusinessObject;
using LoggerService;
public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter integer: ");
        string val = Console.ReadLine();
        WriteLogFile.WriteLog("ConsoleLog", String.Format("{0} @ {1}", "Enter the value: "+ val, DateTime.Now));
        if (int.TryParse(val, out int newvalue))
        {
            Context context = new Context(newvalue);
            var parser = new NumberToRomanParser();
            parser.Interpret(context);
            Console.WriteLine(context.Output);
            WriteLogFile.WriteLog("ConsoleLog", String.Format("{0} @ {1}", "Execution Completed ", DateTime.Now));
        }
        else
        {
            Console.Write("Input value is incorrect");
            return;
        }
        
        Console.ReadKey();
    }

}