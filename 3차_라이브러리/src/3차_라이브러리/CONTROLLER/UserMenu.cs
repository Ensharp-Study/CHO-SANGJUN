using System;

public class UserMenu
{
    public void ControllUserMenu(Ui ui, Data data,MagicNumber magicNumber)
	{
		int menuNumber;
		ui.ViewUserMenu();
		menuNumber = ui.PrintSelectUserMenu(magicNumber);
        Console.Clear();
        if (menuNumber == magicNumber.BOOKFINDER) 
        {  
            BookFinder bookFinder = new BookFinder();
            bookFinder.FindBook(data, ui, magicNumber);
		}

        else if (menuNumber == magicNumber.BORROWINGBOOK)
        {

        }

        if (menuNumber == magicNumber.BOOKBORROWLIST)
        {

        }

        if (menuNumber == magicNumber.RETURNINGBOOK)
        {

        }

        if (menuNumber == magicNumber.BOOKRETURNLIST)
        {

        }

        if (menuNumber == magicNumber.EDITUSERINF)
        {

        }

        if (menuNumber == magicNumber.DELETEUSERINF)
        {

        }

    }
}
