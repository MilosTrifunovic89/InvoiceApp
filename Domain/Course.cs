using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Course
    {
        public int Id { get; set; }

        public string CourseName { get; set; }

        public CourseShortedName CourseShortedName { get; set; }

        public int DaysForRealization { get; set; }

        public int DaysForInvoice { get; set; }

        public string CodeCourseZUOV { get; set; }

        public string CursePasswordZUOV { get; set; }

        public ICollection<CourseRealization> CourseRealizations { get; set; }
    }
}
