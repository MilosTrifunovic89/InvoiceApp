﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class PreschoolInstitutionContactPerson
    {
        public int Id { get; set; }

        public int PreschoolInstitutionId { get; set; }
        public PreschoolInstitution PreschoolInstitution { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Roles Role { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string Note { get; set; }
    }
}
