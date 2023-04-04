using System;

namespace Starpoint
{
    class ChooseMenu
    {

        public static void InputMenuNumber()
        {
            Console.Write("Menu : 번호를 입력하세요: ");
            string number = Console.ReadLine();
            Console.Clear();
            if ((int.Parse(number) != 1) && (int.Parse(number) != 2) && (int.Parse(number) != 3) && (int.Parse(number) != 4))
            {
                WrongInput.WrongMemuNumber();
            }
            SelectShape.TypeOfShape(int.Parse(number));

        }

    }


    class Program
    {
        public static void Main()
        {
            ChooseMenu.InputMenuNumber();
        }
    }

}