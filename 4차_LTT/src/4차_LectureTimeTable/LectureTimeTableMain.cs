using _4차_LectureTimeTable.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _4차_LectureTimeTable
{
    public class LectureTimeTableMain
    {
        static void Main(string[] args)
        {
            LectureTimeTableStart lectureTimeTableStart = new LectureTimeTableStart();
            lectureTimeTableStart.GetLogin(); //로그인 함수로 들어가기
        }
    }
}
