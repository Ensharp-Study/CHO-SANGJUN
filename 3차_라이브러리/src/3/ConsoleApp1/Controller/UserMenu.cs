using System;

public class UserMenu
{
    Ui ui;
    DataStorage dataStorage;
    UserInf user;
    ExceptionHandling exceptionHandling;

    public UserMenu(Ui ui, DataStorage dataStorage, UserInf user, ExceptionHandling exceptionHandling)
    {
        this.ui = ui;
        this.dataStorage = dataStorage;
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
            if (menuNumber == Constants.BOOK_FINDER)   //스위치
            {
                BookFinder bookFinder = new BookFinder(dataStorage, ui);
                bookFinder.FindBook();
            }

            else if (menuNumber == Constants.BORROWING_BOOK)
            {
                BorrowingBook borrowingBook = new BorrowingBook(dataStorage, ui, user);
                borrowingBook.BorrowBook();
            }

            if (menuNumber == Constants.BOOK_BORROW_LIST)
            {
                BookBorrowList bookBorrowList = new BookBorrowList(dataStorage, ui, user);
                bookBorrowList.ShowBookBorrowList();
            }

            if (menuNumber == Constants.RETURNING_BOOK)
            {
                ReturningBook returningBook = new ReturningBook(dataStorage, ui, user);
                returningBook.ReturnBook();
            }

            if (menuNumber == Constants.BOOK_RETURN_LIST)
            {
                BookReturnList bookReturnList = new BookReturnList(dataStorage, ui, user);
                bookReturnList.ShowBookReturnList();
            }

            if (menuNumber == Constants.EDIT_USER_INF)
            {
                EditingUserInf editingUserInf = new EditingUserInf(dataStorage, ui, user, exceptionHandling);
                editingUserInf.EditUserInf();
            }

            if (menuNumber == Constants.DELETE_USER_INFORMATION)
            {
                DeletingUserInf deletingUserInf = new DeletingUserInf(ui, dataStorage, user);
                deletingUserInf.DeleteUserInf();
            }

            if (menuNumber == Constants.ESC)
            {
                break;
            }
        }

    }
}
