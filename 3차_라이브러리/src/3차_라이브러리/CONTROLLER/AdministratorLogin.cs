using System;
public class AdministratorLogin
{
    public void GetAdministratorLogin(Ui ui, MagicNumber magicNumber, Data data)
    {
        string id;
        string password;
        bool isJudgingCorrectInput = true;
        AdministratorMenu administratorMenu = new AdministratorMenu();

        ui.PrintLoginMenu();
        Console.SetCursorPosition(53, 23);
        id = Console.ReadLine();
        Console.SetCursorPosition(61, 24);
        password = Console.ReadLine();

        if (string.Equals(id, data.administratorInf.id))
        {
            if (string.Equals(password, data.administratorInf.password))
            {
                Console.Clear();
                administratorMenu.ControllAdministratorMenu(ui, data, magicNumber);
                isJudgingCorrectInput = false;
            }
            else
            {
                Console.WriteLine("\n\n                                   비밀번호 입력이 틀렸습니다. 다시 입력하세요        ");
            }
        }

        else
        {
            Console.WriteLine("\n\n                             아이디 또는 비밀번호 입력이 틀렸습니다. 다시 입력하세요");
        }

    }


}

