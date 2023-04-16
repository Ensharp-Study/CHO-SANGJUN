using System;

public class BorrowingBook
{
    DataStorage dataStorage;
    UserModeUi userModeUi;
    CommonFunctionUi commonFunctionUi;
    UserInformation userInformation;

    public BorrowingBook(DataStorage dataStorage, UserModeUi userModeUi, CommonFunctionUi commonFunctionUi, UserInformation userInformation) 
    { 
        this.dataStorage = dataStorage;
        this.userModeUi = userModeUi;
        this.commonFunctionUi = commonFunctionUi;
        this.userInformation = userInformation;
    }

	public void BorrowBook()
	{

        while (true)
        {
            string bookId;
            int sameIndex = -1;
            ConsoleKeyInfo inputKey;

            Console.Clear();
            userModeUi.PrintBorrowingBookMenu();//책 빌리기 메뉴 출력
            for (int i = 0; i < dataStorage.bookList.Count; i++)
            {
                commonFunctionUi.PrintBookList(dataStorage.bookList[i], i);
            }
            Console.SetCursorPosition(36, 3);
            bookId = Console.ReadLine();

            for (int i = 0; i < dataStorage.bookList.Count; i++)
            { //책 id와 저장된 책 리스트 비교
                if (dataStorage.bookList[i].bookId == int.Parse(bookId))
                {
                    sameIndex = i;
                    break;
                }
            }

            if (dataStorage.bookList[sameIndex].bookQuantity > 0)   //view쪽으로
            {
                Console.SetCursorPosition(0, 3);
                Console.WriteLine("      책 빌리기 성공!                          ");
                Console.WriteLine("                                               ");
                dataStorage.bookList[sameIndex].bookQuantity -= 1;
                for (int i = 0; i < dataStorage.userList.Count; i++)
                {
                    if (userInformation.userNumber == dataStorage.userList[i].userNumber)
                    {
                        dataStorage.userList[i].borrowBookList.Add(dataStorage.bookList[sameIndex]);
                        break;
                    }
                }
            }
            else if (dataStorage.bookList[sameIndex].bookQuantity == 0)
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
