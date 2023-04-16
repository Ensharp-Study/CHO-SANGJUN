using System;
using System.Collections.Generic;

public class DataStorage // 모델에 있으면 안됨 //데이터 명 정확하게
{
	public UserInformation administratorInformation;
    public List<UserInformation> userList;
    public List<BookInformation> bookList;

	
	public DataStorage() // dataStorage 인스턴스 생성됨과 동시에 기본 초기값 초기화
	{
        administratorInformation = new UserInformation();    //관리자 정보
        administratorInformation.id = "juncho1201";
        administratorInformation.password = "juncho1201";
        administratorInformation.userNumber = 0;
        administratorInformation.userName = "조상준";
        administratorInformation.userAddress = "서울시 마포구 큰우물로";
        administratorInformation.userAge = 24;
        administratorInformation.userPhoneNumber = "010-4228-4873";

        userList = new List<UserInformation>();	 //회원 1명에 대한 정보
        UserInformation userInformation = new UserInformation();

        userInformation.id = "abcde12345";
        userInformation.password = "password123";
        userInformation.userNumber = 1;
        userInformation.userName = "조상준";
        userInformation.userAddress = "서울시 서대문구";
        userInformation.userAge = 24;
        userInformation.userPhoneNumber = "010-4123-4567";
        userList.Add(userInformation);

        bookList = new List<BookInformation>(); //기존 저장된 책에 대한 정보
        
        BookInformation bookNumber1 = new BookInformation();
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

        BookInformation bookNumber2 = new BookInformation();
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

        BookInformation bookNumber3 = new BookInformation();
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
