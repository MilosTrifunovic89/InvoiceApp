using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class InvoiceItem
    {
        public int InvoiceID { get; set; }
        //public Invoice Invoice { get; set; }

        public int TrainerID { get; set; }
        //public Invoice Trainer { get; set; }

        public int YearID { get; set; }
        //public Invoice Year { get; set; }

        public int CourseRealizationID { get; set; }
        public CourseRealization CourseRealization { get; set; }

        public string Description { get; set; }

        public int Days { get; set; }

        public virtual Invoice Invoice { get; set; }

        public decimal? Total { get; set; }//total stavka

        public int WageId { get; set; }//wage id
        public Wage Wage { get; set; }
    }
}
