using System;

public class AdministratorMenu
{
    Ui ui;
    Data data;
    MagicNumber magicNumber;

    public AdministratorMenu(Ui ui, Data data, MagicNumber magicNumber)
    {
        this.ui = ui;
        this.data = data;
        this.magicNumber = magicNumber;
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
            if (menuNumber == MagicNumber.BOOK_FINDER)   //스위치
            {
                BookFinder bookFinder = new BookFinder(data, ui, magicNumber);
                bookFinder.FindBook();
            }

            if (menuNumber == MagicNumber.ADDING_BOOK)
            {
                AddingBook addingBook = new AddingBook(data, ui, magicNumber);
                addingBook.AddNewBook();
            }

            if (menuNumber == MagicNumber.DELETING_BOOK)
            {
                DeletingBook deletingBook = new DeletingBook(data, ui, magicNumber);
                deletingBook.DeleteABook();
            }

            if (menuNumber == MagicNumber.EDITING_BOOK)
            {
                EditingBook editingBook = new EditingBook(data, ui);
                editingBook.EditBook();
            }

            if (menuNumber == MagicNumber.MEMBER_MANAGER)
            {
                MemberManger memberManger = new MemberManger(data, ui);
                memberManger.ManageMember();
            }

            if (menuNumber == MagicNumber.BOOK_BORROWING_STATUS)
            {
                BookBorrowedStatus bookBorrowedStatus = new BookBorrowedStatus(data, ui, magicNumber);
                bookBorrowedStatus.CheckBookBorrowedList();
            }
            if(menuNumber == MagicNumber.ESC)
            {
                break;
            }

        }

    }
}
