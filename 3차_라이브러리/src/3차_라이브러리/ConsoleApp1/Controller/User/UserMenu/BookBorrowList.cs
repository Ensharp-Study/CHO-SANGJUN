using System;

public class BookBorrowList
{
    UserModeUi userModeUi;
    DataStorage dataStorage;
    UserDTO userInformation;
    ProgramProcess programProcess;
    public BookBorrowList(DataStorage dataStorage, UserDTO userInformation, ProgramProcess programProcess)
    {
        this.userModeUi = UserModeUi.GetInstance();
        this.dataStorage = dataStorage;
        this.userInformation = userInformation;
        this.programProcess = programProcess;
    }

    public void ShowBookBorrowList()
	{
		while (true)
		{
			userModeUi.PrintBorrowingList();
			for (int i = 0; i < userInformation.BorrowBookList.Count; i++)
			{
				userModeUi.PrintUserBorrowingList(userInformation.BorrowBookList[i]);
			}

            //프로그램 뒤로 나가기
            if ((programProcess.SelectProgramDirection()).Key == ConsoleKey.Escape)
            {
                break;
            }
        }

    }
}
