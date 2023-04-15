using System;

public class MemberManger
{
    ConsoleKeyInfo inputKey;
    DataStorage dataStorage;

    AdministratorModeUi administratorModeUi;
    public MemberManger(DataStorage dataStorage, AdministratorModeUi administratorModeUi)
    {
        this.dataStorage = dataStorage;
        this.administratorModeUi = administratorModeUi;
    }

    public void ManageMember()
    {
        while (true)
        {
            string userNumber;

            administratorModeUi.PrintMemberManagerMenu();
            for (int i = 0; i < dataStorage.userList.Count; i++)
            {
                administratorModeUi.PrintMemberList(dataStorage, i);
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
            administratorModeUi.PrintDeletingUserSuccessSentence();
            for (int i = 0; i < dataStorage.userList.Count; i++)
            {
                administratorModeUi.PrintMemberList(dataStorage, i);
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
