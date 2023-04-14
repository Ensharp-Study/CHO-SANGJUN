using System;

public class LibraryStart
{
    Ui ui = new Ui();
    Data data = new Data();
    MagicNumber magicNumber = new MagicNumber();
    SelectingSignInOrSignUp selectingSignInOrSignUp = new SelectingSignInOrSignUp();
    AdministratorLogin administratorLogin = new AdministratorLogin();

    //AdminLogin adminLogin = new AdminLogin(ui, magicNumber, data);

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
                selectingSignInOrSignUp.SelectSignOrSignUp(ui, magicNumber, data);
            }
            else if (menuNumber == magicNumber.ADMINMODE)//관리자 모드 진입
            {
                administratorLogin.GetAdministratorLogin(ui, magicNumber, data);
            }
        }
    }
	

}
