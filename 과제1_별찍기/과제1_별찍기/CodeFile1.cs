using System;

namespace Starpoint
{
    class ChooseMenu
    {

        public static void InputMenuNumber()
        {
            Console.WriteLine("+------------------<MENU>------------------+");
            Console.WriteLine("|              1. 피라미드                 |");
            Console.WriteLine("|              2.역피라미드                |");
            Console.WriteLine("|              3. 모래시계                 |");
            Console.WriteLine("|              4. 마름모                   |");
            Console.WriteLine("+------------------------------------------+");
            Console.Write("[Menu] 번호를 입력하세요: ");
            string number = Console.ReadLine();
            Console.Clear();
            if ((int.Parse(number) != 1) && (int.Parse(number) != 2) && (int.Parse(number) != 3) && (int.Parse(number) != 4))
            {
                WrongInput.WrongMemuNumber();
            }
            SelectShape.TypeOfShape(int.Parse(number));

        }

    }

    class Enternumber
    {
        public static int InputLineNumber()
        {
            Console.Write("줄 갯수를 입력하세요: ");
            string number = Console.ReadLine();
            int convertednumber = int.Parse(number);
            Console.Clear();
            return convertednumber;


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
    class EndProgram
    {
        public static void EndOrAgain()
        {
            int selectendoragain;

            Console.WriteLine();
            Console.WriteLine("-----------------------");
            Console.WriteLine("     메뉴로 돌아가기   ");
            Console.WriteLine("      1: 다시하기      ");
            Console.WriteLine("      2: 종료하기      ");
            Console.WriteLine("-----------------------");
            selectendoragain = int.Parse(Console.ReadLine());

            if (selectendoragain == 1)
            {
                Console.Clear();
                Program.Main();
            }
            else if (selectendoragain == 2)
            {
                return;
            }
            else
            {
                WrongInput.WrongEndOrAgainNumber();
                return;
            }

        }
    }

    class StarPrint
    {
        public static void Pyramid()
        {
            int i, j;
            int linenumber = Enternumber.InputLineNumber();

            for (i = 0; i < linenumber; i++)
            {
                for (j = 0; j < ((2 * linenumber - 1) - (2 * i + 1)) / 2; j++)
                {
                    Console.Write(" ");
                }
                for (j = 0; j < (2 * i + 1); j++)
                {
                    Console.Write("*");
                }
                for (j = 0; j < ((2 * linenumber - 1) - (2 * i + 1)) / 2; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        public static void InvertedPyramid()
        {
            int i, j;
            int linenumber = Enternumber.InputLineNumber();

            for (i = 0; i < linenumber; i++)
            {
                for (j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 0; j < ((2 * linenumber - 1) - 2 * i); j++)
                {
                    Console.Write("*");
                }
                for (j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        public static void Hourglass()
        {
            int i, j;
            int linenumber = Enternumber.InputLineNumber();

            if (linenumber % 2 == 0)
            {
                linenumber /= 2;
                for (i = 0; i < linenumber; i++)
                {
                    for (j = 0; j < i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (j = 0; j < ((2 * linenumber - 1) - 2 * i); j++)
                    {
                        Console.Write("*");
                    }
                    for (j = 0; j < i; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }

                for (i = 0; i < linenumber; i++)
                {
                    for (j = 0; j < ((2 * linenumber - 1) - (2 * i + 1)) / 2; j++)
                    {
                        Console.Write(" ");
                    }
                    for (j = 0; j < (2 * i + 1); j++)
                    {
                        Console.Write("*");
                    }
                    for (j = 0; j < ((2 * linenumber - 1) - (2 * i + 1)) / 2; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }

            else
            {
                linenumber = linenumber / 2 + 1;
                for (i = 0; i < linenumber; i++)
                {
                    for (j = 0; j < i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (j = 0; j < ((2 * linenumber - 1) - 2 * i); j++)
                    {
                        Console.Write("*");
                    }
                    for (j = 0; j < i; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }

                for (i = 1; i < linenumber; i++)
                {
                    for (j = 0; j < ((2 * linenumber - 1) - (2 * i + 1)) / 2; j++)
                    {
                        Console.Write(" ");
                    }
                    for (j = 0; j < (2 * i + 1); j++)
                    {
                        Console.Write("*");
                    }
                    for (j = 0; j < ((2 * linenumber - 1) - (2 * i + 1)) / 2; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }

        }

        public static void Rhombus()
        {
            int i, j;
            int linenumber = Enternumber.InputLineNumber();

            if (linenumber % 2 == 0)
            {
                linenumber /= 2;

                for (i = 0; i < linenumber; i++)
                {
                    for (j = 0; j < ((2 * linenumber - 1) - (2 * i + 1)) / 2; j++)
                    {
                        Console.Write(" ");
                    }
                    for (j = 0; j < (2 * i + 1); j++)
                    {
                        Console.Write("*");
                    }
                    for (j = 0; j < ((2 * linenumber - 1) - (2 * i + 1)) / 2; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }

                for (i = 0; i < linenumber; i++)
                {
                    for (j = 0; j < i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (j = 0; j < ((2 * linenumber - 1) - 2 * i); j++)
                    {
                        Console.Write("*");
                    }
                    for (j = 0; j < i; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }

            else
            {
                linenumber = linenumber / 2 + 1;

                for (i = 0; i < linenumber; i++)
                {
                    for (j = 0; j < ((2 * linenumber - 1) - (2 * i + 1)) / 2; j++)
                    {
                        Console.Write(" ");
                    }
                    for (j = 0; j < (2 * i + 1); j++)
                    {
                        Console.Write("*");
                    }
                    for (j = 0; j < ((2 * linenumber - 1) - (2 * i + 1)) / 2; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }

                for (i = 1; i < linenumber; i++)
                {
                    for (j = 0; j < i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (j = 0; j < ((2 * linenumber - 1) - 2 * i); j++)
                    {
                        Console.Write("*");
                    }
                    for (j = 0; j < i; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }

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