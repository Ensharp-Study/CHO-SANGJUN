using System;

public class BookReturnList
{
    UserModeUi userModeUi;
    DataStorage dataStorage;
    UserInformation user;
    ProgramProcess programProcess;
    public BookReturnList(DataStorage dataStorage, UserInformation user, ProgramProcess programProcess)
    {
        this.userModeUi = UserModeUi.GetInstance();
        this.dataStorage = dataStorage;
        this.user = user;
        this.programProcess = programProcess;
    }
    public void ShowBookReturnList()
    {
        while (true)
        {
            userModeUi.PrintReturningMenuList();
 
            for (int i = 0; i < user.ReturnBookList.Count; i++)
            {
                userModeUi.PrintUserBorrowingList(user.ReturnBookList[i]);

            }

            //프로그램 뒤로 나가기
            if ((programProcess.SelectProgramDirection()).Key == ConsoleKey.Escape)
            {
                break;
            }
        }
    }
}
