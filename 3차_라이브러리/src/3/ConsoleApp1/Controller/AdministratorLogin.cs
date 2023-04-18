using System;
public class AdministratorLogin
{
    MainMenuUi mainMenuUi;
    SignUpAndLoginUi signUpAndLoginUi;
    DataStorage dataStorage;
    UserInformationException userInformationException;
    ProgramProcess programProcess;

    public AdministratorLogin(MainMenuUi mainMenuUi,SignUpAndLoginUi signUpAndLoginUi, DataStorage dataStorage, UserInformationException userInformationException, ProgramProcess programProcess)
    {
        this.mainMenuUi = mainMenuUi;
        this.signUpAndLoginUi = signUpAndLoginUi;
        this.dataStorage = dataStorage;
        this.userInformationException = userInformationException;
        this.programProcess = programProcess;
    }

    public void GetAdministratorLogin()
    {
        string id;
        string password;

        AdministratorMenu administratorMenu = new AdministratorMenu(mainMenuUi, dataStorage, programProcess);

        /*while (true)
        {
            signUpAndLoginUi.PrintAdministratorLoginMenu();
            Console.SetCursorPosition(53, 23);
            id = userInformationException.JudgeIdWithRegularExpression(53, 23);
            Console.SetCursorPosition(61, 24);
            password = userInformationException.JudgePasswordWithRegularExpression(61, 24);

            if (string.Equals(id, dataStorage.administratorInformation.Id))
            {
                if (string.Equals(password, dataStorage.administratorInformation.Password))
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

            if ((programProcess.SelectProgramDirection()).Key == ConsoleKey.Escape)
            {
                break;
            }

        }*/
    }

}

