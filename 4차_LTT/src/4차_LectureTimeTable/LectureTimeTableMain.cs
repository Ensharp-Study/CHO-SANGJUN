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
            lectureTimeTableStart.GetLogin();

            /*Console.WriteLine(Encoding.Default.GetByteCount("월 16:30~18:30, 월 18:30~20:30") - ("월 16:30~18:30, 월 18:30~20:30").Length + 2); 4
            Console.WriteLine(Encoding.Default.GetByteCount("월 16:30~18:30, 월 18:30~20:30")); 30
            Console.WriteLine(("월 16:30~18:30, 월 18:30~20:30").Length); 28*/ 

        }
    }
}
