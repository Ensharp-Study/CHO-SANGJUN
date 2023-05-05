using ConsoleApp1.Utility;
using System;

public class AdministratorMenu
{
    InputByReadKey InputByReadKey;
    RegularExpression regularExpression;
    MainMenuUi mainMenuUi;
    AdministratorModeUi administratorModeUi;
    CommonFunctionUi commonFunctionUi;
    MenuSelectController menuSelectController;

    ProgramProcess programProcess;
 
    BookFinder bookFinder;
    AddingBook addingBook;
    DeletingBook deletingBook;
    EditingBook editingBook;
    MemberManger memberManger;
    BookBorrowedStatus bookBorrowedStatus;
    
    public AdministratorMenu(ProgramProcess programProcess)
    {
        this.InputByReadKey = InputByReadKey.GetInstance();
        this.regularExpression = RegularExpression.GetInstance();
        this.mainMenuUi = MainMenuUi.GetInstance();
        this.administratorModeUi = AdministratorModeUi.GetInstance();
        this.commonFunctionUi = CommonFunctionUi.GetInstance();
        this.menuSelectController = MenuSelectController.GetInstance();

        this.programProcess = programProcess;
        
        this.bookFinder = new BookFinder(programProcess);
        this.addingBook = new AddingBook(programProcess);
        this.deletingBook = new DeletingBook( programProcess, bookFinder);
        this.editingBook = new EditingBook( programProcess, bookFinder);
        this.memberManger = new MemberManger( programProcess);
        this.bookBorrowedStatus = new BookBorrowedStatus(programProcess);
    }

    
    public void ControllAdministratorMenu()
    {
        int menuNumber;
        string[] administratorMenuList = { "○ 책 정보 검색", "○ 책 추가하기", "○ 책 삭제하기", "○ 책 정보 수정하기", "○ 회원관리", "○ 도서 대여 현황" };

        while (true)
        {
            mainMenuUi.ViewMainMenu();
            commonFunctionUi.ViewMenu();

            menuNumber = menuSelectController.SelectMenuWithUpAndDown(administratorMenuList, 6, 49, 26);
            Console.Clear();

            switch (menuNumber)
            {
                case (int)(AdministratorMenuNumber.BOOK_FINDER):
                    bookFinder.FindBook();
                    break;

                case (int)(AdministratorMenuNumber.ADDING_BOOK):
                    addingBook.AddNewBook();
                    break;

                case (int)(AdministratorMenuNumber.DELETING_BOOK):
                    deletingBook.DeleteABook();
                    break;

                case (int)(AdministratorMenuNumber.EDITING_BOOK):
                    editingBook.EditBook();
                    break;

                case (int)(AdministratorMenuNumber.MEMBER_MANAGER):
                    memberManger.ManageMember();
                    break;

                case (int)(AdministratorMenuNumber.BOOK_BORROWING_STATUS):
                    bookBorrowedStatus.CheckBookBorrowedList();
                    break;
            }

            if(menuNumber == Constants.ESC)
            {
                break;
            }
        }

    }
}
