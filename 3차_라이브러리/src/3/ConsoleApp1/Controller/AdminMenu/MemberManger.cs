using System;

public class MemberManger
{
    ConsoleKeyInfo inputKey;
    DataStorage dataStorage;
    Ui ui;

    public MemberManger(DataStorage dataStorage, Ui ui)
    {
        this.dataStorage = dataStorage;
        this.ui = ui;
    }

    public void ManageMember()
    {
        while (true)
        {
            string userNumber;

            ui.PrintMemberManagerMenu();
            for (int i = 0; i < dataStorage.userList.Count; i++)
            {
                ui.PrintMemberList(dataStorage, i);
            }
            Console.SetCursorPosition(70, 2);

            userNumber = Console.ReadLine();

            for (int i = 0; i < dataStorage.userList.Count; i++)
            {
                if (int.Parse(userNumber) == dataStorage.userList[i].userNumber)
                {
                    dataStorage.userList.RemoveAt(i);
                }
            }

            Console.Clear();
            ui.PrintDeletingUserSuccessSentence();
            for (int i = 0; i < dataStorage.userList.Count; i++)
            {
                ui.PrintMemberList(dataStorage, i);
            }

            inputKey = Console.ReadKey();
            if (inputKey.Key == ConsoleKey.Escape)
            {
                Console.Clear();
                return;
            }

            else if (inputKey.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                continue;
            }
        }
    } 

    
}
