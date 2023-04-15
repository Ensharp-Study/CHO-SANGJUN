using System;
public class CommonFunctionUi
{
    public void ViewMenu()
    {
        Console.SetCursorPosition(0, 21);
        Console.WriteLine("                       _________________________________________________________________                       ");
        Console.WriteLine("                       |                                                               |                       ");
        Console.WriteLine("                       |                          메 뉴 선 택                          |                       ");
        Console.WriteLine("                       |                                                               |                       ");
        Console.WriteLine("                       |                                                               |                       ");
        Console.WriteLine("                       |                                                               |                       ");
        Console.WriteLine("                       |                                                               |                       ");
        Console.WriteLine("                       |                                                               |                       ");
        Console.WriteLine("                       |                                                               |                       ");
        Console.WriteLine("                       |                                                               |                       ");
        Console.WriteLine("                       |                                                               |                       ");
        Console.WriteLine("                       |                                                               |                       ");
        Console.WriteLine("                       |                                                               |                       ");
        Console.WriteLine("                       |                                                               |                       ");
        Console.WriteLine("                       -----------------------------------------------------------------                       ");
    }

    public void PrintBookFinderMenu()
    {
        Console.WriteLine("============================================================");
        Console.WriteLine(" 제목으로 찾기:");
        Console.WriteLine(" 작가명으로 찾기:");
        Console.WriteLine(" 출판사로 찾기:");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("ESC  :  뒤로가기");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("ENTER  :  입력하기");
        Console.ResetColor();
        Console.WriteLine("건너뛰고자 하는 항목은 ENTER을 눌러주세요");
        Console.WriteLine("============================================================");
    }
    public void PrintBookList(DataStorage dataStorage, int indexI)
    {
        Console.WriteLine("책아이디  :  {0}", dataStorage.bookList[indexI].bookId);
        Console.WriteLine("책 제목   :  " + dataStorage.bookList[indexI].bookName);
        Console.WriteLine("작가      :  " + dataStorage.bookList[indexI].bookAuthor);
        Console.WriteLine("출판사    :  " + dataStorage.bookList[indexI].bookPublisher);
        Console.WriteLine("수량      :  {0}", dataStorage.bookList[indexI].bookQuantity);
        Console.WriteLine("가격      :  {0}", dataStorage.bookList[indexI].bookPrice);
        Console.WriteLine("출시일    :  " + dataStorage.bookList[indexI].bookPublicationDate);
        Console.WriteLine("ISBN      :  " + dataStorage.bookList[indexI].isbn);
        Console.WriteLine("책 정보   :  " + dataStorage.bookList[indexI].bookInf);
        Console.WriteLine("============================================================");
    }
}

