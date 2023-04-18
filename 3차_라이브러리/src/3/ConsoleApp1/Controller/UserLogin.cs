using System;
using System.Text.RegularExpressions;

public class UserLogin
{
    MainMenuUi mainMenuUi;
    SignUpAndLoginUi signUpAndLoginUi;
    DataStorage dataStorage;
    UserInformationException userInformationException;
    ProgramProcess programProcess;
    InformationMasking informationMasking;

    public UserLogin(MainMenuUi mainMenuUi, SignUpAndLoginUi signUpAndLoginUi, DataStorage dataStorage, UserInformationException userInformationException, ProgramProcess programProcess, InformationMasking informationMasking)
    {
        this.mainMenuUi = mainMenuUi;
        this.signUpAndLoginUi = signUpAndLoginUi;
        this.dataStorage = dataStorage;
        this.userInformationException = userInformationException;
        this.programProcess = programProcess;
        this.informationMasking = informationMasking;
    }

    public void GetUserLogin()
    {
        string id;
        string password;
        bool isJudgingCorrectInput = true;
        bool isJudgingCorrectString;

        while (isJudgingCorrectInput)
        {
            Console.Clear();
            mainMenuUi.ViewMainMenu();
            mainMenuUi.ViewMenuSquare();
            signUpAndLoginUi.PrintUserLoginMenu();

            Console.SetCursorPosition(53, 23);
            do
            {
                id = ToReceiveInput.ReceiveInput(53, 23);
                isJudgingCorrectString = userInformationException.JudgeIdWithRegularExpression(53, 23, id);
            } while (!isJudgingCorrectString);

            Console.SetCursorPosition(61, 24);
            do
            {
                password = ToReceiveInput.ReceiveInputForMasking(61, 24);
                isJudgingCorrectString = userInformationException.JudgePasswordWithRegularExpression(61, 24, password);
            } while (!isJudgingCorrectString);
            

            bool isJudgingCorrectId = false;

            for (int indexI = 0; indexI < dataStorage.userList.Count; indexI++)
            {
                if (string.Equals(id, dataStorage.userList[indexI].Id))
                {
                    isJudgingCorrectId = true;
                    if (string.Equals(password, dataStorage.userList[indexI].Password))
                    {
                        Console.Clear() ;
                        UserMenu usermenu = new UserMenu(mainMenuUi, dataStorage,  dataStorage.userList[indexI],  userInformationException, programProcess);
                        usermenu.ControllUserMenu();
                        //isJudgingCorrectInput = false;
                    }
                    else
                    {
                        Console.WriteLine("\n\n                                   비밀번호 입력이 틀렸습니다. 다시 입력하세요        ");
                        Console.ReadKey();
                    }
                }
            }

            if(isJudgingCorrectId == false)
            {
                Console.WriteLine("\n\n                             아이디 또는 비밀번호 입력이 틀렸습니다. 다시 입력하세요");
                Console.ReadKey();
            }
        }
    }
}
