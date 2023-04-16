using System;

public class BookReturnList
{
    DataStorage dataStorage;
    UserModeUi userModeUi;
    UserInformation user;
    public BookReturnList(DataStorage dataStorage, UserModeUi userModeUi, UserInformation user)
    {
        this.dataStorage = dataStorage;
        this.userModeUi = userModeUi;
        this.user = user;
    }
    public void ShowBookReturnList()
    {
        while (true)
        {
            userModeUi.PrintReturningMenuList();
            ConsoleKeyInfo inputKey;

            for (int i = 0; i < user.returnBookList.Count; i++)
            {
                userModeUi.PrintUserBorrowingList(user.returnBookList[i]);

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
