using System;

public class UserMenu //유저 메뉴 진입 기능 클래스
{
    MainMenuUi mainMenuUi;
    DataStorage dataStorage;
    UserInformation user;
    UserInformationException userInformationException;
    BookInformationException bookInformationException;
    ProgramProcess programProcess;

    public UserMenu(MainMenuUi mainMenuUi, DataStorage dataStorage, UserInformation user, UserInformationException userInformationException, BookInformationException bookInformationException, ProgramProcess programProcess)
    {
        this.mainMenuUi = mainMenuUi;
        this.dataStorage = dataStorage;
        this.user = user;
        this.userInformationException = userInformationException;
        this.bookInformationException = bookInformationException;
        this.programProcess = programProcess;
    }

    UserModeUi userModeUi = new UserModeUi();
    CommonFunctionUi commonFunctionUi = new CommonFunctionUi();

    public void ControllUserMenu() //유저 메뉴 선택 함수
    {
        while (true)
        {
            int menuNumber;
            mainMenuUi.ViewMainMenu();
            commonFunctionUi.ViewMenu();
            menuNumber = userModeUi.PrintSelectUserMenu(); //선택한 유저 메뉴 저장
            Console.Clear();

            if (menuNumber == (int)(UserMenuNumber.BOOK_FINDER))
            {
                BookFinder bookFinder = new BookFinder(dataStorage, commonFunctionUi, programProcess, bookInformationException); 
                bookFinder.FindBook();
            }

            else if (menuNumber == (int)(UserMenuNumber.BORROWING_BOOK))
            {
                BorrowingBook borrowingBook = new BorrowingBook(dataStorage, userModeUi, commonFunctionUi, user, programProcess, bookInformationException);
                borrowingBook.BorrowBook();
            }

            else if (menuNumber == (int)(UserMenuNumber.BOOK_BORROW_LIST))
            {
                BookBorrowList bookBorrowList = new BookBorrowList(dataStorage, userModeUi, user, programProcess);
                bookBorrowList.ShowBookBorrowList();
            }

            else if (menuNumber == (int)(UserMenuNumber.RETURNING_BOOK))
            {
                ReturningBook returningBook = new ReturningBook(dataStorage, userModeUi, user, programProcess, bookInformationException);
                returningBook.ReturnBook();
            }

            else if (menuNumber == (int)(UserMenuNumber.BOOK_RETURN_LIST))
            {
                BookReturnList bookReturnList = new BookReturnList(dataStorage, userModeUi, user, programProcess);
                bookReturnList.ShowBookReturnList();
            }

            else if (menuNumber == (int)(UserMenuNumber.EDIT_USER_INF))
            {
                EditingUserInformation editingUserInformation = new EditingUserInformation(dataStorage, userModeUi, user, userInformationException, bookInformationException,programProcess);
                editingUserInformation.EditUserInformation();
            }

            else if (menuNumber == (int)(UserMenuNumber.DELETE_USER_INFORMATION))
            {
                DeletingUserInformation deletingUserInformation = new DeletingUserInformation(userModeUi, dataStorage, user, programProcess);
                deletingUserInformation.DeleteUserInformation();
            }

        }
    }
}
