using System;

public class BookReturnList
{
    DataStorage dataStorage;
    Ui ui;
    UserInf user;
    public BookReturnList(DataStorage dataStorage, Ui ui, UserInf user)
    {
        this.dataStorage = dataStorage;
        this.ui = ui;
        this.user = user;
    }
    public void ShowBookReturnList()
    {
        while (true)
        {
            ui.PrintReturningMenuList();
            ConsoleKeyInfo inputKey;

            for (int i = 0; i < user.returnBookList.Count; i++)
            {
                ui.PrintUserBorrowingList(user.returnBookList[i]);

            }

            inputKey = Console.ReadKey();
            if (inputKey.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                continue;
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
