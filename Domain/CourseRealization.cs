using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class CourseRealization
    {
        public int Id { get; set; }

        public int PreschoolInstitutionID { get; set; }
        public PreschoolInstitution PreschoolInstitution { get; set; }

        public int CourseID { get; set; }
        public Course Course { get; set; }

        public DateTime StartDate { get; set; }//???? da li dozvoliti null?

        public DateTime CompletionDay { get; set; }

        public int? NumberOfParticipants { get; set; }

        public string ZUOVPassword { get; set; }

        public Status Status { get; set; }

        public ICollection<CourseRealizationTrainer> CourseRealizationTrainers { get; set; }

        public ICollection<InvoiceItem> InvoiceItems { get; set; }
    }
}
