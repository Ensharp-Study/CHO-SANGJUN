using System;

public class AdministratorMenu
{
    MainMenuUi mainMenuUi;
    DataStorage dataStorage;
    ProgramProcess programProcess;
    BookInformationException bookInformationException;
    AdministratorModeUi administratorModeUi;
    CommonFunctionUi commonFunctionUi;

    BookFinder bookFinder;
    AddingBook addingBook;
    DeletingBook deletingBook;
    EditingBook editingBook;
    MemberManger memberManger;
    BookBorrowedStatus bookBorrowedStatus;

    public AdministratorMenu(DataStorage dataStorage, ProgramProcess programProcess, BookInformationException bookInformationException)
    {
        this.mainMenuUi = MainMenuUi.GetInstance();
        this.administratorModeUi = AdministratorModeUi.GetInstance();
        this.commonFunctionUi = CommonFunctionUi.GetInstance();
        this.dataStorage = dataStorage;
        this.programProcess = programProcess;
        this.bookInformationException = bookInformationException;
        
        this.bookFinder = new BookFinder(dataStorage, programProcess, bookInformationException);
        this.addingBook = new AddingBook(dataStorage, bookInformationException, programProcess);
        this.deletingBook = new DeletingBook(dataStorage, programProcess, bookInformationException);
        this.editingBook = new EditingBook(dataStorage, bookInformationException, programProcess);
        this.memberManger = new MemberManger(dataStorage, programProcess);
        this.bookBorrowedStatus = new BookBorrowedStatus(dataStorage, programProcess);
    }

    
    public void ControllAdministratorMenu()
    {
        int menuNumber;

        while (true)
        {
            mainMenuUi.ViewMainMenu();
            commonFunctionUi.ViewMenu();
            
            menuNumber = administratorModeUi.PrintSelectAdministratorMenu();
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
