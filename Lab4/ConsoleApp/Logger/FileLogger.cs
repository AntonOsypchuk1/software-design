namespace ConsoleApp.Logger;

public class FileLogger
{
    private FileWriter _fileWriter;

    public FileLogger(string path)
    {
        _fileWriter = new FileWriter(path);
    }

    public void Log(string message)
    {
        _fileWriter.WriteLine($"[INFO] {message}");
    }

    public void Error(string message)
    {
        _fileWriter.WriteLine($"[ERROR] {message}");
    }

    public void Warn(string message)
    {
        _fileWriter.WriteLine($"[WARN] {message}");
    }
}