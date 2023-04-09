using System;

public class BookReturnList
{
    public void ShowBookReturnList(Data data, Ui ui, MagicNumber magicNumber, UserInf user)
    {
        ui.PrintReturningList();
        for (int i = 0; i < user.returnBookList.Count; i++)
        {
            ui.PrintUserBorrowingList(user.returnBookList[i]);

        }


    }
}
