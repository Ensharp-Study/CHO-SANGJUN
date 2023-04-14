using System;

public class LibraryStart
{
    
    Ui ui = new Ui();
    Data data = new Data();
    MagicNumber magicNumber = new MagicNumber();
    ExceptionHandling exceptionHandling = new ExceptionHandling();

    public void SelectMenu()
    {
        while (true)
        {
            int menuNumber;
            ui.ViewMainMenu();
            menuNumber = ui.PrintSelectMenu(magicNumber);

            if (menuNumber == magicNumber.USERMODE) //유저 모드 진입
            {
                Console.Clear();
                SelectingSignInOrSignUp selectingSignInOrSignUp = new SelectingSignInOrSignUp(ui, magicNumber, data, exceptionHandling);
                selectingSignInOrSignUp.SelectSignOrSignUp();
            }
            else if (menuNumber == magicNumber.ADMINMODE)//관리자 모드 진입
            {
                AdministratorLogin administratorLogin = new AdministratorLogin(ui, magicNumber, data);
                administratorLogin.GetAdministratorLogin();
            }
        }
    }
	

}
