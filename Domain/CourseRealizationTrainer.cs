using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class CourseRealizationTrainer
    {
        public int TrainerID { get; set; }
        public Trainer Trainer { get; set; }

        public int CourseRealizationID { get; set; }
        public CourseRealization CourseRealization { get; set; }
    }
}
