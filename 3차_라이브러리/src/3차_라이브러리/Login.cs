using System;

public class Login
{
    public void GetLogin(Ui ui)
    {
        string id;
        string password;

        ui.PrintLoginMenu();
        Console.SetCursorPosition(53, 23);
        id = Console.ReadLine();
        Console.SetCursorPosition(61, 24);
        password = Console.ReadLine();
    }
}
