using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Wage
    {
        public int Id { get; set; }

        public int? Year { get; set; }

        public int? Month { get; set; }

        public decimal WageRSD { get; set; } // ovde bih za ubuduce stavio dnevnicu u evrima koju ce sam da preracunava, mesec i godina ako je moguce da se 
                                             // automatski upisuju, tako da sa ovom tabelom nema posla
        public ICollection<Invoice> Invoices { get; set; }
    }
}
