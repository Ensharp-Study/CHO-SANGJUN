using System;

public class UserMenu
{
    public void ControllUserMenu(Ui ui, Data data,MagicNumber magicNumber, UserInf user)
	{
         while (true) { 
        
            int menuNumber;
            ui.ViewUserMenu();
            menuNumber = ui.PrintSelectUserMenu(magicNumber);
            Console.Clear();

            //상속을 활용하기 좀 더 고민해서 유저 관리자가 둘다 코드 재활용할 수 있을지 클래스 분할
            if (menuNumber == magicNumber.BOOKFINDER)   //스위치
            {
                BookFinder bookFinder = new BookFinder();
                bookFinder.FindBook(data, ui, magicNumber);
            }

            else if (menuNumber == magicNumber.BORROWINGBOOK)
            {
                BorrowingBook borrowingBook = new BorrowingBook();
                borrowingBook.BorrowBook(data, ui, magicNumber, user);
            }

            if (menuNumber == magicNumber.BOOKBORROWLIST)
            {
                BookBorrowList bookBorrowList = new BookBorrowList();
                bookBorrowList.ShowBookBorrowList(data, ui, magicNumber, user);
            }

            if (menuNumber == magicNumber.RETURNINGBOOK)
            {
                ReturningBook returningBook = new ReturningBook();
                returningBook.ReturnBook(data, ui, user);
            }

            if (menuNumber == magicNumber.BOOKRETURNLIST)
            {
                BookReturnList bookReturnList = new BookReturnList();
                bookReturnList.ShowBookReturnList(data, ui, magicNumber, user);
            }

            if (menuNumber == magicNumber.EDITUSERINF)
            {
                EditingUserInf editingUserInf = new EditingUserInf();
                editingUserInf.EditUserInf(data, ui, user);
            }

            if (menuNumber == magicNumber.DELETEUSERINF)
            {
                DeletingUserInf deletingUserInf = new DeletingUserInf();
                deletingUserInf.DeleteUserInf(ui, magicNumber, data, user);
            }
         }

    }
}
