using System;

public class SignUp
{
	Ui ui;
	MagicNumber magicNumber;

	public void SignUpAccount(Ui ui, MagicNumber magicNumber, Data data)
	{
		ui.PrintSignUpMenu();
		ui.PrintSignUpInputMenu();

    }
}
