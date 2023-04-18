using System;

public class LibraryMode
{
    ConsoleKeyInfo inputKey;

    MainMenuUi mainMenuUi = new MainMenuUi();
    SignUpAndLoginUi signUpAndLoginUi = new SignUpAndLoginUi();
    DataStorage dataStorage = new DataStorage();
    UserInformationException userInformationException = new UserInformationException();
    ProgramProcess programProcess = new ProgramProcess();
    InformationMasking informationMasking = new InformationMasking();

    public void SelectMenu()
    {
        UserLogin login = new UserLogin(mainMenuUi,signUpAndLoginUi, dataStorage, userInformationException, programProcess, informationMasking);
        SignUp signUp = new SignUp(mainMenuUi,signUpAndLoginUi, dataStorage, userInformationException);
        AdministratorLogin administratorLogin = new AdministratorLogin(mainMenuUi, signUpAndLoginUi, dataStorage, userInformationException, programProcess);

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
