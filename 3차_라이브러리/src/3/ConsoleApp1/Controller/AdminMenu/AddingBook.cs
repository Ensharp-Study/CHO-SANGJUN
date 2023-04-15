using System;

public class AddingBook
{
    DataStorage dataStorage;
    Ui ui;

    public AddingBook(DataStorage dataStorage, Ui ui) { 
    
        this.dataStorage = dataStorage;
        this.ui = ui;
    }

	public void AddNewBook() //새로운 책 추가하기
	{
        while (true)
        {
            ConsoleKeyInfo inputKey;
            ui.PrintAddingBookMenu();  // 책 추가 메뉴 인터페이스 출력
            BookInf bookInf = new BookInf(); //새로운 책 정보 담을 인스턴스 생성

            Console.SetCursorPosition(29, 11);
            bookInf.bookName = Console.ReadLine();
            Console.SetCursorPosition(29, 12);
            bookInf.bookAuthor = Console.ReadLine();
            Console.SetCursorPosition(29, 13);
            bookInf.bookPublisher = Console.ReadLine();
            Console.SetCursorPosition(29, 14);
            bookInf.bookQuantity = int.Parse(Console.ReadLine());
            Console.SetCursorPosition(29, 15);
            bookInf.bookPrice = int.Parse(Console.ReadLine());
            Console.SetCursorPosition(29, 16);
            bookInf.bookPublicationDate = Console.ReadLine();
            Console.SetCursorPosition(29, 17);
            bookInf.isbn = Console.ReadLine();
            Console.SetCursorPosition(29, 18);
            bookInf.bookInf = Console.ReadLine();
            dataStorage.bookList.Add(bookInf);
            Console.Clear();

            ui.PrintAddingBookSuccessSentence(); //책 추가 완료 인터페이스 출력

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
