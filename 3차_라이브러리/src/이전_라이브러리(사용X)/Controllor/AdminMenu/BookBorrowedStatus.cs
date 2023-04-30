using System;

public class BookBorrowedStatus
{
    ConsoleKeyInfo inputKey;
    Data data;
    Ui ui;
    MagicNumber magicNumber;

    public BookBorrowedStatus(Data data, Ui ui, MagicNumber magicNumber)
    {
        this.data = data;
        this.ui = ui;
        this.magicNumber = magicNumber;
    }

    public void CheckBookBorrowedList()
    {
        while (true)
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

            inputKey = Console.ReadKey();
            if (inputKey.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                break;
            }
            else if (inputKey.Key == ConsoleKey.Escape)
            {
                Console.Clear();
                break;
            }
            else
            {
                Console.Clear();
                break;
            }
        }
    }
}
    

