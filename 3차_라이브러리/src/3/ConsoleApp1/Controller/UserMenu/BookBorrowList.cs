using System;

public class BookBorrowList
{
    DataStorage dataStorage;
    UserModeUi userModeUi;
    UserInformation userInformation;
    ProgramProcess programProcess;
    public BookBorrowList(DataStorage dataStorage, UserModeUi userModeUi, UserInformation userInformation, ProgramProcess programProcess)
    {
        this.dataStorage = dataStorage;
        this.userModeUi = userModeUi;
        this.userInformation = userInformation;
        this.programProcess = programProcess;
    }

    public void ShowBookBorrowList()
	{
		while (true)
		{
			userModeUi.PrintBorrowingList();
			for (int i = 0; i < userInformation.borrowBookList.Count; i++)
			{
				userModeUi.PrintUserBorrowingList(userInformation.borrowBookList[i]);
			}

            //프로그램 뒤로 나가기
            if ((programProcess.SelectProgramDirection()).Key == ConsoleKey.Escape)
            {
                break;
            }
        }

    }
}
