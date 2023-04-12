using System;

public class AdministratorMenu
{
    public void ControllAdministratorMenu(Ui ui, Data data, MagicNumber magicNumber)
    {
        //while (true)
        //{

            int menuNumber;
            ui.ViewMenu();
            menuNumber = ui.PrintSelectAdministratorMenu();
            Console.Clear();

            //상속을 활용하기 좀 더 고민해서 유저 관리자가 둘다 코드 재활용할 수 있을지 클래스 분할
            if (menuNumber == magicNumber.BOOKFINDER)   //스위치
            {
                BookFinder bookFinder = new BookFinder();
                bookFinder.FindBook(data, ui, magicNumber);
            }

            else if (menuNumber == magicNumber.ADDINGBOOK)
            {
                AddingBook addingBook = new AddingBook();
                addingBook.AddNewBook(data,ui,magicNumber);
            }

            if (menuNumber == magicNumber.BOOKBORROWLIST)
            {
            }

            if (menuNumber == magicNumber.RETURNINGBOOK)
            {
               
            }

            if (menuNumber == magicNumber.BOOKRETURNLIST)
            {
                
            }

            if (menuNumber == magicNumber.EDITUSERINF)
            {
               
            }

            if (menuNumber == magicNumber.DELETEUSERINF)
            {
               
            }
        //}

    }
}
