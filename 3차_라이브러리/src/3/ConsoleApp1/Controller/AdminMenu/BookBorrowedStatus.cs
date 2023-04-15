using System;

public class BookBorrowedStatus
{
    ConsoleKeyInfo inputKey;
    DataStorage dataStorage;
    AdministratorModeUi administratorModeUi;

    public BookBorrowedStatus(DataStorage dataStorage, AdministratorModeUi administratorModeUi)
    {
        this.dataStorage = dataStorage;
        this.administratorModeUi = administratorModeUi;
    }

    public void CheckBookBorrowedList() //빌린 책 출력하는 함수
    {
        while (true)
        {
            administratorModeUi.PrintBookBorrowedMenu(); //빌린 책 출력하는 함수 인터페이스 출력 

            for (int i = 0; i < dataStorage.userList.Count; i++) //모든 유저정보 for문으로 접근
            {
                administratorModeUi.PrintUserName(dataStorage.userList[i].userName); //유저 이름 출력 인터페이스
                for (int j = 0; j < dataStorage.userList[i].borrowBookList.Count; j++) //유저정보 내 빌린책 리스트 접근
                {
                    administratorModeUi.PrintUserBorrowedBookList(dataStorage, i, j); //빌린책 리스트 출력
                }
            }

            inputKey = Console.ReadKey();
            if (inputKey.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                break;
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
    

