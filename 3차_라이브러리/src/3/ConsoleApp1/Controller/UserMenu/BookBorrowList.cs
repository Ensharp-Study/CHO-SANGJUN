using System;

public class BookBorrowList
{
    DataStorage dataStorage;
    UserModeUi userModeUi;
    UserInf user;

    public BookBorrowList(DataStorage dataStorage, UserModeUi userModeUi, UserInf user)
    {
        this.dataStorage = dataStorage;
        this.userModeUi = userModeUi;
        this.user = user;
    }
    
    ConsoleKeyInfo inputKey;

    public void ShowBookBorrowList()
	{
		while (true)
		{
			userModeUi.PrintBorrowingList();
			for (int i = 0; i < user.borrowBookList.Count; i++)
			{
				userModeUi.PrintUserBorrowingList(user.borrowBookList[i]);
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
