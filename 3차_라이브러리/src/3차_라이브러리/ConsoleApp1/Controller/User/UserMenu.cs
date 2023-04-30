using System;

public class UserMenu //유저 메뉴 진입 기능 클래스
{
    InputByReadKey InputByReadKey;
    RegularExpression regularExpression;
    MainMenuUi mainMenuUi;
    UserModeUi userModeUi;
    CommonFunctionUi commonFunctionUi;

    DataStorage dataStorage;
    UserInformation user;
    ProgramProcess programProcess;

    BookFinder bookFinder;
    BorrowingBook borrowingBook;
    BookBorrowList bookBorrowList;
    ReturningBook returningBook;
    BookReturnList bookReturnList;
    EditingUserInformation editingUserInformation;
    DeletingUserInformation deletingUserInformation;

    public UserMenu(DataStorage dataStorage, UserInformation user, ProgramProcess programProcess)
    {
        this.InputByReadKey = InputByReadKey.GetInstance();
        this.regularExpression = RegularExpression.GetInstance();
        this.mainMenuUi = MainMenuUi.GetInstance();
        this.userModeUi = UserModeUi.GetInstance();
        this.commonFunctionUi = CommonFunctionUi.GetInstance();

        this.dataStorage = dataStorage;
        this.user = user;
        this.programProcess = programProcess;

        this.bookFinder = new BookFinder(dataStorage, programProcess);
        this.borrowingBook = new BorrowingBook(dataStorage, user, programProcess);
        this.bookBorrowList = new BookBorrowList(dataStorage, user, programProcess);
        this.returningBook = new ReturningBook(dataStorage, user, programProcess);
        this.bookReturnList = new BookReturnList(dataStorage, user, programProcess);
        this.editingUserInformation = new EditingUserInformation(dataStorage, user, programProcess);
        this.deletingUserInformation = new DeletingUserInformation(dataStorage, user, programProcess);
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
