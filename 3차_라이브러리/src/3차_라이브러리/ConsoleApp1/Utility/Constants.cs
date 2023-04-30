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
}
    