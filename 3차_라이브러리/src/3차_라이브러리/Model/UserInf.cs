using System;
using System.Collections.Generic;

public class UserInf
{
    public string id { get; set; }
    public string password { get; set; }
    public int userNumber { get; set; }
    public string userName { get; set; }
    public string userAddress { get; set; }
    public int userAge { get; set; }
    public string userPhoneNumber { get; set; }

    public List<BookInf> borrowBookList { get ; set; }
    
    public List<BookInf> returnBookList { get; set; }
   
    public UserInf()
    {
        borrowBookList = new List<BookInf>(); // string 대신에 BookInf 활용 하기
        returnBookList = new List<BookInf>();
    }
}
