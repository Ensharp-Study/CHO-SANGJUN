using System;
using System.Linq.Expressions;

enum ModeNumber
{
    USER_MODE,
    ADMIN_MODE
}
enum UserMenuNumber
{
    //유저 모드 메뉴 번호 할당
    BOOK_FINDER,
    BORROWING_BOOK,
    BOOK_BORROW_LIST,
    RETURNING_BOOK,
    BOOK_RETURN_LIST,
    EDIT_USER_INF,
    DELETE_USER_INFORMATION
}
enum AdministratorMenuNumber
{
    //관리자 모드 메뉴 번호 할당
    BOOK_FINDER,
    ADDING_BOOK,
    DELETING_BOOK,
    EDITING_BOOK,
    MEMBER_MANAGER,
    BOOK_BORROWING_STATUS
}
enum LoginOrSignUpNumber
{
    LOGIN,
    SIGN_UP
}

enum UserManagementNumber
{
    DELETEING_USER,
    SAVING_USER
}

public class Constants
{
    public const int ESC = 10;

    public const bool IS_PASSWORD = true;  //입력값 마스킹 처리 여부 판별용 상수
    public const bool IS_NOT_PASSWORD = false;

    public const bool IS_PRINT_NEXT_LINE = true; //상하, 좌우키 메뉴 출력 함수 구분용 상수
    public const bool IS_PRINT_NEXT_SIDE = false;
}
    