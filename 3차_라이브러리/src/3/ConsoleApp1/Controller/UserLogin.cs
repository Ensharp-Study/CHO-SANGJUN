using System;
using System.Text.RegularExpressions;

public class UserLogin
{
    MainMenuUi mainMenuUi;
    SignUpAndLoginUi signUpAndLoginUi;
    DataStorage dataStorage;
    UserInformationException userInformationException;

    public UserLogin(MainMenuUi mainMenuUi, SignUpAndLoginUi signUpAndLoginUi, DataStorage dataStorage, UserInformationException userInformationException)
    {
        this.mainMenuUi = mainMenuUi;
        this.signUpAndLoginUi = signUpAndLoginUi;
        this.dataStorage = dataStorage;
        this.userInformationException = userInformationException;
    }

    public void GetUserLogin()
    {
        string id;
        string password;
        bool isJudgingCorrectInput = true;

        while (isJudgingCorrectInput)
        {
            Console.Clear();
            mainMenuUi.ViewMainMenu();
            mainMenuUi.ViewMenuSquare();
            signUpAndLoginUi.PrintUserLoginMenu();

            Console.SetCursorPosition(53, 23);
            id = userInformationException.JudgeIdAndPasswordWithRegularExpression(53,23);
            
            Console.SetCursorPosition(61, 24);
            password = userInformationException.JudgeIdAndPasswordWithRegularExpression(61, 24);

            for (int indexI = 0; indexI < dataStorage.userList.Count; indexI++)
            {
                if (string.Equals(id, dataStorage.userList[indexI].id))
                {
                    if (string.Equals(password, dataStorage.userList[indexI].password))
                    {
                        Console.Clear() ;
                        UserMenu usermenu = new UserMenu(mainMenuUi, dataStorage,  dataStorage.userList[indexI],  userInformationException);
                        usermenu.ControllUserMenu();
                        isJudgingCorrectInput = false;
                    }
                    else
                    {
                        Console.WriteLine("\n\n                                   비밀번호 입력이 틀렸습니다. 다시 입력하세요        ");
                        Console.ReadKey();
                    }
                }

                else
                {
                    Console.WriteLine("\n\n                             아이디 또는 비밀번호 입력이 틀렸습니다. 다시 입력하세요");
                    Console.ReadKey();
                }


            }
        }
    }
}
