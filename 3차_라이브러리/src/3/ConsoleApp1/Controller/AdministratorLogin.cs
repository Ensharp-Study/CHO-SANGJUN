using System;
public class AdministratorLogin
{
    MainMenuUi mainMenuUi;
    SignUpAndLoginUi signUpAndLoginUi;
    DataStorage dataStorage;

    public AdministratorLogin(MainMenuUi mainMenuUi,SignUpAndLoginUi signUpAndLoginUi, DataStorage dataStorage)
    {
        this.mainMenuUi = mainMenuUi;
        this.signUpAndLoginUi = signUpAndLoginUi;
        this.dataStorage = dataStorage;
    }

    public void GetAdministratorLogin()
    {
        string id;
        string password;
        bool isJudgingCorrectInput = true;
        AdministratorMenu administratorMenu = new AdministratorMenu(mainMenuUi,dataStorage);

        signUpAndLoginUi.PrintLoginMenu();
        Console.SetCursorPosition(53, 23);
        id = Console.ReadLine();
        Console.SetCursorPosition(61, 24);
        password = Console.ReadLine();

        if (string.Equals(id, dataStorage.administratorInf.id))
        {
            if (string.Equals(password, dataStorage.administratorInf.password))
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

