using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Utility
{
    public class GoBackMenu // 뒤로가기 구현
    {
        //싱글톤
        private static GoBackMenu instance;
        private GoBackMenu() { }
        public static GoBackMenu GetInstance()
        {
            if (instance == null)
            {
                instance = new GoBackMenu();
            }
            return instance;
        }

        public bool GoBackToBeforeFunction()
        {
            if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape)
            {
                return false;
            }
            return true;
        }

    }
}
