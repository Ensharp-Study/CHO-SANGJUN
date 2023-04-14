using System;

public class BookBorrowList
{
    ConsoleKeyInfo inputKey;
    public void ShowBookBorrowList(Data data,Ui ui, MagicNumber magicNumber,UserInf user)
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
