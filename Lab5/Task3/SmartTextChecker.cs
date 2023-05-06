namespace Task3;

public class SmartTextChecker : SmartTextReader
{
    private readonly SmartTextReader _realObject;

    public SmartTextChecker()
    {
        _realObject = new SmartTextReader();
    }

    public override char[][] ReadTextFile(string filePath)
    {
        Console.WriteLine($"Opening file: {filePath}");

        if (!File.Exists(filePath))
        {
            throw new FileNotFoundException("The specified file does not exist.", filePath);
        }
        var result = _realObject.ReadTextFile(filePath);

        Console.WriteLine($"Closing file: {filePath}");
        Console.WriteLine($"Total lines read: {result.Length}");
        Console.WriteLine($"Total characters read: {result.Sum(x => x.Length)}");

        return result;
    }
}