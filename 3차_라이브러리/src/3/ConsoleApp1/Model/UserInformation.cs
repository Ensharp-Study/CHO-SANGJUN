using System;
using System.Collections.Generic;

public class UserInformation
{
    private string id;
    public string Id
    {
        get { return id; }
        set { id = value; }
    }

    private string password;
    public string Password
    {
        get { return password; }
        set { password = value; }
    }

    private int userNumber;
    public int UserNumber
    {
        get { return userNumber; }
        set { userNumber = value; }
    }
    private string userName;
    public string UserName
    {
        get { return userName; }
        set { userName = value; }
    }
    private string userAddress;
    public string UserAddress
    {
        get { return userAddress; }
        set { userAddress = value; }
    }
    private int userAge;
    public int UserAge
    {
        get { return userAge; }
        set { userAge = value; }
    }
    private string userPhoneNumber;
    public string UserPhoneNumber
    {
        get { return userPhoneNumber; }
        set { userPhoneNumber = value; }
    }

    private List<BookInformation> borrowBookList;
    public List<BookInformation> BorrowBookList
    {
        get { return borrowBookList; }
        set { borrowBookList = value; }
    }

    private List<BookInformation> returnBookList { get; set; }
    public List<BookInformation> ReturnBookList
    {
        get { return returnBookList; }
        set { returnBookList = value; }
    }


    public UserInformation() //생성자
    {
        borrowBookList = new List<BookInformation>(); 
        returnBookList = new List<BookInformation>();
    }
}
