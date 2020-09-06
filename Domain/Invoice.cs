using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Invoice
    {
        public int Id { get; set; }
        //public int InvoiceId { get; set; }

        public int TrainerID { get; set; }
        public Trainer Trainer { get; set; }

        public int YearID { get; set; }

        public DateTime DateFrom { get; set; }

        public DateTime DateTo { get; set; }

        public DateTime DateInvoice { get; set; }

        //public int WageID { get; set; }
        //public Wage Wage { get; set; }//brise se 

        //public decimal WageAmount { get; set; }//brise se

        public decimal? Total { get; set; }//total

        public bool Satus { get; set; }

        public ICollection<InvoiceItem> InvoiceItems { get; set; }
    }
}
