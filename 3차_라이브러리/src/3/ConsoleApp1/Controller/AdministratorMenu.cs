using System;

public class AdministratorMenu
{
    Ui ui;
    DataStorage dataStorage;

    public AdministratorMenu(Ui ui, DataStorage dataStorage)
    {
        this.ui = ui;
        this.dataStorage = dataStorage;
    }

    public void ControllAdministratorMenu()
    {
        while (true)
        {
            ConsoleKeyInfo inputKey;
            int menuNumber;
            ui.ViewMainMenu();
            ui.ViewMenu();

            menuNumber = ui.PrintSelectAdministratorMenu();
            Console.Clear();

            //상속을 활용하기 좀 더 고민해서 유저 관리자가 둘다 코드 재활용할 수 있을지 클래스 분할
            if (menuNumber == Constants.BOOK_FINDER)   //스위치
            {
                BookFinder bookFinder = new BookFinder(dataStorage, ui);
                bookFinder.FindBook();
            }

            if (menuNumber == Constants.ADDING_BOOK)
            {
                AddingBook addingBook = new AddingBook(dataStorage, ui);
                addingBook.AddNewBook();
            }

            if (menuNumber == Constants.DELETING_BOOK)
            {
                DeletingBook deletingBook = new DeletingBook(dataStorage, ui);
                deletingBook.DeleteABook();
            }

            if (menuNumber == Constants.EDITING_BOOK)
            {
                EditingBook editingBook = new EditingBook(dataStorage, ui);
                editingBook.EditBook();
            }

            if (menuNumber == Constants.MEMBER_MANAGER)
            {
                MemberManger memberManger = new MemberManger(dataStorage, ui);
                memberManger.ManageMember();
            }

            if (menuNumber == Constants.BOOK_BORROWING_STATUS)
            {
                BookBorrowedStatus bookBorrowedStatus = new BookBorrowedStatus(dataStorage, ui);
                bookBorrowedStatus.CheckBookBorrowedList();
            }
            if(menuNumber == Constants.ESC)
            {
                break;
            }

        }

    }
}
