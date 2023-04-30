using System;

public class UserMenu //유저 메뉴 진입 기능 클래스
{
    MainMenuUi mainMenuUi;
    UserModeUi userModeUi;
    CommonFunctionUi commonFunctionUi;

    DataStorage dataStorage;
    UserInformation user;
    UserInformationException userInformationException;
    BookInformationException bookInformationException;
    ProgramProcess programProcess;

    BookFinder bookFinder;
    BorrowingBook borrowingBook;
    BookBorrowList bookBorrowList;
    ReturningBook returningBook;
    BookReturnList bookReturnList;
    EditingUserInformation editingUserInformation;
    DeletingUserInformation deletingUserInformation;

    public UserMenu(MainMenuUi mainMenuUi, DataStorage dataStorage, UserInformation user, UserInformationException userInformationException, BookInformationException bookInformationException, ProgramProcess programProcess)
    {
        this.mainMenuUi = mainMenuUi;
        this.dataStorage = dataStorage;
        this.user = user;
        this.userInformationException = userInformationException;
        this.bookInformationException = bookInformationException;
        this.programProcess = programProcess;

        this.userModeUi = new UserModeUi();
        this.commonFunctionUi = new CommonFunctionUi();
        this.bookFinder = new BookFinder(dataStorage, commonFunctionUi, programProcess, bookInformationException);
        this.borrowingBook = new BorrowingBook(dataStorage, userModeUi, commonFunctionUi, user, programProcess, bookInformationException);
        this.bookBorrowList = new BookBorrowList(dataStorage, userModeUi, user, programProcess);
        this.returningBook = new ReturningBook(dataStorage, userModeUi, user, programProcess, bookInformationException);
        this.bookReturnList = new BookReturnList(dataStorage, userModeUi, user, programProcess);
        this.editingUserInformation = new EditingUserInformation(dataStorage, userModeUi, user, userInformationException, bookInformationException, programProcess);
        this.deletingUserInformation = new DeletingUserInformation(userModeUi, dataStorage, user, programProcess);
    }

    

    public void ControllUserMenu() //유저 메뉴 선택 함수
    {
        while (true)
        {
            int menuNumber;
            mainMenuUi.ViewMainMenu();
            commonFunctionUi.ViewMenu();
            menuNumber = userModeUi.PrintSelectUserMenu(); //선택한 유저 메뉴 저장
            Console.Clear();

            switch (menuNumber)
            {
                case (int)(UserMenuNumber.BOOK_FINDER):
                    bookFinder.FindBook();
                    break;

                case (int)(UserMenuNumber.BORROWING_BOOK):
                    borrowingBook.BorrowBook();
                    break;

                case (int)(UserMenuNumber.BOOK_BORROW_LIST):
                    bookBorrowList.ShowBookBorrowList();
                    break;

                case (int)(UserMenuNumber.RETURNING_BOOK):
                    returningBook.ReturnBook();
                    break;

                case (int)(UserMenuNumber.BOOK_RETURN_LIST):
                    bookReturnList.ShowBookReturnList();
                    break;

                case (int)(UserMenuNumber.EDIT_USER_INF):
                    editingUserInformation.EditUserInformation();
                    break;

                case (int)(UserMenuNumber.DELETE_USER_INFORMATION):
                    deletingUserInformation.DeleteUserInformation();
                    break;
            }
        }
    }
}
