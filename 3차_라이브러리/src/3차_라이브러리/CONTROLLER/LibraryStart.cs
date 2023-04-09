using System;

public class LibraryStart
{
    Ui ui = new Ui();
    MagicNumber magicNumber = new MagicNumber();

    public void SelectMenu()
    {
        int menuNumber;
        ui.ViewMainMenu();
        menuNumber = ui.PrintSelectMenu(magicNumber);

        if(menuNumber == magicNumber.USERMODE) {  //유저모드
            Login login = new Login();
            login.GetLogin(ui,magicNumber);
        }
        else if(menuNumber == magicNumber.ADMINMODE)
        {
            //관리자 모드
        }
      
    }
	

}
