using System;

public class SelectingSignInOrSignUp // 따로 클래스 뺄 필요 없다
{
    Ui ui;
    MagicNumber magicNumber;
    Data data;
    ExceptionHandling exceptionHandling;

    public SelectingSignInOrSignUp(Ui ui, MagicNumber magicNumber, Data data, ExceptionHandling exceptionHandling)
    {
        this.ui = ui;
        this.magicNumber=magicNumber;
        this.data = data;
        this.exceptionHandling = exceptionHandling;
    }

    public void SelectSignOrSignUp() //생성자에서 인스턴스 만들기
    {
                                                                           
            ui.ViewMainMenu();
            int judgementLoginOrSignUP;//밖으로 빼기
            judgementLoginOrSignUP = ui.PrintLoginOrSignUpMenu(magicNumber);

            if (judgementLoginOrSignUP == magicNumber.LOGIN)
            {
                UserLogin login = new UserLogin(ui,  magicNumber,  data,  exceptionHandling); // 인스턴스 계속 생성 막기
                login.GetUserLogin();
                return;
            }
            else if (judgementLoginOrSignUP == magicNumber.SIGNUP)
            {
                SignUp signUp = new SignUp(ui, magicNumber, data, exceptionHandling); // 인스턴스
                signUp.SignUpAccount();
                Console.Clear();
            }
    }
    
}

