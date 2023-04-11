using System;

public class LibraryStart
{
    Ui ui = new Ui();
    MagicNumber magicNumber = new MagicNumber();
    SelectingSignInOrSignUp selectingSignInOrSignUp = new SelectingSignInOrSignUp();
    //AdminLogin adminLogin = new AdminLogin(ui, magicNumber, data);

    public void SelectMenu()
    {
        int menuNumber;
        ui.ViewMainMenu();
        menuNumber = ui.PrintSelectMenu(magicNumber);

        if(menuNumber == magicNumber.USERMODE) //유저 모드 진입
        {  
            selectingSignInOrSignUp.SelectSignOrSignUp(ui,magicNumber);
        }
        else if(menuNumber == magicNumber.ADMINMODE)//관리자 모드 진입
        {
            
        }
      
    }
	

}
