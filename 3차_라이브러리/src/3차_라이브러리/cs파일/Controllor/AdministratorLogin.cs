using System;
public class AdministratorLogin
{
    Ui ui;
    MagicNumber magicNumber;
    Data data;

    public AdministratorLogin(Ui ui, MagicNumber magicNumber, Data data)
    {
        this.ui = ui;
        this.magicNumber = magicNumber;
        this.data = data;
    }
    public void GetAdministratorLogin()
    {
        string id;
        string password;
        bool isJudgingCorrectInput = true;
        AdministratorMenu administratorMenu = new AdministratorMenu(ui,data,magicNumber);

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
                administratorMenu.ControllAdministratorMenu();
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

