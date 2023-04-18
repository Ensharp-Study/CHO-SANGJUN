using System;
using System.Net;

public class ReturningBook
{
    DataStorage dataStorage;
    UserModeUi userModeUi;
    UserInformation userInformation;
    ProgramProcess programProcess;

    public ReturningBook(DataStorage dataStorage, UserModeUi userModeUi, UserInformation userInformation, ProgramProcess programProcess) 
    { 
        this.dataStorage = dataStorage;
        this.userModeUi = userModeUi;
        this.userInformation = userInformation;
        this.programProcess = programProcess;
    }
	public void ReturnBook()
	{
        while (true)
        {
            string bookId;
            int sameIndex = -1;

            userModeUi.PrintReturningBook();

            for (int i = 0; i < userInformation.BorrowBookList.Count; i++)
            {
                userModeUi.PrintShouldReturningList(userInformation.BorrowBookList[i]);
            }

            Console.SetCursorPosition(36, 3);
            bookId = Console.ReadLine();



            for (int i = 0; i < dataStorage.bookList.Count; i++)
            {
                if (dataStorage.bookList[i].BookId == int.Parse(bookId))
                {
                    sameIndex = i;
                    break;
                }

            }

            if (sameIndex == -1)
            {
                Console.SetCursorPosition(0, 3);
                Console.WriteLine("잘못된 ID를 입력하였습니다. 다시 입력해 주세요.");
                Console.WriteLine("                            ");
            }
            else
            {
                Console.SetCursorPosition(0, 3);
                Console.WriteLine("      책 반납 성공!                          ");
                Console.WriteLine("                                               ");
                dataStorage.bookList[sameIndex].BookQuantity += 1;

                for (int i = 0; i < dataStorage.userList.Count; i++)
                {
                    if (userInformation.UserNumber == dataStorage.userList[i].UserNumber)
                    {
                        dataStorage.userList[i].ReturnBookList.Add(dataStorage.bookList[sameIndex]);
                    }
                }
            }

            //프로그램 뒤로 나가기
            if ((programProcess.SelectProgramDirection()).Key == ConsoleKey.Escape)
            {
                break;
            }
        }
    }
}
