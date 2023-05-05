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

    public const bool IS_CANCELLATION_OF_MEMBERSHIP = true; //user모드에서 회원탈퇴 성공시 로그인 메뉴로 돌아가기 위한 불리언 변수
    public const bool IS_NOT_CANCELLATION_OF_MEMBERSHIP = false;

    public const string BOOK_NAME_REGULAR_EXPRESSION = @"^[A-Za-z가-힣0-9?!+=]{1,15}$"; //책이름
    public const string BOOK_AUTHOR_REGULAR_EXPRESSION = @"^[A-Za-z가-힣]{1,15}$"; //저자
    public const string BOOK_PUBLISHER_REGULAR_EXPRESSION = @"^[A-Za-z가-힣0-9]{1,15}$"; //출판사
    public const string BOOK_QUANTITY_REGULAR_EXPRESSION = @"^[0-9]{1,3}$"; //수량
    public const string BOOK_PRICE_REGULAR_EXPRESSION = @"^[1-9]\d{0,6}$"; // 책 가격
    public const string BOOK_PUBLISH_DATE_REGULAR_EXPRESSION = @"^(19\d{2}|20\d{2})-(0[1-9]|1[0-2])-(0[1-9]|[12][0-9]|3[01])$"; //출판일시
    public const string BOOK_ISBN_REGULAR_EXPRESSION = @"^(\d{3}-\d{2}-\d{6}-\d-\d)$"; //ISBN
    public const string BOOK_INFORMATION_REGULAR_EXPRESSION = @"^[A-Za-z가-힣]+$"; // 책 정보

    public const string BOOK_NAME_ERROR_MESSAGE = "한영문자 또는 숫자 또는 ?!+= 1개 이상 15개 이하로 작성 하세요!";
    public const string BOOK_AUTHOR_ERROR_MESSAGE = "한영문자 1개 이상 15개 이하로 작성 하세요!"; //저자
    public const string BOOK_PUBLISHER_ERROR_MESSAGE = "한영문자 또는 숫자 1개 이상 15개 이하로 작성 하세요!"; //출판사
    public const string BOOK_QUANTITY_ERROR_MESSAGE = "0~999 사이의 정수를 입력해 주세요!"; //수량
    public const string BOOK_PRICE_ERROR_MESSAGE = "1~999999 사이의 정수를 입력해 주세요!"; // 책 가격
    public const string BOOK_PUBLISH_DATE_ERROR_MESSAGE = "19xx or 20xx-xx-xx 를 입력해 주세요!"; //출판일시
    public const string BOOK_ISBN_ERROR_MESSAGE = "국제 표준 ISBN 형식 xxx-xx-xxxxxx-x-x 를 입력해 주세요!"; //ISBN
    public const string BOOK_INFORMATION_ERROR_MESSAGE = "최소 1개의 문자를 입력해 주세요!"; // 책 정보

    public const string USER_ID_REGULAR_EXPRESSION = @"^[a-zA-Z0-9]{8,15}$"; //ID
    public const string USER_PASSWORD_REGULAR_EXPRESSION = @"^[a-zA-Z0-9]{8,15}$"; // PASSWORD
    public const string USER_NAME_REGULAR_EXPRESSION = @"[ㄱ-ㅎ가-힣a-zA-Z]+"; //이름
    public const string USER_AGE_REGULAR_EXPRESSION = @"^(0|[1-9]\d?|1\d{2}|200)$"; // 나이
    public const string USER_NUMBER_REGULAR_EXPRESSION = @"01{1}[016789]{1}-[0-9]{3,4}-[0-9]{4}"; //휴대폰 번호

    public const string USER_ID_ERROR_MESSAGE = "숫자 + 영어 8~15글자를 입력해 주세요!"; //ID
    public const string USER_PASSWORD_ERROR_MESSAGE = "숫자 + 영어 8~15글자를 입력해 주세요!"; // PASSWORD
    public const string USER_NAME_ERROR_MESSAGE = "한글,영어포함 1글자 이상 입력해 주세요!"; // 이름
    public const string USER_AGE_ERROR_MESSAGE = "0또는 1부터 200사이의 자연수를 입력해 주세요!"; // 나이
    public const string USER_NUMBER_ERROR_MESSAGE = "01x-xxxx-xxxx 형식으로 입력해 주세요!"; //휴대폰 번호

    public const string NUMBER_REGULAR_EXPRESSION = @"^\d+$"; //숫자인지 판단하는 정규표현식
    public const string NUMBER_ERROR_MESSAGE = "숫자를 입력해 주세요!";
}
    