using System;
using System.Net;

public class ReturningBook
{
    DataStorage dataStorage;
    UserModeUi userModeUi;
    UserInformation userInformation;

    public ReturningBook(DataStorage dataStorage, UserModeUi userModeUi, UserInformation userInformation) 
    { 
        this.dataStorage = dataStorage;
        this.userModeUi = userModeUi;
        this.userInformation = userInformation;
    }
	public void ReturnBook()
	{
        while (true)
        {
            string bookId;
            int sameIndex = -1;
            ConsoleKeyInfo inputKey;

            userModeUi.PrintReturningBook();

            for (int i = 0; i < userInformation.borrowBookList.Count; i++)
            {
                userModeUi.PrintShouldReturningList(userInformation.borrowBookList[i]);
            }

            Console.SetCursorPosition(36, 3);
            bookId = Console.ReadLine();



            for (int i = 0; i < dataStorage.bookList.Count; i++)
            {
                if (dataStorage.bookList[i].bookId == int.Parse(bookId))
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
                dataStorage.bookList[sameIndex].bookQuantity += 1;

                for (int i = 0; i < dataStorage.userList.Count; i++)
                {
                    if (userInformation.userNumber == dataStorage.userList[i].userNumber)
                    {
                        dataStorage.userList[i].returnBookList.Add(dataStorage.bookList[sameIndex]);
                    }
                }
            }

            inputKey = Console.ReadKey();

            if (inputKey.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                continue;
            }
            else if (inputKey.Key == ConsoleKey.Escape)
            {
                Console.Clear();
                break;
            }
            else
            {
                Console.Clear();
                break;
            }
        }
    }
}
