using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObject.Models
{
    public partial class GoodAndService
    {
        public int Id { get; set; }
        public long? InvoiceVatid { get; set; }
        public int No { get; set; }
        public string Name { get; set; }
        public int Unit { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int Tax { get; set; }
        public string Note { get; set; }

        public virtual InvoiceVat InvoiceVat { get; set; }
    }
}
