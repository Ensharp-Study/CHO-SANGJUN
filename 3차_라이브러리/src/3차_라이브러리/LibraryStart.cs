﻿using System;

public class LibraryStart
{
    Ui ui = new Ui();
    MagicNumber magicNumber = new MagicNumber();

    public void SelectMenu()
    {
        int menuNumber;
        ui.MainMenuView();
        menuNumber = ui.PrintSelectMenu(magicNumber);

        if(menuNumber == magicNumber.USERMODE) { 
            Login login = new Login();
            login.GetLogin(ui);
        }
        else if(menuNumber == magicNumber.ADMINMODE)
        {

        }
      
    }
	

}
