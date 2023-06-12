namespace HelloDI;

public class Program  
{
    public static void Main(string[] args)
    {
        // Console.WriteLine("Hello, DI!");

        IMessageWriter writer = new ConsoleMessageWriter();
        Salutation salutation = new Salutation(writer);
        salutation.Exclaim();
    }
}