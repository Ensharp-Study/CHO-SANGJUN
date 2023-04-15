using System;

public class LibraryStart
{
    
    Ui ui = new Ui();
    DataStorage dataStorage = new DataStorage();
    ExceptionHandling exceptionHandling = new ExceptionHandling();

    public void SelectMenu()
    {
        while (true)
        {
            int menuNumber;
            ui.ViewMainMenu();
            menuNumber = ui.PrintSelectMenu();

            if (menuNumber == Constants.USER_MODE) //유저 모드 진입
            {
                Console.Clear();
                SelectingSignInOrSignUp selectingSignInOrSignUp = new SelectingSignInOrSignUp(ui, dataStorage, exceptionHandling);
                selectingSignInOrSignUp.SelectSignOrSignUp();
            }
            else if (menuNumber == Constants.ADMIN_MODE)//관리자 모드 진입
            {
                AdministratorLogin administratorLogin = new AdministratorLogin(ui, dataStorage);
                administratorLogin.GetAdministratorLogin();
            }
        }
    }
	

}
