using System;
using System.Collections.Generic;

public class UserDTO
{
    public UserDTO() //생성자
    {
        borrowBookList = new List<BookDTO>();
        returnBookList = new List<BookDTO>();
    }
    private string id;
    private string password;
    private int userNumber;
    private string userName;
    private string userAddress;
    private int userAge;
    private string userPhoneNumber;
    private List<BookDTO> borrowBookList; // 사용 필요 없어짐
    private List<BookDTO> returnBookList; 


    public string Id
    {
        get { return id; }
        set { id = value; }
    }

    public string Password
    {
        get { return password; }
        set { password = value; }
    }

    public int UserNumber
    {
        get { return userNumber; }
        set { userNumber = value; }
    }

    public string UserName
    {
        get { return userName; }
        set { userName = value; }
    }
    public string UserAddress
    {
        get { return userAddress; }
        set { userAddress = value; }
    }
    public int UserAge
    {
        get { return userAge; }
        set { userAge = value; }
    }
    public string UserPhoneNumber
    {
        get { return userPhoneNumber; }
        set { userPhoneNumber = value; }
    }

    public List<BookDTO> BorrowBookList
    {
        get { return borrowBookList; }
    }

    public List<BookDTO> ReturnBookList
    {
        get { return returnBookList; }
    }
}
