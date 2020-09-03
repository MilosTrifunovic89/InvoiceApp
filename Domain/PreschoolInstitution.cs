using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class PreschoolInstitution
    {
        public int Id { get; set; }

        public int TerritoryId { get; set; }
        public Territory Territory { get; set; }

        public string PIName { get; set; } //ne moze null

        public int? PIIDMinistry { get; set; }

        public int? StartYearImplementation { get; set; }

        public int? Cohort { get; set; }

        public int? NumerOfInstitutions { get; set; }

        public int? NumberOfTeachers { get; set; }

        public int? NumberOfProfessionalAssosiates { get; set; }

        public int? NumberOfParticipants { get; set; }

        public int? NumberOfProjectors { get; set; }

        public int? NumberOfLaptops { get; set; }

        public ICollection<PreschoolInstitutionContactPerson> PreschoolInstitutionContactPeople { get; set; }

        public ICollection<CourseRealization> CourseRealizations { get; set; }
    }
}
