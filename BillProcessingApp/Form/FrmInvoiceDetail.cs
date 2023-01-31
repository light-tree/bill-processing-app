using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillProcessingApp
{
    public partial class FrmInvoiceDetail : Form
    {
        public FrmInvoiceDetail()
        {
            InitializeComponent();
        }

        private void lbCreateDate_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void FrmInvoiceDetail_Load(object sender, EventArgs e)
        {
            int index = 0;


            InvoiceTest invoiceTest = new InvoiceTest("01/01/2022", "INV-001", "INV", "001", "Invoice 1", "Seller A", "SELLER-A-TAX-CODE", "Seller A Address", "Buyer B", "BUYER-B-TAX-CODE", "Buyer B Address", "01/01/2022", "BUYER-B-CODE", "USD");

            Type type = invoiceTest.GetType();
            PropertyInfo[] properties = type.GetProperties(BindingFlags.NonPublic | BindingFlags.Instance);
            foreach (var property in properties)
            {
                displayObject(index, property.Name, property.GetValue(invoiceTest, null).ToString());

                index++;

            }


        }


        private void displayObject(int index, string header, string value)
        {
            int maxWidth = this.tblInvoiceDetailComon.Width / 6;

            if (index != 1 && (index - 1) % 3 == 0)
            {

                this.tblInvoiceDetailComon.RowCount = this.tblInvoiceDetailComon.RowCount + 1;


            }


            FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
            flowLayoutPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            flowLayoutPanel.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel.AutoSize = true;
            flowLayoutPanel.WrapContents = false;

            Label valueLabel = new Label();
            valueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            valueLabel.AutoSize = true;
            valueLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

            valueLabel.Name = "lb" + header;
            valueLabel.Size = new System.Drawing.Size(maxWidth, 50);

            valueLabel.Text = value;
            valueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            flowLayoutPanel.Controls.Add(valueLabel);

            Label headerLabel = new Label();
            headerLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            headerLabel.AllowDrop = true;
            headerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            headerLabel.AutoSize = true;
            headerLabel.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);

            headerLabel.Name = "lbheader" + header;
            headerLabel.Size = new System.Drawing.Size(maxWidth, 50);

            headerLabel.Text = header + ":";
            headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            headerLabel.UseCompatibleTextRendering = true;
            flowLayoutPanel.Controls.Add(headerLabel);



            // this.tblLayoutOrder.Controls.Add(flowLayoutPanel);


            this.tblInvoiceDetailComon.Controls.Add(flowLayoutPanel);
        }
    }




    public class InvoiceTest
    {
        private string createDate { get; set; }
        private string InvoiceCode { get; set; }
        private string InvocieSymbol { get; set; }

        private string InvoiceNo { get; set; }

        private string InvoiceName { get; set; }

        private string SellerName { get; set; }
        private string SellerTaxCode { get; set; }
        private string SellerAdrress { get; set; }

        private string BuyerName { get; set; }
        private string BuyerTaxCode { get; set; }
        private string BuyerAdrress { get; set; }
        private string ImportedDate { get; set; }
        private string BuyerCode { get; set; }
        private string Currentcy { get; set; }

        public InvoiceTest()
        {


        }

        public InvoiceTest(string createDate, string invoiceCode, string invocieSymbol, string invoiceNo, string invoiceName, string sellerName, string sellerTaxCode, string sellerAdrress, string buyerName, string buyerTaxCode, string buyerAdrress, string importedDate, string buyerCode, string currentcy)
        {
            this.createDate = createDate;
            InvoiceCode = invoiceCode;
            InvocieSymbol = invocieSymbol;
            InvoiceNo = invoiceNo;
            InvoiceName = invoiceName;
            SellerName = sellerName;
            SellerTaxCode = sellerTaxCode;
            SellerAdrress = sellerAdrress;
            BuyerName = buyerName;
            BuyerTaxCode = buyerTaxCode;
            BuyerAdrress = buyerAdrress;
            ImportedDate = importedDate;
            BuyerCode = buyerCode;
            Currentcy = currentcy;
        }
    }
}
