using System;

public class SelectingSignInOrSignUp
{
    Data data = new Data();
    public void SelectSignOrSignUp(Ui ui, MagicNumber magicNumber)
	{
        int judgementLoginOrSignUP;
        judgementLoginOrSignUP = ui.PrintLoginOrSignUpMenu(magicNumber);

        if (judgementLoginOrSignUP == magicNumber.LOGIN)
        {
            Login login = new Login();
            login.GetLogin(ui, magicNumber,data);
        }
        else if(judgementLoginOrSignUP == magicNumber.SIGNUP)
        {
            SignUp signUp = new SignUp();
            signUp.SignUpAccount(ui,magicNumber,data);
        }
    }
}
