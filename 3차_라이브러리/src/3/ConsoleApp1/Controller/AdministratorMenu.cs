using System;

public class AdministratorMenu
{
    MainMenuUi mainMenuUi;
    DataStorage dataStorage;
    ProgramProcess programProcess;

    public AdministratorMenu(MainMenuUi mainMenuUi,   DataStorage dataStorage, ProgramProcess programProcess)
    {
        this.mainMenuUi = mainMenuUi;
        this.dataStorage = dataStorage;
        this.programProcess = programProcess;
    }

    AdministratorModeUi administratorModeUi = new AdministratorModeUi();
    CommonFunctionUi commonFunctionUi = new CommonFunctionUi();
    BookInformationException bookInformationException = new BookInformationException();
    public void ControllAdministratorMenu()
    {
        while (true)
        {
            
            int menuNumber;
            mainMenuUi.ViewMainMenu();
            commonFunctionUi.ViewMenu();
            
            menuNumber = administratorModeUi.PrintSelectAdministratorMenu();
            Console.Clear();

            //상속을 활용하기 좀 더 고민해서 유저 관리자가 둘다 코드 재활용할 수 있을지 클래스 분할
            if (menuNumber == Constants.BOOK_FINDER)   //스위치
            {
                BookFinder bookFinder = new BookFinder(dataStorage, commonFunctionUi, programProcess);
                bookFinder.FindBook();
            }

            if (menuNumber == Constants.ADDING_BOOK)
            {
                AddingBook addingBook = new AddingBook(dataStorage, administratorModeUi, bookInformationException, programProcess);
                addingBook.AddNewBook();
            }

            if (menuNumber == Constants.DELETING_BOOK)
            {
                DeletingBook deletingBook = new DeletingBook(dataStorage, administratorModeUi, commonFunctionUi, programProcess);
                deletingBook.DeleteABook();
            }

            if (menuNumber == Constants.EDITING_BOOK)
            {
                EditingBook editingBook = new EditingBook(dataStorage, administratorModeUi, commonFunctionUi, bookInformationException, programProcess);
                editingBook.EditBook();
            }

            if (menuNumber == Constants.MEMBER_MANAGER)
            {
                MemberManger memberManger = new MemberManger(dataStorage, administratorModeUi, programProcess);
                memberManger.ManageMember();
            }

            if (menuNumber == Constants.BOOK_BORROWING_STATUS)
            {
                BookBorrowedStatus bookBorrowedStatus = new BookBorrowedStatus(dataStorage, administratorModeUi, programProcess);
                bookBorrowedStatus.CheckBookBorrowedList();
            }
            if(menuNumber == Constants.ESC)
            {
                break;
            }

        }

    }
}
