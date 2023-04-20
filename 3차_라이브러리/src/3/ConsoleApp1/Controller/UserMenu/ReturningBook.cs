﻿using System;
using System.Net;

public class ReturningBook //책 반납하기
{
    DataStorage dataStorage;
    UserModeUi userModeUi;
    UserInformation userInformation;
    ProgramProcess programProcess;
    BookInformationException bookInformationException;

    public ReturningBook(DataStorage dataStorage, UserModeUi userModeUi, UserInformation userInformation, ProgramProcess programProcess, BookInformationException bookInformationException) 
    { 
        this.dataStorage = dataStorage;
        this.userModeUi = userModeUi;
        this.userInformation = userInformation;
        this.programProcess = programProcess;
        this.bookInformationException = bookInformationException;
    }

    bool isJudgingCorrectString;
    public void ReturnBook()
	{
        while (true)
        {
            string bookId; 
            int sameIndex = -1;

            userModeUi.PrintReturningBook();

            for (int i = 0; i < userInformation.BorrowBookList.Count; i++) //데이터에서 유저가 빌린 책 리스트 가져와 전부 출력
            {
                userModeUi.PrintShouldReturningList(userInformation.BorrowBookList[i]);
            }

            Console.SetCursorPosition(36, 3);
            do // 반납할 책 아이디 입력
            {
                bookId = ToReceiveInput.ReceiveInput(36, 3);
                isJudgingCorrectString = true;
            } while (!isJudgingCorrectString); 
            
            //반납할 책이 도서 정보에 있는지 탐색
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
            else //반납할 책이 도서리스트에 있는 경우
            {
                Console.SetCursorPosition(0, 3);
                Console.WriteLine("      책 반납 성공!                          ");
                Console.WriteLine("                                               ");
                dataStorage.bookList[sameIndex].BookQuantity += 1; //도서 수량 하나 늘리기

                for (int i = 0; i < dataStorage.userList.Count; i++)
                {
                    if (userInformation.UserNumber == dataStorage.userList[i].UserNumber)
                    {
                        dataStorage.userList[i].ReturnBookList.Add(dataStorage.bookList[sameIndex]); //유저의 반납도서 리스트에 추가
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
