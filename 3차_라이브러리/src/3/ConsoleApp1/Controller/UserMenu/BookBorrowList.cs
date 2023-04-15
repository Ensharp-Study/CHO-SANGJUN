using System;

public class BookBorrowList
{
    DataStorage dataStorage;
    Ui ui;
    UserInf user;

    public BookBorrowList(DataStorage dataStorage,Ui ui,UserInf user)
    {
        this.dataStorage = dataStorage;
        this.ui = ui;
        this.user = user;

    }
    
    ConsoleKeyInfo inputKey;

    public void ShowBookBorrowList()
	{
		while (true)
		{
			ui.PrintBorrowingList();
			for (int i = 0; i < user.borrowBookList.Count; i++)
			{
				ui.PrintUserBorrowingList(user.borrowBookList[i]);
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
