using System;
using System.Security.Policy;

public class DeletingBook
{
    string title;
    string author;
    string publisher;
    string deletedBookIdString;
    int deletedBookIdInt;
    int PrintPossiblity = 0;
    ConsoleKeyInfo inputKey;

    DataStorage dataStorage;
    Ui ui;

    public DeletingBook(DataStorage dataStorage, Ui ui)
    {
        this.dataStorage = dataStorage;
        this.ui = ui;
    }

    public void DeleteABook() //책 삭제하기
    {
        while (true)
        {
            //책 검색하기 기능
            ui.PrintBookFinderMenu(); //책 검색하는 인터페이스

            for (int i = 0; i < dataStorage.bookList.Count; i++) //모든책 리스트 접근
            {
                ui.PrintBookList(dataStorage, i);
            }

            Console.SetCursorPosition(17, 1);  //검색할 책 정보 입력받기
            title = Console.ReadLine();
            Console.SetCursorPosition(19, 2);
            author = Console.ReadLine();
            Console.SetCursorPosition(17, 3);
            publisher = Console.ReadLine();
            Console.WriteLine("\n\n\n");

            Console.Clear();

            ui.PrintDeletingBookMenu(); //삭제 메뉴 및 검색된 책 리스트 출력
            for (int i = 0; i < dataStorage.bookList.Count; i++) 
            {

                if (string.IsNullOrEmpty(title) == false || 
                    string.IsNullOrEmpty(author) == false || 
                    string.IsNullOrEmpty(publisher) == false) // 입력받은 값이 공백인 경우 제외
                {
                    if ((dataStorage.bookList[i].bookName).Contains(title) && 
                        (dataStorage.bookList[i].bookAuthor).Contains(author) &&
                        (dataStorage.bookList[i].bookPublisher).Contains(publisher)) //제목 일치하는지 확인
                    {
                        PrintPossiblity++;
                    }
                }

                if (PrintPossiblity > 0) // 일치하면 출력
                {
                    {
                        ui.PrintBookList(dataStorage, i);
                    }
                    PrintPossiblity = 0;
                }
            }

            //책 삭제하기
            Console.SetCursorPosition(64, 2);
            deletedBookIdString = Console.ReadLine();  //삭제할 책 아이디 입력
            deletedBookIdInt = int.Parse(deletedBookIdString); 
            for (int i = 0; i < dataStorage.bookList.Count; i++) //모든 책 접근
            {
                if (dataStorage.bookList[i].bookId == deletedBookIdInt)
                {
                    dataStorage.bookList.RemoveAt(i);
                    break;
                }
            }
            Console.Clear();
            ui.PrintDeletingBookSuccessSentence();


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
