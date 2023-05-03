using ConsoleApp1.DataBase;
using System;

public class LibraryMode
{
    InputByReadKey InputByReadKey;
    RegularExpression regularExpression;
    MainMenuUi mainMenuUi;
    SignUpAndLoginUi signUpAndLoginUi;
    DataStorage dataStorage;
    ProgramProcess programProcess;
    UserLogin login;
    SignUp signUp;
    AdministratorLogin administratorLogin;

    public LibraryMode()
    {
        this.InputByReadKey = InputByReadKey.GetInstance();
        this.regularExpression = RegularExpression.GetInstance();
        this.mainMenuUi = MainMenuUi.GetInstance();
        this.signUpAndLoginUi = SignUpAndLoginUi.GetInstance();
        this.dataStorage = new DataStorage();
        this.programProcess = new ProgramProcess();
        this.login = new UserLogin(programProcess);
        this.signUp = new SignUp();
        this.administratorLogin = new AdministratorLogin( programProcess);
    }

    public void SelectMenu()
    {
        while (true)
        {
            int menuNumber;
            mainMenuUi.ViewMainMenu();
            mainMenuUi.ViewMenuSquare();
            menuNumber = mainMenuUi.PrintSelectMenu();

            if (menuNumber == (int)(ModeNumber.USER_MODE)) //유저 모드 진입
            {
                int judgementLoginOrSignUP;

                Console.Clear();
                mainMenuUi.ViewMainMenu();
                mainMenuUi.ViewMenuSquare();
               
                judgementLoginOrSignUP = signUpAndLoginUi.PrintLoginOrSignUpMenu();

                if (judgementLoginOrSignUP == (int)(LoginOrSignUpNumber.LOGIN))
                {
                    login.GetUserLogin();
                    return;
                }
                else if (judgementLoginOrSignUP == (int)(LoginOrSignUpNumber.SIGN_UP))
                {
                    Console.Clear();
                    signUp.SignUpAccount();
                }
            }

            else if (menuNumber == (int)(ModeNumber.ADMIN_MODE))//관리자 모드 진입
            {
                Console.Clear();
                mainMenuUi.ViewMainMenu();
                mainMenuUi.ViewMenuSquare();
                administratorLogin.GetAdministratorLogin();
            }

            //프로그램 종료하기
            if ((programProcess.SelectProgramDirection()).Key == ConsoleKey.Escape)
            {
                break;
            }
        }
    }
	

}
