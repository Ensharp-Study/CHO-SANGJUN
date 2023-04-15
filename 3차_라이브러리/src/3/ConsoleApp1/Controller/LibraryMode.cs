using System;

public class LibraryMode
{
    ConsoleKeyInfo inputKey;

    MainMenuUi mainMenuUi = new MainMenuUi();
    SignUpAndLoginUi signUpAndLoginUi = new SignUpAndLoginUi();
    DataStorage dataStorage = new DataStorage();
    ExceptionHandling exceptionHandling = new ExceptionHandling();


    public void SelectMenu()
    {
        UserLogin login = new UserLogin(mainMenuUi,signUpAndLoginUi, dataStorage, exceptionHandling);
        SignUp signUp = new SignUp(mainMenuUi,signUpAndLoginUi, dataStorage, exceptionHandling);
        AdministratorLogin administratorLogin = new AdministratorLogin(mainMenuUi, signUpAndLoginUi, dataStorage);

        while (true)
        {
            int menuNumber;
            mainMenuUi.ViewMainMenu();
            mainMenuUi.ViewMenuSquare();
            menuNumber = mainMenuUi.PrintSelectMenu();

            if (menuNumber == Constants.USER_MODE) //유저 모드 진입
            {
                int judgementLoginOrSignUP;

                Console.Clear();
                mainMenuUi.ViewMainMenu();
                mainMenuUi.ViewMenuSquare();
               
                judgementLoginOrSignUP = signUpAndLoginUi.PrintLoginOrSignUpMenu();

                if (judgementLoginOrSignUP == Constants.LOGIN)
                {
                    login.GetUserLogin();
                    return;
                }
                else if (judgementLoginOrSignUP == Constants.SIGN_UP)
                {
                    Console.Clear();
                    signUp.SignUpAccount();
                    Console.Clear();
                }
            }

            else if (menuNumber == Constants.ADMIN_MODE)//관리자 모드 진입
            {
                administratorLogin.GetAdministratorLogin();
            }
        }
    }
	

}
