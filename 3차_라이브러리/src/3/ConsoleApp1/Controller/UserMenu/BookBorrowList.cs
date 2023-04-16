using System;

public class BookBorrowList
{
    DataStorage dataStorage;
    UserModeUi userModeUi;
    UserInformation userInformation;

    public BookBorrowList(DataStorage dataStorage, UserModeUi userModeUi, UserInformation userInformation)
    {
        this.dataStorage = dataStorage;
        this.userModeUi = userModeUi;
        this.userInformation = userInformation;
    }
    
    ConsoleKeyInfo inputKey;

    public void ShowBookBorrowList()
	{
		while (true)
		{
			userModeUi.PrintBorrowingList();
			for (int i = 0; i < userInformation.borrowBookList.Count; i++)
			{
				userModeUi.PrintUserBorrowingList(userInformation.borrowBookList[i]);
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
