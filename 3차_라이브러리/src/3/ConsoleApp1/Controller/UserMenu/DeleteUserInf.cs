using System;

public class DeletingUserInf //inf와같이 줄임말 
{
    UserModeUi userModeUi;
    DataStorage dataStorage;
    UserInf user;

    public DeletingUserInf(UserModeUi userModeUi, DataStorage dataStorage, UserInf user)
    {
        this.userModeUi = userModeUi;
        this.dataStorage = dataStorage;
        this.user = user;
    }

    public void DeleteUserInf()
    {
        while (true)
        {
            userModeUi.confirmAccountDeletion();

            ConsoleKeyInfo inputKey;
            bool isCheckedEnter = false;
            int selectedMenuNum = -1;

            Console.SetCursorPosition(43, 3);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("○ 예");
            Console.SetCursorPosition(60, 3);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("○ 아니오");
            selectedMenuNum = Constants.DELETEING_USER;

            while (isCheckedEnter == false)
            {
                inputKey = Console.ReadKey();
                if (inputKey.Key == ConsoleKey.LeftArrow)
                {
                    Console.SetCursorPosition(43, 4);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("○ 예");
                    Console.SetCursorPosition(60, 4);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("○ 아니오");
                    selectedMenuNum = Constants.DELETEING_USER;
                }
                else if (inputKey.Key == ConsoleKey.RightArrow)
                {
                    Console.SetCursorPosition(43, 4);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("○ 예");
                    Console.SetCursorPosition(60, 4);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("○ 아니오");
                    Console.ResetColor();
                    selectedMenuNum = Constants.SAVING_USER;
                }
                else if (inputKey.Key == ConsoleKey.Enter)
                {
                    isCheckedEnter = true;
                }
            }
            if (selectedMenuNum == Constants.DELETEING_USER)
            {
                for (int i = 0; i < dataStorage.userList.Count; i++)
                {
                    if (dataStorage.userList[i] == user)
                    {
                        dataStorage.userList.RemoveAt(i);
                    }
                }
                Console.Clear();
                userModeUi.PrintAccountDeletionSentence();
            }
            else if (selectedMenuNum == Constants.SAVING_USER)
            {
                Console.Clear();
                userModeUi.PrintMaintainingAccountSentence();
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
