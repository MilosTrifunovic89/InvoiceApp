using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Trainer
    {
        public int Id { get; set; }

        public int? TrainerPair { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int? TerritoryId { get; set; }
        public Territory Territory { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string Bank { get; set; }

        public string AccountNumber { get; set; }

        public long? VendorNumber { get; set; }

        public long? ContractNumber { get; set; }

        public bool Equipment { get; set; } //kako prevesti zaduzena operma PresentationEquipment

        public string Note { get; set; }

        public ICollection<CourseRealizationTrainer> CourseRealizationTrainers { get; set; }

        public ICollection<Invoice> Invoices { get; set; }
    }
}
