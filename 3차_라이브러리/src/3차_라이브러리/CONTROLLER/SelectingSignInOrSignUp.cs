using System;

public class SelectingSignInOrSignUp // 따로 클래스 뺄 필요 없다
{
    Data data = new Data(); //관리자에서 접근이 안되니까 library  start 쪽에 생성
    public void SelectSignOrSignUp(Ui ui, MagicNumber magicNumber) //생성자에서 인스턴스 만들기
    {
        while (true)
        {
            int judgementLoginOrSignUP;//밖으로 빼기
            judgementLoginOrSignUP = ui.PrintLoginOrSignUpMenu(magicNumber); 

            if (judgementLoginOrSignUP == magicNumber.LOGIN)
            {
                Login login = new Login(); // 인스턴스 계속 생성 막기
                login.GetLogin(ui, magicNumber, data);
            }
            else if (judgementLoginOrSignUP == magicNumber.SIGNUP)
            {
                SignUp signUp = new SignUp(); // 인스턴스
                signUp.SignUpAccount(ui, magicNumber, data);
            }
        }
    }
}
