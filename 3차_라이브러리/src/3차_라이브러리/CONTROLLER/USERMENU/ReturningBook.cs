using System;
using System.Net;

public class ReturningBook
{
	public void ReturnBook(Data data,Ui ui,UserInf user)
	{
        string bookId;
        int sameIndex = -1;

        ui.PrintReturningBook();

        for (int i = 0; i < data.bookList.Count; i++)
        {
            ui.PrintBookList(data, i);
        }
        Console.SetCursorPosition(36, 3);
        bookId = Console.ReadLine();



        for (int i = 0; i < data.bookList.Count; i++)
        {
            if (data.bookList[i].bookId == int.Parse(bookId))
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
            data.bookList[sameIndex].bookQuantity += 1;
            user.returnBookList.Add(data.bookList[sameIndex].bookName);
        }
  
    }
}
