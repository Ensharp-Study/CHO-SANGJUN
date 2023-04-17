using System;

public class BookReturnList
{
    DataStorage dataStorage;
    UserModeUi userModeUi;
    UserInformation user;
    ProgramProcess programProcess;
    public BookReturnList(DataStorage dataStorage, UserModeUi userModeUi, UserInformation user, ProgramProcess programProcess)
    {
        this.dataStorage = dataStorage;
        this.userModeUi = userModeUi;
        this.user = user;
        this.programProcess = programProcess;
    }
    public void ShowBookReturnList()
    {
        while (true)
        {
            userModeUi.PrintReturningMenuList();
 
            for (int i = 0; i < user.returnBookList.Count; i++)
            {
                userModeUi.PrintUserBorrowingList(user.returnBookList[i]);

            }

            //프로그램 뒤로 나가기
            if ((programProcess.SelectProgramDirection()).Key == ConsoleKey.Escape)
            {
                break;
            }
        }
    }
}
