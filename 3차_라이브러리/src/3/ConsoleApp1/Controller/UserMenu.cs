using System;

public class UserMenu
{
    MainMenuUi mainMenuUi;
    DataStorage dataStorage;
    UserInf user;
    ExceptionHandling exceptionHandling;

    public UserMenu(MainMenuUi mainMenuUi, DataStorage dataStorage, UserInf user, ExceptionHandling exceptionHandling)
    {
        this.mainMenuUi = mainMenuUi;
        this.dataStorage = dataStorage;
        this.user = user;
        this.exceptionHandling = exceptionHandling;
    }

    UserModeUi userModeUi = new UserModeUi();
    CommonFunctionUi commonFunctionUi = new CommonFunctionUi();

    public void ControllUserMenu()
	{
         while (true) { 
        
            int menuNumber;
            mainMenuUi.ViewMainMenu();
            commonFunctionUi.ViewMenu();
            menuNumber = userModeUi.PrintSelectUserMenu();
            Console.Clear();

            //상속을 활용하기 좀 더 고민해서 유저 관리자가 둘다 코드 재활용할 수 있을지 클래스 분할
            if (menuNumber == Constants.BOOK_FINDER)   //스위치
            {
                BookFinder bookFinder = new BookFinder(dataStorage, commonFunctionUi);
                bookFinder.FindBook();
            }

            else if (menuNumber == Constants.BORROWING_BOOK)
            {
                BorrowingBook borrowingBook = new BorrowingBook(dataStorage, userModeUi, commonFunctionUi, user);
                borrowingBook.BorrowBook();
            }

            else if (menuNumber == Constants.BOOK_BORROW_LIST)
            {
                BookBorrowList bookBorrowList = new BookBorrowList(dataStorage, userModeUi, user);
                bookBorrowList.ShowBookBorrowList();
            }

            else if (menuNumber == Constants.RETURNING_BOOK)
            {
                ReturningBook returningBook = new ReturningBook(dataStorage, userModeUi, user);
                returningBook.ReturnBook();
            }

            else if (menuNumber == Constants.BOOK_RETURN_LIST)
            {
                BookReturnList bookReturnList = new BookReturnList(dataStorage, userModeUi, user);
                bookReturnList.ShowBookReturnList();
            }

            else if (menuNumber == Constants.EDIT_USER_INF)
            {
                EditingUserInf editingUserInf = new EditingUserInf(dataStorage, userModeUi, user, exceptionHandling);
                editingUserInf.EditUserInf();
            }

            else if (menuNumber == Constants.DELETE_USER_INFORMATION)
            {
                DeletingUserInf deletingUserInf = new DeletingUserInf(userModeUi, dataStorage, user);
                deletingUserInf.DeleteUserInf();
            }

            else if (menuNumber == Constants.ESC)
            {
                break;
            }

         }

    }
}
