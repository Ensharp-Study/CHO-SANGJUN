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

            if (menuNumber == MagicNumber.USER_MODE) //유저 모드 진입
            {
                Console.Clear();
                SelectingSignInOrSignUp selectingSignInOrSignUp = new SelectingSignInOrSignUp(ui, magicNumber, data, exceptionHandling);
                selectingSignInOrSignUp.SelectSignOrSignUp();
            }
            else if (menuNumber == MagicNumber.ADMIN_MODE)//관리자 모드 진입
            {
                AdministratorLogin administratorLogin = new AdministratorLogin(ui, magicNumber, data);
                administratorLogin.GetAdministratorLogin();
            }
        }
    }
	

}
