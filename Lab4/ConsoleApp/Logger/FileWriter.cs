namespace ConsoleApp.Logger;

public class FileWriter
{
    private string _path;

    public FileWriter(string path)
    {
        _path = path;
    }
    
    public void Write(string text)
    {
        File.WriteAllText(_path, text);
    }

    public void WriteLine(string text)
    {
        File.AppendAllText(_path, $"{text}\n");
    }
}