using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Territory
    {
        public int Id { get; set; }

        public string Municipality { get; set; }

        public string District { get; set; }

        public string Region { get; set; }

        public ICollection<PreschoolInstitution> PreschoolInstitutions { get; set; }

        public ICollection<Trainer> Trainers { get; set; }
    }
}
