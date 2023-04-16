using System;
public class AdministratorLogin
{
    MainMenuUi mainMenuUi;
    SignUpAndLoginUi signUpAndLoginUi;
    DataStorage dataStorage;
    UserInformationException userInformationException;

    public AdministratorLogin(MainMenuUi mainMenuUi,SignUpAndLoginUi signUpAndLoginUi, DataStorage dataStorage, UserInformationException userInformationException)
    {
        this.mainMenuUi = mainMenuUi;
        this.signUpAndLoginUi = signUpAndLoginUi;
        this.dataStorage = dataStorage;
        this.userInformationException = userInformationException;
    }

    public void GetAdministratorLogin()
    {
        string id;
        string password;

        AdministratorMenu administratorMenu = new AdministratorMenu(mainMenuUi, dataStorage);

        while (true)
        {
            signUpAndLoginUi.PrintAdministratorLoginMenu();
            Console.SetCursorPosition(53, 23);
            id = userInformationException.JudgeIdAndPasswordWithRegularExpression(53, 23);
            Console.SetCursorPosition(61, 24);
            password = userInformationException.JudgeIdAndPasswordWithRegularExpression(61, 24);

            if (string.Equals(id, dataStorage.administratorInformation.id))
            {
                if (string.Equals(password, dataStorage.administratorInformation.password))
                {
                    Console.Clear();
                    administratorMenu.ControllAdministratorMenu();
                }
                else
                {
                    Console.WriteLine("\n\n                                   비밀번호 입력이 틀렸습니다. 다시 입력하세요");
                }
            }

            else
            {
                Console.WriteLine("\n\n                             아이디 또는 비밀번호 입력이 틀렸습니다. 다시 입력하세요");
            }

        }
    }

}

