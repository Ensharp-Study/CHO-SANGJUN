using System;

public class SelectingSignInOrSignUp // 따로 클래스 뺄 필요 없다
{
    Ui ui;
    DataStorage dataStorage;
    ExceptionHandling exceptionHandling;

    public SelectingSignInOrSignUp(Ui ui, DataStorage dataStorage, ExceptionHandling exceptionHandling)
    {
        this.ui = ui;
        this.dataStorage = dataStorage;
        this.exceptionHandling = exceptionHandling;
    }

    public void SelectSignOrSignUp() //생성자에서 인스턴스 만들기
    {
                                                                           
            ui.ViewMainMenu();
            int judgementLoginOrSignUP;//밖으로 빼기
            judgementLoginOrSignUP = ui.PrintLoginOrSignUpMenu();

            if (judgementLoginOrSignUP == Constants.LOGIN)
            {
                UserLogin login = new UserLogin(ui,  dataStorage,  exceptionHandling); // 인스턴스 계속 생성 막기
                login.GetUserLogin();
                return;
            }
            else if (judgementLoginOrSignUP == Constants.SIGN_UP)
            {
                SignUp signUp = new SignUp(ui, dataStorage, exceptionHandling); // 인스턴스
                signUp.SignUpAccount();
                Console.Clear();
            }
    }
    
}

