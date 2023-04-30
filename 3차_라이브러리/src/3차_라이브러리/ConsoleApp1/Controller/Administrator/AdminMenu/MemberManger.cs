using System;
using System.Reflection;

public class MemberManger
{
    AdministratorModeUi administratorModeUi;
    DataStorage dataStorage;
    ProgramProcess programProcess;
    public MemberManger(DataStorage dataStorage, ProgramProcess programProcess)
    {
        this.administratorModeUi = AdministratorModeUi.GetInstance();
        this.dataStorage = dataStorage;
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

            userNumber = InputByReadKey.ReceiveInput(70, 2, 3, Constants.IS_NOT_PASSWORD);

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
