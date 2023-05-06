using System.Text.RegularExpressions;

namespace Task3;

public class SmartTextReaderLocker : SmartTextReader
{
    private readonly SmartTextReader _realObject;
    private readonly Regex _filePattern;

    public SmartTextReaderLocker(string filePattern)
    {
        _realObject = new SmartTextReader();
        _filePattern = new Regex(filePattern);
    }

    public override char[][] ReadTextFile(string filePath)
    {
        if (!_filePattern.IsMatch(filePath))
        {
            Console.WriteLine($"Access denied: {filePath}");
            return new char[][] { };
        }
        
        return _realObject.ReadTextFile(filePath);
    }
}