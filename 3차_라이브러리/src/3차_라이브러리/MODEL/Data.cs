using System;
using System.Collections.Generic;

public class Data // 모델에 있으면 안됨 //데이터 명 정확하게
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

        userInf.id = "a";
        userInf.password = "a";
        userInf.userNumber = 1;
        userInf.userName = "조상준";
        userInf.userAddress = "서울시 서대문구";
        userInf.userAge = 24;
        userInf.userPhoneNumber = "010-4123-4567";
        userList.Add(userInf);

        bookList = new List<BookInf>(); //기존 저장된 책에 대한 정보
        
        BookInf bookNumber1 = new BookInf();
        bookNumber1.bookId = 1;
        bookNumber1.bookName = "C# 프로그래밍";
        bookNumber1.bookAuthor = "윤인성";
        bookNumber1.bookPublisher = "한빛 아카데미";
        bookNumber1.bookQuantity = 1;
        bookNumber1.bookPrice = 25000;
        bookNumber1.bookPublicationDate = "2015-12-01";
        bookNumber1.isbn = "9791156642046";
        bookNumber1.bookInf = "다양한 예제와 단계별 학습으로 배우는 C# 프로그래밍의 기본";
        bookList.Add(bookNumber1);

        BookInf bookNumber2 = new BookInf();
        bookNumber2.bookId = 2;
        bookNumber2.bookName = "확률과 랜덤변수 및 랜덤과정";
        bookNumber2.bookAuthor = "송홍엽";
        bookNumber2.bookPublisher = "교보문고";
        bookNumber2.bookQuantity = 1;
        bookNumber2.bookPrice = 32000;
        bookNumber2.bookPublicationDate = "2015-12-01";
        bookNumber2.isbn = "9791123242046";
        bookNumber2.bookInf = "확률과 랜덤변수 및 랜덤과정의 기초 및 입문서";
        bookList.Add(bookNumber2);

        BookInf bookNumber3 = new BookInf();
        bookNumber3.bookId = 3;
        bookNumber3.bookName = "어린왕자";
        bookNumber3.bookAuthor = "앙투안 드 생텍쥐페리";
        bookNumber3.bookPublisher = "마움";
        bookNumber3.bookQuantity = 1;
        bookNumber3.bookPrice = 11250;
        bookNumber3.bookPublicationDate = "2015-12-01";
        bookNumber3.isbn = "9791156600000";
        bookNumber3.bookInf = "어린왕자 초판본원서 책과 책으로 만나는 한글판";
        bookList.Add(bookNumber3);

    }

    
    

}
