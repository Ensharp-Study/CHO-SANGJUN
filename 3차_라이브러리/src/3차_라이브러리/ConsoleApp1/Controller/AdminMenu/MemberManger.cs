using System;
using System.Reflection;

public class MemberManger
{
    DataStorage dataStorage;
    AdministratorModeUi administratorModeUi;
    ProgramProcess programProcess;
    public MemberManger(DataStorage dataStorage, AdministratorModeUi administratorModeUi, ProgramProcess programProcess)
    {
        this.dataStorage = dataStorage;
        this.administratorModeUi = administratorModeUi;
        this.programProcess = programProcess;
    }

    public void ManageMember()
    {
        while (true)
        {
            string userNumber;

            administratorModeUi.PrintMemberManagerMenu();
            for (int i = 0; i < dataStorage.userList.Count; i++)
            {
                administratorModeUi.PrintMemberList(dataStorage.userList[i]);
            }
            Console.SetCursorPosition(70, 2);

            userNumber = InputByReadKey.ReceiveInput(70, 2);

            for (int i = 0; i < dataStorage.userList.Count; i++)
            {
                if (int.Parse(userNumber) == dataStorage.userList[i].UserNumber)
                {
                    dataStorage.userList.RemoveAt(i);
                }
            }

            Console.Clear();
            administratorModeUi.PrintDeletingUserSuccessSentence();
            for (int i = 0; i < dataStorage.userList.Count; i++)
            {
                administratorModeUi.PrintMemberList(dataStorage.userList[i]);
            }

            if ((programProcess.SelectProgramDirection()).Key == ConsoleKey.Escape)
            {
                break;
            }
        }
    } 

    
}
