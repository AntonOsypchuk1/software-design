namespace Task3;

public class SmartTextReader
{
    public virtual char[][] ReadTextFile(string filePath)
    {
        // if (!File.Exists(filePath))
        // {
        //     throw new FileNotFoundException("The specified file does not exist.", filePath);
        // }

        var lines = File.ReadAllLines(filePath);
        var result = new char[lines.Length][];

        for (int i = 0; i < lines.Length; i++)
        {
            result[i] = lines[i].ToCharArray();
        }

        return result;
    }
}