using System;

public class BookBorrowedStatus
{
    public void CheckBookBorrowedList(Data data, Ui ui,MagicNumber magicNumber)
    {
        ui.PrintBookBorrowedMenu();

        for (int i = 0; i < data.userList.Count; i++)
        {
            ui.PrintUserName(data.userList[i].userName);
            for (int j = 0; j < data.userList[i].borrowBookList.Count; j++)
            {
                ui.PrintUserBorrowedBookList(data, i, j);
            }
        }
    }
}
    

