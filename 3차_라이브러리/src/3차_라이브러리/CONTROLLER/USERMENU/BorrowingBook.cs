﻿using System;

public class BorrowingBook
{
    Data data;
    Ui ui;
    MagicNumber magicNumber;
    UserInf user;

    public BorrowingBook(Data data, Ui ui,MagicNumber magicNumber,UserInf user) 
    { 
        this.data = data;
        this.ui = ui;
        this.magicNumber = magicNumber;
        this.user = user;
    }

	public void BorrowBook()
	{

        while (true)
        {
            string bookId;
            int sameIndex = -1;
            ConsoleKeyInfo inputKey;

            Console.Clear();
            ui.PrintBorrowingBookMenu();//책 빌리기 메뉴 출력
            for (int i = 0; i < data.bookList.Count; i++)
            {
                ui.PrintBookList(data, i);
            }
            Console.SetCursorPosition(36, 3);
            bookId = Console.ReadLine();

            for (int i = 0; i < data.bookList.Count; i++)
            { //책 id와 저장된 책 리스트 비교
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
                data.bookList[sameIndex].bookQuantity -= 1;
                for (int i = 0; i < data.userList.Count; i++)
                {
                    if (user.userNumber == data.userList[i].userNumber)
                    {
                        data.userList[i].borrowBookList.Add(data.bookList[sameIndex]);
                    }
                    break;
                }
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
