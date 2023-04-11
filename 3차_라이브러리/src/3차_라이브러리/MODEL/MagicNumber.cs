using System;

public class MagicNumber //모델에 있으면 안됨 >유틸리티 폴더 만들기
{//클래스면 컨스턴스
	public int USERMODE = 0; //constan
    public int ADMINMODE = 1;

    public int BOOKFINDER = 0;
    public int BORROWINGBOOK = 1;// 매직넘버 관리법 > 인스턴스 없어도 사용 가능
    public int BOOKBORROWLIST = 2;
    public int RETURNINGBOOK = 3;
    public int BOOKRETURNLIST = 4;
    public int EDITUSERINF = 5;
    public int DELETEUSERINF = 6;

    public int LOGIN = 0;
    public int SIGNUP= 1;

    public int DELETEINGUSER= 0;
    public int SAVINGUSER = 1;
}
