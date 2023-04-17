using System;

public class Constants 
{
	public const int USER_MODE = 0; //constan
    public const int ADMIN_MODE = 1;

    public const int ESC = 10;

    //유저 모드 메뉴 번호 할당
    public const int BOOK_FINDER = 0;
    public const int BORROWING_BOOK = 1;// 매직넘버 관리법 > 인스턴스 없어도 사용 가능
    public const int BOOK_BORROW_LIST = 2;
    public const int RETURNING_BOOK = 3;
    public const int BOOK_RETURN_LIST = 4;
    public const int EDIT_USER_INF = 5;
    public const int DELETE_USER_INFORMATION = 6;
    
    //관리자 모드 메뉴 번호 할당
    public const int ADDING_BOOK = 1;// 매직넘버 관리법 > 인스턴스 없어도 사용 가능
    public const int DELETING_BOOK = 2;
    public const int EDITING_BOOK = 3;
    public const int MEMBER_MANAGER = 4;
    public const int BOOK_BORROWING_STATUS = 5;

    public const int LOGIN = 0;
    public const int SIGN_UP= 1;

    public const int DELETEING_USER= 0;
    public const int SAVING_USER = 1;

    public const int CONTINUE = 0;
    public const int RETURN = 0;

}
