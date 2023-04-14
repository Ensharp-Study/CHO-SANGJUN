using System;

public class SelectingSignInOrSignUp // 따로 클래스 뺄 필요 없다
{
    public void SelectSignOrSignUp(Ui ui, MagicNumber magicNumber, Data data) //생성자에서 인스턴스 만들기
    {
       
            
            ui.ViewMainMenu();
            int judgementLoginOrSignUP;//밖으로 빼기
            judgementLoginOrSignUP = ui.PrintLoginOrSignUpMenu(magicNumber);

            if (judgementLoginOrSignUP == magicNumber.LOGIN)
            {
                UserLogin login = new UserLogin(); // 인스턴스 계속 생성 막기
                login.GetUserLogin(ui, magicNumber, data);
                return;
            }
            else if (judgementLoginOrSignUP == magicNumber.SIGNUP)
            {
                SignUp signUp = new SignUp(); // 인스턴스
                signUp.SignUpAccount(ui, magicNumber, data);
                Console.Clear();
            }
    }
    
}

