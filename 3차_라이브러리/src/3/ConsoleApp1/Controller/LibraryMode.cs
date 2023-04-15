using System;

public class LibraryMode
{
    
    Ui ui = new Ui();
    DataStorage dataStorage = new DataStorage();
    ExceptionHandling exceptionHandling = new ExceptionHandling();

    public void SelectMenu()
    {
        UserLogin login = new UserLogin(ui, dataStorage, exceptionHandling);
        SignUp signUp = new SignUp(ui, dataStorage, exceptionHandling);
        AdministratorLogin administratorLogin = new AdministratorLogin(ui, dataStorage);

        while (true)
        {
            int menuNumber;
            ui.ViewMainMenu();
            ui.ViewMenuSquare();
            menuNumber = ui.PrintSelectMenu();

            if (menuNumber == Constants.USER_MODE) //유저 모드 진입
            {
                int judgementLoginOrSignUP;

                Console.Clear();
                ui.ViewMainMenu();
                ui.ViewMenuSquare();
               
                judgementLoginOrSignUP = ui.PrintLoginOrSignUpMenu();

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
            else if (menuNumber == Constants.ADMIN_MODE)
            {
                administratorLogin.GetAdministratorLogin();
            }
        }
    }
	

}
