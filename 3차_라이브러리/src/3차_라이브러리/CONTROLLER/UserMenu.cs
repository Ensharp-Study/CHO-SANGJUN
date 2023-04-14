using System;

public class UserMenu
{
    Ui ui;
    Data data;
    MagicNumber magicNumber;
    UserInf user;
    ExceptionHandling exceptionHandling;

    public UserMenu(Ui ui, Data data, MagicNumber magicNumber, UserInf user, ExceptionHandling exceptionHandling)
    {
        this.ui = ui;
        this.data = data;
        this.magicNumber = magicNumber;
        this.user = user;
        this.exceptionHandling = exceptionHandling;

    }

    public void ControllUserMenu()
	{
         while (true) { 
        
            int menuNumber;
            ui.ViewMainMenu();
            ui.ViewMenu();
            menuNumber = ui.PrintSelectUserMenu();
            Console.Clear();

            //상속을 활용하기 좀 더 고민해서 유저 관리자가 둘다 코드 재활용할 수 있을지 클래스 분할
            if (menuNumber == magicNumber.BOOKFINDER)   //스위치
            {
                BookFinder bookFinder = new BookFinder(data, ui, magicNumber);
                bookFinder.FindBook();
            }

            else if (menuNumber == magicNumber.BORROWINGBOOK)
            {
                BorrowingBook borrowingBook = new BorrowingBook(data, ui, magicNumber, user);
                borrowingBook.BorrowBook();
            }

            if (menuNumber == magicNumber.BOOKBORROWLIST)
            {
                BookBorrowList bookBorrowList = new BookBorrowList(data, ui, magicNumber, user);
                bookBorrowList.ShowBookBorrowList();
            }

            if (menuNumber == magicNumber.RETURNINGBOOK)
            {
                ReturningBook returningBook = new ReturningBook(data, ui, user);
                returningBook.ReturnBook();
            }

            if (menuNumber == magicNumber.BOOKRETURNLIST)
            {
                BookReturnList bookReturnList = new BookReturnList(data, ui, magicNumber, user);
                bookReturnList.ShowBookReturnList();
            }

            if (menuNumber == magicNumber.EDITUSERINF)
            {
                EditingUserInf editingUserInf = new EditingUserInf(data, ui, user, exceptionHandling);
                editingUserInf.EditUserInf();
            }

            if (menuNumber == magicNumber.DELETEUSERINF)
            {
                DeletingUserInf deletingUserInf = new DeletingUserInf(ui, magicNumber, data, user);
                deletingUserInf.DeleteUserInf();
            }

            if (menuNumber == magicNumber.ESC)
            {
                break;
            }
        }

    }
}
