using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string shortcutPath = System.IO.Path.Combine(desktopPath, "kısayol"); // Kısayolun tam dosya yolu

        try
        {
            // Kısayolu çalıştır
            Process.Start(shortcutPath);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Hata: " + ex.Message);

        }
    }
}
