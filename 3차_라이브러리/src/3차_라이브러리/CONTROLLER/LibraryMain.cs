using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace Library //최상단
{// 처음 부터 메인으로 돌아가는거 가정 하고 코드짜기
    internal class LibraryMain //스타트 함수하고 차이나게 이름 변경
        //생성자 쓰면서 초기화
    {
        static void Main(string[] args)
        {
            while (true)
            {
                LibraryStart libraryStart = new LibraryStart();
                libraryStart.SelectMenu();
            }
        }
    }
}
