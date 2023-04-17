using System;
using static System.Net.Mime.MediaTypeNames;

public class InformationMasking { 
    
    public string MaskPassword()
    {
        string password = "";
        ConsoleKeyInfo key;

        while ((key = Console.ReadKey(true)).Key != ConsoleKey.Enter)
        { 
            if (key.Key != ConsoleKey.Backspace)
            {
                password += key.KeyChar;
                Console.Write("*");
            }
            else
            {
                password.Substring(password.Length - 1, 1);
                Console.Write("\b \b");
            }
        }
        return password;
    }

}
