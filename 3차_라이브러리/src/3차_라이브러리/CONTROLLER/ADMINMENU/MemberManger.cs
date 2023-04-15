using System;

public class MemberManger
{
    ConsoleKeyInfo inputKey;
    Data data;
    Ui ui;

    public MemberManger(Data data, Ui ui)
    {
        this.data = data;
        this.ui = ui;
    }

    public void ManageMember()
    {
        while (true)
        {
            string userNumber;

            ui.PrintMemberManagerMenu();
            for (int i = 0; i < data.userList.Count; i++)
            {
                ui.PrintMemberList(data, i);
            }
            Console.SetCursorPosition(70, 2);

            userNumber = Console.ReadLine();

            for (int i = 0; i < data.userList.Count; i++)
            {
                if (int.Parse(userNumber) == data.userList[i].userNumber)
                {
                    data.userList.RemoveAt(i);
                }
            }

            Console.Clear();
            ui.PrintDeletingUserSuccessSentence();
            for (int i = 0; i < data.userList.Count; i++)
            {
                ui.PrintMemberList(data, i);
            }

            inputKey = Console.ReadKey();
            if (inputKey.Key == ConsoleKey.Escape)
            {
                Console.Clear();
                return;
            }

            else if (inputKey.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                continue;
            }
        }
    } 

    
}
