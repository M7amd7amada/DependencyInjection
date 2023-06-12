namespace HelloDI;

public class Salutation 
{
    private readonly IMessageWriter _messageWriter;

    public Salutation(IMessageWriter messageWriter)
    {
        if (_messageWriter is null)
        {
            throw new ArgumentNullException();
        }
        _messageWriter = messageWriter;
    }

    public void Exclaim()
    {
        _messageWriter.Write("Hello, DI!");
    }
}