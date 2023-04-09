using System;
using System.Collections.Generic;

public class Data
{
	public UserInf administratorInf;
    public List<UserInf> userList;
    public List<BookInf> bookList;

	
	public Data() // data 인스턴스 생성됨과 동시에 기본 초기값 초기화
	{
        administratorInf = new UserInf();    //관리자 정보
        administratorInf.id = "juncho1201";
        administratorInf.password = "juncho1201";
        administratorInf.userNumber = 0;
        administratorInf.userName = "조상준";
        administratorInf.userAddress = "서울시 마포구 큰우물로";
        administratorInf.userAge = 24;
        administratorInf.userPhoneNumber = "010-4228-4873";

        userList = new List<UserInf>();	 //회원 1명에 대한 정보
        UserInf userInf = new UserInf();

        userInf.id = "abcde";
        userInf.password = "password";
        userInf.userNumber = 1;
        userInf.userName = "김기욱";
        userInf.userAddress = "서울시 서대문구";
        userInf.userAge = 24;
        userInf.userPhoneNumber = "010-4123-4567";
        userList.Add(userInf);

        bookList = new List<BookInf>(); //책 1권에 대한 정보
        BookInf bookInf = new BookInf();

        bookInf.bookId = 1;
        bookInf.bookName = "C# 프로그래밍";
        bookInf.bookAuthor = "윤인성";
        bookInf.bookPublisher = "한빛 아카데미";
        bookInf.bookQuantity = 1;
        bookInf.bookPrice = 25000;
        bookInf.bookPublicationDate = "2015-12-01";
        bookInf.isbn = "9791156642046";
        bookInf.bookInf = "다양한 예제와 단계별 학습으로 배우는 C# 프로그래밍의 기본";
        bookList.Add(bookInf);

    }

    
    

}
