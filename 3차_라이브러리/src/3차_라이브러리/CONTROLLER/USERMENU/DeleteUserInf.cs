using System;

public class DeletingUserInf //inf와같이 줄임말 
{
    Ui ui;
    MagicNumber magicNumber;
    Data data;
    UserInf user;

    public DeletingUserInf(Ui ui, MagicNumber magicNumber, Data data, UserInf user)
    {
        this.ui = ui;
        this.magicNumber = magicNumber;
        this.data = data;
        this.user = user;
    }

    public void DeleteUserInf()
    {
        while (true)
        {
            ui.confirmAccountDeletion();

            ConsoleKeyInfo inputKey;
            bool isCheckedEnter = false;
            int selectedMenuNum = -1;

            Console.SetCursorPosition(43, 3);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("○ 예");
            Console.SetCursorPosition(60, 3);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("○ 아니오");
            selectedMenuNum = MagicNumber.DELETEING_USER;

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
                    selectedMenuNum = MagicNumber.DELETEING_USER;
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
                    selectedMenuNum = MagicNumber.SAVING_USER;
                }
                else if (inputKey.Key == ConsoleKey.Enter)
                {
                    isCheckedEnter = true;
                }
            }
            if (selectedMenuNum == MagicNumber.DELETEING_USER)
            {
                for (int i = 0; i < data.userList.Count; i++)
                {
                    if (data.userList[i] == user)
                    {
                        data.userList.RemoveAt(i);
                    }
                }
                Console.Clear();
                ui.PrintAccountDeletionSentence();
            }
            else if (selectedMenuNum == MagicNumber.SAVING_USER)
            {
                Console.Clear();
                ui.PrintMaintainingAccountSentence();
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
