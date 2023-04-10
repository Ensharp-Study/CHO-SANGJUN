using System;

public class LibraryStart
{
    Ui ui = new Ui();
    MagicNumber magicNumber = new MagicNumber();
    SelectingSignInOrSignUp selectingSignInOrSignUp = new SelectingSignInOrSignUp();

    public void SelectMenu()
    {
        int menuNumber;
        ui.ViewMainMenu();
        menuNumber = ui.PrintSelectMenu(magicNumber);

        if(menuNumber == magicNumber.USERMODE) {  //유저모드
            selectingSignInOrSignUp.SelectSignOrSignUp(ui,magicNumber);
        }
        else if(menuNumber == magicNumber.ADMINMODE)
        {
            //관리자 모드
        }
      
    }
	

}
