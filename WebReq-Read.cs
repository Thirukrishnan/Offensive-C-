using System;
using System.Net;
using System.IO;

public class Program
    {
    public static void Main(string[] args)
    {

        WebClient client = new WebClient();
        client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
        using Stream data = client.OpenRead("https://google.com");
        using StreamReader reader = new StreamReader(data);
        string s = reader.ReadToEnd();
        Console.WriteLine(s);
    }
        
}
