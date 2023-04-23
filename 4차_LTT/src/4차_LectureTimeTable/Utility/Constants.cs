using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4차_LectureTimeTable.Utility
{
    enum MenuList
    {
        COURSE_FINDER,
        COURSE_OF_INTEREST_ADDER,
        COURSE_REGISTRATION,
        COURSE_REGISTRATION_CHECKER
    }

    enum InterestLectureMenuList
    {
        ADDER,
        CHECKER,
        DELETER
    }

    enum LectureEntriesList
    {
        MAJOR_LECTURE,
        CLASSIFICATION,
        LECTURE_NAME,
        PROFESSOR_NAME,
        GRADE,
        COURSE_NUMBER,
        CLASS_NUMBER,
        SEARCH
    }

    public class Constants
    {
        public const bool IS_PASSWORD = true;
        public const bool IS_NOT_PASSWORD = false;

        public const bool IS_PRINT_NEXT_LINE = true;
        public const bool IS_PRINT_NEXT_SIDE = false;

    }
}
