using ConsoleApp1.Model;
using System;

public class UserMenu //유저 메뉴 진입 기능 클래스
{
    InputByReadKey InputByReadKey;
    RegularExpression regularExpression;
    MainMenuUi mainMenuUi;
    UserModeUi userModeUi;
    CommonFunctionUi commonFunctionUi;

    ProgramProcess programProcess;

    BookFinder bookFinder;
    BorrowingBook borrowingBook;
    BookBorrowList bookBorrowList;
    ReturningBook returningBook;
    BookReturnList bookReturnList;
    EditingUserInformation editingUserInformation;
    DeletingUserInformation deletingUserInformation;

    public UserMenu(ProgramProcess programProcess)
    {
        this.InputByReadKey = InputByReadKey.GetInstance();
        this.regularExpression = RegularExpression.GetInstance();
        this.mainMenuUi = MainMenuUi.GetInstance();
        this.userModeUi = UserModeUi.GetInstance();
        this.commonFunctionUi = CommonFunctionUi.GetInstance();

        this.programProcess = programProcess;

        this.bookFinder = new BookFinder(programProcess);
        this.borrowingBook = new BorrowingBook( programProcess);
        this.bookBorrowList = new BookBorrowList( programProcess);
        this.returningBook = new ReturningBook(programProcess);
        this.bookReturnList = new BookReturnList(programProcess);
        this.editingUserInformation = new EditingUserInformation(programProcess);
        this.deletingUserInformation = new DeletingUserInformation(programProcess);
    }

    public void ControllUserMenu(UserDTO loggedInUserInformation) //유저 메뉴 선택 함수
    {
        bool isMenuExecute = true; //메뉴 탈출 진리형 변수
        while (isMenuExecute)
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
                    borrowingBook.BorrowBook(loggedInUserInformation);
                    break;

                case (int)(UserMenuNumber.BOOK_BORROW_LIST):
                    bookBorrowList.ShowBookBorrowList(loggedInUserInformation);
                    break;

                case (int)(UserMenuNumber.RETURNING_BOOK):
                    returningBook.ReturnBook(loggedInUserInformation);
                    break;

                case (int)(UserMenuNumber.BOOK_RETURN_LIST):
                    bookReturnList.ShowBookReturnList(loggedInUserInformation);
                    break;

                case (int)(UserMenuNumber.EDIT_USER_INF):
                    editingUserInformation.EditUserInformation(loggedInUserInformation);
                    break;

                case (int)(UserMenuNumber.DELETE_USER_INFORMATION):
                    isMenuExecute = !deletingUserInformation.DeleteUserInformation(loggedInUserInformation); //회원탈퇴 성공시 true가 반환됨
                    break;
            }
        }
    }
}
