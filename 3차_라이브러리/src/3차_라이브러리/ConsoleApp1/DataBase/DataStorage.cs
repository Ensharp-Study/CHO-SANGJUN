using System;
using System.Collections.Generic;

public class DataStorage // 모델에 있으면 안됨 //데이터 명 정확하게
{
	public UserDTO administratorInformation;
    public List<UserDTO> userList;
    public List<BookDTO> bookList;

	
	public DataStorage() // dataStorage 인스턴스 생성됨과 동시에 기본 초기값 초기화
	{
        administratorInformation = new UserDTO();    //관리자 정보
        administratorInformation.Id = "juncho1201";
        administratorInformation.Password = "juncho1201";
        administratorInformation.UserNumber = 0;
        administratorInformation.UserName = "조상준";
        administratorInformation.UserAddress = "서울시 마포구 큰우물로";
        administratorInformation.UserAge = 24;
        administratorInformation.UserPhoneNumber = "010-4228-4873";

        userList = new List<UserDTO>();	 //회원 1명에 대한 정보
        UserDTO userInformation = new UserDTO();

        userInformation.Id = "abcde12345";
        userInformation.Password = "password123";
        userInformation.UserNumber = 1;
        userInformation.UserName = "조상준";
        userInformation.UserAddress = "서울시 서대문구";
        userInformation.UserAge = 24;
        userInformation.UserPhoneNumber = "010-4123-4567";
        userList.Add(userInformation);

        bookList = new List<BookDTO>(); //기존 저장된 책에 대한 정보
        
        BookDTO bookNumber1 = new BookDTO();
        bookNumber1.BookId = 1;
        bookNumber1.BookName = "C# 프로그래밍";
        bookNumber1.BookAuthor = "윤인성";
        bookNumber1.BookPublisher = "한빛 아카데미";
        bookNumber1.BookQuantity = 1;
        bookNumber1.BookPrice = 25000;
        bookNumber1.BookPublicationDate = "2015-12-01";
        bookNumber1.Isbn = "979-11-566420-4-6";
        bookNumber1.BookDescription = "다양한 예제와 단계별 학습으로 배우는 C# 프로그래밍의 기본";
        bookList.Add(bookNumber1);

        BookDTO bookNumber2 = new BookDTO();
        bookNumber2.BookId = 2;
        bookNumber2.BookName = "확률과 랜덤변수 및 랜덤과정";
        bookNumber2.BookAuthor = "송홍엽";
        bookNumber2.BookPublisher = "교보문고";
        bookNumber2.BookQuantity = 1;
        bookNumber2.BookPrice = 32000;
        bookNumber2.BookPublicationDate = "2015-12-01";
        bookNumber2.Isbn = "979-11-232420-4-6";
        bookNumber2.BookDescription = "확률과 랜덤변수 및 랜덤과정의 기초 및 입문서";
        bookList.Add(bookNumber2);

        BookDTO bookNumber3 = new BookDTO();
        bookNumber3.BookId = 3;
        bookNumber3.BookName = "어린왕자";
        bookNumber3.BookAuthor = "앙투안 드 생텍쥐페리";
        bookNumber3.BookPublisher = "마움";
        bookNumber3.BookQuantity = 1;
        bookNumber3.BookPrice = 11250;
        bookNumber3.BookPublicationDate = "2015-12-01";
        bookNumber3.Isbn = "979-11-566000-0-0";
        bookNumber3.BookDescription = "어린왕자 초판본원서 책과 책으로 만나는 한글판";
        bookList.Add(bookNumber3);

    }

    
    

}
