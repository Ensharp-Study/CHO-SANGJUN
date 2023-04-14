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
            if (menuNumber == magicNumber.BOOKFINDER)   //스위치
            {
                BookFinder bookFinder = new BookFinder(data, ui, magicNumber);
                bookFinder.FindBook();
            }

            if (menuNumber == magicNumber.ADDINGBOOK)
            {
                AddingBook addingBook = new AddingBook(data, ui, magicNumber);
                addingBook.AddNewBook();
            }

            if (menuNumber == magicNumber.DELETINGBOOK)
            {
                DeletingBook deletingBook = new DeletingBook();
                deletingBook.DeleteABook(data, ui, magicNumber);
            }

            if (menuNumber == magicNumber.EDITINGBOOK)
            {
                EditingBook editingBook = new EditingBook();
                editingBook.EditBook(data, ui);
            }

            if (menuNumber == magicNumber.MEMBERMANAGER)
            {
                MemberManger memberManger = new MemberManger();
                memberManger.ManageMember(data, ui);
            }

            if (menuNumber == magicNumber.BOOKBORROWINGSTATUS)
            {
                BookBorrowedStatus bookBorrowedStatus = new BookBorrowedStatus();
                bookBorrowedStatus.CheckBookBorrowedList(data, ui, magicNumber);
            }
            if(menuNumber == magicNumber.ESC)
            {
                break;
            }

        }

    }
}
