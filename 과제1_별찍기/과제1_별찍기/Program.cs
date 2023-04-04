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

    class WrongInput
    {
        public static void WrongMemuNumber()
        {
            Console.WriteLine("잘못된 입력입니다. 다시 입력하세요.");
            Program.Main();
        }
        public static void WrongEndOrAgainNumber()
        {
            Console.WriteLine("잘못된 입력입니다. 다시 입력하세요.");
            EndProgram.EndOrAgain();
        }

    }

    class SelectShape
    {

        public static void TypeOfShape(int number)
        {
            if (number == 1)
            {
                StarPrint.Pyramid();
            }

            else if (number == 2)
            {
                StarPrint.InvertedPyramid();
            }

            else if (number == 3)
            {
                StarPrint.Hourglass();
            }
            else if (number == 4)
            {
                StarPrint.Rhombus();
            }
            EndProgram.EndOrAgain();
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