using System;

public class UserMenu
{
    public void ControllUserMenu(Ui ui, Data data,MagicNumber magicNumber, UserInf user)
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
            BorrowingBook borrowingBook = new BorrowingBook();
            borrowingBook.BorrowBook(data, ui, magicNumber, user);
        }

        if (menuNumber == magicNumber.BOOKBORROWLIST)
        {
            BookBorrowList bookBorrowList = new BookBorrowList();
            bookBorrowList.ShowBookBorrowList(data, ui, magicNumber, user);
        }

        if (menuNumber == magicNumber.RETURNINGBOOK)
        {
            ReturningBook returningBook = new ReturningBook();
            returningBook.ReturnBook(data, ui, user);
        }

        if (menuNumber == magicNumber.BOOKRETURNLIST)
        {
            ReturningBook returningBook = new ReturningBook();
            returningBook.ReturnBook(data, ui, user);
        }

        if (menuNumber == magicNumber.EDITUSERINF)
        {
            EditingUserInf editingUserInf = new EditingUserInf();
            editingUserInf.EditUserInf(data, ui, user);
        }

        if (menuNumber == magicNumber.DELETEUSERINF)
        {
            DeletingUserInf deletingUserInf = new DeletingUserInf();
            deletingUserInf.DeleteUserInf(data, user);
        }

    }
}
