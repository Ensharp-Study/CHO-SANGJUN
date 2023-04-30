using System;

public class LibraryMode
{ 
    MainMenuUi mainMenuUi;
    SignUpAndLoginUi signUpAndLoginUi;
    DataStorage dataStorage;
    UserInformationException userInformationException;
    BookInformationException bookInformationException;
    ProgramProcess programProcess;
    UserLogin login;
    SignUp signUp;
    AdministratorLogin administratorLogin;

    public LibraryMode()
    {
        this.mainMenuUi = MainMenuUi.GetInstance();
        this.signUpAndLoginUi = SignUpAndLoginUi.GetInstance();
        this.dataStorage = new DataStorage();
        this.userInformationException = new UserInformationException();
        this.bookInformationException = new BookInformationException();
        this.programProcess = new ProgramProcess();
        this.login = new UserLogin(dataStorage, userInformationException, bookInformationException, programProcess);
        this.signUp = new SignUp(dataStorage, userInformationException);
        this.administratorLogin = new AdministratorLogin(dataStorage, userInformationException, bookInformationException, programProcess);
    }

    public void SelectMenu()
    {
        ConsoleKeyInfo inputKey;

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
                    Console.Clear();
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
