using System;

public class BookInformation //프로퍼티 문법으로 보안된 변수 접근
{
    private int bookId;
    public int BookId
    {
        get { return bookId; }
        set { bookId = value; }
    }

    private string bookName;
    public string BookName
    {
        get { return bookName; }
        set { bookName = value; }
    }

    private string bookAuthor;
    public string BookAuthor
    {
        get { return bookAuthor; }
        set { bookAuthor = value; }
    }

    private string bookPublisher;
    public string BookPublisher
    {
        get { return bookPublisher; }
        set { bookPublisher = value; }
    }

    private int bookQuantity;
    public int BookQuantity
    {
        get { return bookQuantity; }
        set { bookQuantity = value; }
    }

    private int bookPrice;
    public int BookPrice
    {
        get { return bookPrice; }
        set { bookPrice = value; }
    }

    private string bookPublicationDate;
    public string BookPublicationDate
    {
        get { return bookPublicationDate; }
        set { bookPublicationDate = value; }
    }

    private string isbn;
    public string Isbn
    {
        get { return isbn; }
        set { isbn = value; }
    }

    private string bookDescription;
    public string BookDescription
    {
        get { return bookDescription; }
        set { bookDescription = value; }
    }

    private string borrowTime;
    public string BorrowTime
    {
        get { return borrowTime; }
        set { borrowTime = value; }
    }

    private string returnTime;
    public string ReturnTime
    {
        get { return returnTime; }
        set { returnTime = value; }
    }


}
