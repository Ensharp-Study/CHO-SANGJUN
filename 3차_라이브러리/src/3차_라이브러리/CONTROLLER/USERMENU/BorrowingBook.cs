using System;

public class BorrowingBook
{
	public void BorrowBook(Data data, Ui ui,MagicNumber magicNumber, UserInf user)
	{
		string bookId;
		int sameIndex = -1;

		ui.PrintBorrowingBook();
		for (int i = 0; i < data.bookList.Count; i++) {
			ui.PrintBookList(data,i); 
		}
        Console.SetCursorPosition(36,3);
		bookId = Console.ReadLine();



		for (int i = 0; i < data.bookList.Count; i++) {
			if (data.bookList[i].bookId == int.Parse(bookId))
			{
				sameIndex = i;
				break;
            }

		}
		
        if (data.bookList[sameIndex].bookQuantity > 0)   //view쪽으로
        {
            Console.SetCursorPosition(0, 3);
            Console.WriteLine("      책 빌리기 성공!                          ");
            Console.WriteLine("                                               ");
            data.bookList[sameIndex].bookQuantity -=1;
            user.borrowBookList.Add(data.bookList[sameIndex].bookName);
        }
        else if (data.bookList[sameIndex].bookQuantity == 0)
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



    }
}
