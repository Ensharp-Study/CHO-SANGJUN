using System;

public class DeletingUserInf //inf와같이 줄임말 
{
    UserModeUi userModeUi;
    DataStorage dataStorage;
    UserInformation userInformation;

    public DeletingUserInf(UserModeUi userModeUi, DataStorage dataStorage, UserInformation userInformation)
    {
        this.userModeUi = userModeUi;
        this.dataStorage = dataStorage;
        this.userInformation = userInformation;
    }

    public void DeleteUserInformation()
    {
        while (true)
        {
            userModeUi.confirmAccountDeletion();

            ConsoleKeyInfo inputKey;
            bool isCheckedEnter = false;
            int selectedMenuNumber = -1;

            Console.SetCursorPosition(43, 3);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("○ 예");
            Console.SetCursorPosition(60, 3);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("○ 아니오");
            selectedMenuNumber = Constants.DELETEING_USER;

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
                    selectedMenuNumber = Constants.DELETEING_USER;
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
                    selectedMenuNumber = Constants.SAVING_USER;
                }
                else if (inputKey.Key == ConsoleKey.Enter)
                {
                    isCheckedEnter = true;
                }
            }
            if (selectedMenuNumber == Constants.DELETEING_USER)
            {
                for (int i = 0; i < dataStorage.userList.Count; i++)
                {
                    if (dataStorage.userList[i] == userInformation)
                    {
                        dataStorage.userList.RemoveAt(i);
                    }
                }
                Console.Clear();
                userModeUi.PrintAccountDeletionSentence();
            }
            else if (selectedMenuNumber == Constants.SAVING_USER)
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
