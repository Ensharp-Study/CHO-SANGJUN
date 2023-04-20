using System;

public class AdministratorMenu
{
    MainMenuUi mainMenuUi;
    DataStorage dataStorage;
    ProgramProcess programProcess;
    BookInformationException bookInformationException;

    public AdministratorMenu(MainMenuUi mainMenuUi,   DataStorage dataStorage, ProgramProcess programProcess, BookInformationException bookInformationException)
    {
        this.mainMenuUi = mainMenuUi;
        this.dataStorage = dataStorage;
        this.programProcess = programProcess;
        this.bookInformationException = bookInformationException;
    }

    AdministratorModeUi administratorModeUi = new AdministratorModeUi();
    CommonFunctionUi commonFunctionUi = new CommonFunctionUi();
    public void ControllAdministratorMenu()
    {
        while (true)
        {
            
            int menuNumber;
            mainMenuUi.ViewMainMenu();
            commonFunctionUi.ViewMenu();
            
            menuNumber = administratorModeUi.PrintSelectAdministratorMenu();
            Console.Clear();

            if (menuNumber == (int)(AdministratorMenuNumber.BOOK_FINDER) )
            {
                BookFinder bookFinder = new BookFinder(dataStorage, commonFunctionUi, programProcess, bookInformationException);
                bookFinder.FindBook();
            }

            if (menuNumber == (int)(AdministratorMenuNumber.ADDING_BOOK))
            {
                AddingBook addingBook = new AddingBook(dataStorage, administratorModeUi, bookInformationException, programProcess);
                addingBook.AddNewBook();
            }

            if (menuNumber == (int)(AdministratorMenuNumber.DELETING_BOOK))
            {
                DeletingBook deletingBook = new DeletingBook(dataStorage, administratorModeUi, commonFunctionUi, programProcess, bookInformationException);
                deletingBook.DeleteABook();
            }

            if (menuNumber == (int)(AdministratorMenuNumber.EDITING_BOOK))
            {
                EditingBook editingBook = new EditingBook(dataStorage, administratorModeUi, commonFunctionUi, bookInformationException, programProcess);
                editingBook.EditBook();
            }

            if (menuNumber == (int)(AdministratorMenuNumber.MEMBER_MANAGER))
            {
                MemberManger memberManger = new MemberManger(dataStorage, administratorModeUi, programProcess);
                memberManger.ManageMember();
            }

            if (menuNumber == (int)(AdministratorMenuNumber.BOOK_BORROWING_STATUS))
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
