using System;

public class BorrowingBook
{
    DataStorage dataStorage;
    UserModeUi userModeUi;
    CommonFunctionUi commonFunctionUi;
    UserInformation userInformation;
    ProgramProcess programProcess;

    public BorrowingBook(DataStorage dataStorage, UserModeUi userModeUi, CommonFunctionUi commonFunctionUi, UserInformation userInformation, ProgramProcess programProcess) 
    { 
        this.dataStorage = dataStorage;
        this.userModeUi = userModeUi;
        this.commonFunctionUi = commonFunctionUi;
        this.userInformation = userInformation;
        this.programProcess = programProcess;
    }

	public void BorrowBook()
	{

        while (true)
        {
            string bookId;
            int sameIndex = -1;

            Console.Clear();
            userModeUi.PrintBorrowingBookMenu();//책 빌리기 메뉴 출력
            for (int i = 0; i < dataStorage.bookList.Count; i++)
            {
                commonFunctionUi.PrintBookList(dataStorage.bookList[i], i);
            }

            while (sameIndex == -1)
            {
                Console.SetCursorPosition(36, 3);
                Console.Write("                                         ");
                Console.SetCursorPosition(36, 3);
                bookId = Console.ReadLine();


                for (int i = 0; i < dataStorage.bookList.Count; i++)
                { //책 id와 저장된 책 리스트 비교
                    if (dataStorage.bookList[i].BookId == int.Parse(bookId))
                    {
                        sameIndex = i;
                        break;
                    }
                }

                if (sameIndex == -1)
                {
                    Console.SetCursorPosition(36, 3);
                    userModeUi.PrintNotCorrectBook();
                    Console.ReadKey();
                }
            }

            if (dataStorage.bookList[sameIndex].BookQuantity > 0)   //view쪽으로
            {
                Console.SetCursorPosition(0, 3);
                Console.WriteLine("      책 빌리기 성공!                          ");
                Console.WriteLine("                                               ");
                dataStorage.bookList[sameIndex].BookQuantity -= 1;
                for (int i = 0; i < dataStorage.userList.Count; i++)
                {
                    if (userInformation.UserNumber == dataStorage.userList[i].UserNumber)
                    {
                        dataStorage.userList[i].BorrowBookList.Add(dataStorage.bookList[sameIndex]);
                        break;
                    }
                }
            }
            else if (dataStorage.bookList[sameIndex].BookQuantity == 0)
            {
                Console.SetCursorPosition(0, 3);
                Console.WriteLine("전 수량이 대여 중 입니다.         ");
                Console.WriteLine("                                  ");

            }
            else if (sameIndex == -1)
            {
                Console.SetCursorPosition(0, 3);
                Console.WriteLine("잘못된 ID를 입력하였습니다. 다시 입력해 주세요.");
                Console.WriteLine("                            ");
            }

            if ((programProcess.SelectProgramDirection()).Key == ConsoleKey.Escape)
            {
                break;
            }

        }

    }
}
