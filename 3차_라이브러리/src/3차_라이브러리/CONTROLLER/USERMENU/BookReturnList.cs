using System;

public class BookReturnList
{
    public void ShowBookReturnList(Data data, Ui ui, MagicNumber magicNumber, UserInf user)
    {
        ui.PrintReturningMenuList();
        ConsoleKeyInfo inputKey;

        for (int i = 0; i < user.returnBookList.Count; i++)
        {
            ui.PrintUserBorrowingList(user.returnBookList[i]);

        }
        inputKey = Console.ReadKey();
        if (inputKey.Key == ConsoleKey.Escape)
        {
            return;
        }
        else
        {

        }


    }
}
