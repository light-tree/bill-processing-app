using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObject.Models
{
    public partial class InvoiceVat
    {
        public InvoiceVat()
        {
            GoodAndServices = new HashSet<GoodAndService>();
        }

        public long Id { get; set; }
        public string InvoiceNo { get; set; }
        public string InvoiceCode { get; set; }
        public string InvoiceSymbol { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ImportedDate { get; set; }
        public int Currency { get; set; }
        public int Payment { get; set; }
        public string SellerName { get; set; }
        public string SellerTaxCode { get; set; }
        public string SellerAddress { get; set; }
        public string BuyerName { get; set; }
        public string BuyerTaxCode { get; set; }
        public string BuyerAddress { get; set; }
        public string BuyerCode { get; set; }

        public virtual ICollection<GoodAndService> GoodAndServices { get; set; }
    }
}
