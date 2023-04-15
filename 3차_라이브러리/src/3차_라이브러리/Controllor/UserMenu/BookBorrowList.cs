using System;

public class BookBorrowList
{
    Data data;
    Ui ui;
    MagicNumber magicNumber;
    UserInf user;

    public BookBorrowList(Data data,Ui ui,MagicNumber magicNumber,UserInf user)
    {
        this.data = data;
        this.ui = ui;
        this.magicNumber = magicNumber;
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
