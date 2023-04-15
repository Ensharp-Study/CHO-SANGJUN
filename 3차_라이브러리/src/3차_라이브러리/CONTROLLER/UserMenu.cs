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
            if (menuNumber == MagicNumber.BOOK_FINDER)   //스위치
            {
                BookFinder bookFinder = new BookFinder(data, ui, magicNumber);
                bookFinder.FindBook();
            }

            else if (menuNumber == MagicNumber.BORROWING_BOOK)
            {
                BorrowingBook borrowingBook = new BorrowingBook(data, ui, magicNumber, user);
                borrowingBook.BorrowBook();
            }

            if (menuNumber == MagicNumber.BOOK_BORROW_LIST)
            {
                BookBorrowList bookBorrowList = new BookBorrowList(data, ui, magicNumber, user);
                bookBorrowList.ShowBookBorrowList();
            }

            if (menuNumber == MagicNumber.RETURNING_BOOK)
            {
                ReturningBook returningBook = new ReturningBook(data, ui, user);
                returningBook.ReturnBook();
            }

            if (menuNumber == MagicNumber.BOOK_RETURN_LIST)
            {
                BookReturnList bookReturnList = new BookReturnList(data, ui, magicNumber, user);
                bookReturnList.ShowBookReturnList();
            }

            if (menuNumber == MagicNumber.EDIT_USER_INF)
            {
                EditingUserInf editingUserInf = new EditingUserInf(data, ui, user, exceptionHandling);
                editingUserInf.EditUserInf();
            }

            if (menuNumber == MagicNumber.DELETE_USER_INFORMATION)
            {
                DeletingUserInf deletingUserInf = new DeletingUserInf(ui, magicNumber, data, user);
                deletingUserInf.DeleteUserInf();
            }

            if (menuNumber == MagicNumber.ESC)
            {
                break;
            }
        }

    }
}
