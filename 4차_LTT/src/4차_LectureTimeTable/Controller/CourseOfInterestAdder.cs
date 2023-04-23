using _4차_LectureTimeTable.View;
using System;

namespace _4차_LectureTimeTable.Controller
{
    public class CourseOfInterestAdder
    {
        MenuUi menuUi;
        public string[] menuList = { "개설학과 전공", "이수구분", "교과목 명", "교수명", "학년", "학수번호", "<검색하기>" };
        public string[] menuMajorOptionList = { "전체", "컴퓨터공학과", "소프트웨어공학과", "지능기전공학부", "기계항공우주공학부" };
        public string[] menuCreditClassificationList = { "전체", "교양필수", "전공필수", "전공선택" };
        public int selectedMenu;

        public CourseOfInterestAdder(MenuUi menuUi)
        {
            this.menuUi = menuUi;
        }

        public void SearchTheLecture()
        {
            Console.Clear();
            menuUi.PrintSearchLectureGuideUi();
            //SelectUpAndDownMenu(6,44,11);
        }
        
    }
}
