using System.Drawing;
using System.Windows.Forms;

namespace BillProcessingApp
{
    partial class FrmInvoiceDetail
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnHeader = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnComonInvoiceData = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbTotalMoney = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvInvoiceDetail = new System.Windows.Forms.DataGridView();
            this.dgvNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbCreateDate = new System.Windows.Forms.Label();
            this.lbCreatDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbInvoiceCode = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbInvoiceSymbol = new System.Windows.Forms.Label();
            this.lbInvoiceNo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lbInvoiceSellerName = new System.Windows.Forms.Label();
            this.lbSellerTaxCode = new System.Windows.Forms.Label();
            this.lbSellerAddress = new System.Windows.Forms.Label();
            this.lbBuyerName = new System.Windows.Forms.Label();
            this.lbBuyerTaxCode = new System.Windows.Forms.Label();
            this.lbBuyerAddress = new System.Windows.Forms.Label();
            this.lbBuyerCode = new System.Windows.Forms.Label();
            this.lbImpoertedDate = new System.Windows.Forms.Label();
            this.lbCurrency = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lbPayment = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbInvoiceName = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pnHeader.SuspendLayout();
            this.pnComonInvoiceData.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceDetail)).BeginInit();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnHeader
            // 
            this.pnHeader.Controls.Add(this.btnDelete);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Padding = new System.Windows.Forms.Padding(10);
            this.pnHeader.Size = new System.Drawing.Size(1064, 95);
            this.pnHeader.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(204)))));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDelete.Location = new System.Drawing.Point(908, 26);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(5);
            this.btnDelete.Size = new System.Drawing.Size(133, 48);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // pnComonInvoiceData
            // 
            this.pnComonInvoiceData.Controls.Add(this.panel5);
            this.pnComonInvoiceData.Controls.Add(this.panel4);
            this.pnComonInvoiceData.Controls.Add(this.panel3);
            this.pnComonInvoiceData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnComonInvoiceData.Location = new System.Drawing.Point(0, 95);
            this.pnComonInvoiceData.Name = "pnComonInvoiceData";
            this.pnComonInvoiceData.Padding = new System.Windows.Forms.Padding(10);
            this.pnComonInvoiceData.Size = new System.Drawing.Size(1064, 750);
            this.pnComonInvoiceData.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lbTotalMoney);
            this.panel5.Controls.Add(this.label30);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(10, 627);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1044, 63);
            this.panel5.TabIndex = 2;
            // 
            // lbTotalMoney
            // 
            this.lbTotalMoney.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTotalMoney.AutoSize = true;
            this.lbTotalMoney.Location = new System.Drawing.Point(870, 21);
            this.lbTotalMoney.Name = "lbTotalMoney";
            this.lbTotalMoney.Size = new System.Drawing.Size(103, 27);
            this.lbTotalMoney.TabIndex = 1;
            this.lbTotalMoney.Text = "1000000";
            this.lbTotalMoney.UseMnemonic = false;
            // 
            // label30
            // 
            this.label30.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(795, 21);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(69, 27);
            this.label30.TabIndex = 0;
            this.label30.Text = "Total:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvInvoiceDetail);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(10, 264);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1044, 363);
            this.panel4.TabIndex = 1;
            // 
            // dgvInvoiceDetail
            // 
            this.dgvInvoiceDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInvoiceDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInvoiceDetail.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvInvoiceDetail.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvInvoiceDetail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInvoiceDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInvoiceDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoiceDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvNo,
            this.dgvName,
            this.dgvUnit,
            this.dgvQuantity,
            this.dgvPrice,
            this.dgvTotal,
            this.dgvNote});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInvoiceDetail.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInvoiceDetail.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvInvoiceDetail.Location = new System.Drawing.Point(0, 0);
            this.dgvInvoiceDetail.Name = "dgvInvoiceDetail";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInvoiceDetail.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInvoiceDetail.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.dgvInvoiceDetail.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvInvoiceDetail.RowTemplate.Height = 25;
            this.dgvInvoiceDetail.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInvoiceDetail.Size = new System.Drawing.Size(1044, 363);
            this.dgvInvoiceDetail.TabIndex = 0;
            // 
            // dgvNo
            // 
            this.dgvNo.HeaderText = "No";
            this.dgvNo.Name = "dgvNo";
            // 
            // dgvName
            // 
            this.dgvName.HeaderText = "Name";
            this.dgvName.Name = "dgvName";
            // 
            // dgvUnit
            // 
            this.dgvUnit.HeaderText = "Unit";
            this.dgvUnit.Name = "dgvUnit";
            // 
            // dgvQuantity
            // 
            this.dgvQuantity.HeaderText = "Quantity";
            this.dgvQuantity.Name = "dgvQuantity";
            // 
            // dgvPrice
            // 
            this.dgvPrice.HeaderText = "Price";
            this.dgvPrice.Name = "dgvPrice";
            // 
            // dgvTotal
            // 
            this.dgvTotal.HeaderText = "Total";
            this.dgvTotal.Name = "dgvTotal";
            // 
            // dgvNote
            // 
            this.dgvNote.HeaderText = "Note";
            this.dgvNote.Name = "dgvNote";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(10, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1044, 254);
            this.panel3.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel1.Controls.Add(this.lbCreateDate, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbCreatDate, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbInvoiceCode, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbInvoiceSymbol, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbInvoiceNo, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.label11, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.label16, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label17, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label18, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label19, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label21, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label22, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbInvoiceSellerName, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbSellerTaxCode, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbSellerAddress, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbBuyerName, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbBuyerTaxCode, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbBuyerAddress, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbBuyerCode, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbImpoertedDate, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbCurrency, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.label20, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbPayment, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.label10, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbInvoiceName, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label14, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1044, 254);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbCreateDate
            // 
            this.lbCreateDate.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lbCreateDate.AllowDrop = true;
            this.lbCreateDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCreateDate.AutoSize = true;
            this.lbCreateDate.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCreateDate.Location = new System.Drawing.Point(3, 0);
            this.lbCreateDate.Name = "lbCreateDate";
            this.lbCreateDate.Size = new System.Drawing.Size(110, 50);
            this.lbCreateDate.TabIndex = 3;
            this.lbCreateDate.Text = "Created date:";
            this.lbCreateDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbCreateDate.UseCompatibleTextRendering = true;
            this.lbCreateDate.Click += new System.EventHandler(this.lbCreateDate_Click);
            // 
            // lbCreatDate
            // 
            this.lbCreatDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCreatDate.AutoSize = true;
            this.lbCreatDate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCreatDate.Location = new System.Drawing.Point(119, 0);
            this.lbCreatDate.Name = "lbCreatDate";
            this.lbCreatDate.Size = new System.Drawing.Size(226, 50);
            this.lbCreatDate.TabIndex = 4;
            this.lbCreatDate.Text = "Text";
            this.lbCreatDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label2.AllowDrop = true;
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 50);
            this.label2.TabIndex = 5;
            this.label2.Text = "Invoice Code:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.UseCompatibleTextRendering = true;
            // 
            // lbInvoiceCode
            // 
            this.lbInvoiceCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbInvoiceCode.AutoSize = true;
            this.lbInvoiceCode.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbInvoiceCode.Location = new System.Drawing.Point(119, 50);
            this.lbInvoiceCode.Name = "lbInvoiceCode";
            this.lbInvoiceCode.Size = new System.Drawing.Size(226, 50);
            this.lbInvoiceCode.TabIndex = 6;
            this.lbInvoiceCode.Text = "Text";
            this.lbInvoiceCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label4.AllowDrop = true;
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(3, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 50);
            this.label4.TabIndex = 7;
            this.label4.Text = "Invoice No:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.UseCompatibleTextRendering = true;
            // 
            // label5
            // 
            this.label5.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label5.AllowDrop = true;
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(3, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 50);
            this.label5.TabIndex = 8;
            this.label5.Text = "Invoice Symbol:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.UseCompatibleTextRendering = true;
            // 
            // lbInvoiceSymbol
            // 
            this.lbInvoiceSymbol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbInvoiceSymbol.AutoSize = true;
            this.lbInvoiceSymbol.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbInvoiceSymbol.Location = new System.Drawing.Point(119, 100);
            this.lbInvoiceSymbol.Name = "lbInvoiceSymbol";
            this.lbInvoiceSymbol.Size = new System.Drawing.Size(226, 50);
            this.lbInvoiceSymbol.TabIndex = 10;
            this.lbInvoiceSymbol.Text = "Text";
            this.lbInvoiceSymbol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbInvoiceNo
            // 
            this.lbInvoiceNo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbInvoiceNo.AutoSize = true;
            this.lbInvoiceNo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbInvoiceNo.Location = new System.Drawing.Point(119, 150);
            this.lbInvoiceNo.Name = "lbInvoiceNo";
            this.lbInvoiceNo.Size = new System.Drawing.Size(226, 50);
            this.lbInvoiceNo.TabIndex = 11;
            this.lbInvoiceNo.Text = "Text";
            this.lbInvoiceNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label6.AllowDrop = true;
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(699, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 50);
            this.label6.TabIndex = 9;
            this.label6.Text = "Currency:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.UseCompatibleTextRendering = true;
            // 
            // label11
            // 
            this.label11.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label11.AllowDrop = true;
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label11.Location = new System.Drawing.Point(699, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 50);
            this.label11.TabIndex = 14;
            this.label11.Text = "Imported date:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label11.UseCompatibleTextRendering = true;
            // 
            // label16
            // 
            this.label16.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label16.AllowDrop = true;
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label16.Location = new System.Drawing.Point(351, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(110, 50);
            this.label16.TabIndex = 19;
            this.label16.Text = "Seller\'s Name:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label16.UseCompatibleTextRendering = true;
            // 
            // label17
            // 
            this.label17.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label17.AllowDrop = true;
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label17.Location = new System.Drawing.Point(351, 50);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(110, 50);
            this.label17.TabIndex = 20;
            this.label17.Text = "Seller\'s Tax Code:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label17.UseCompatibleTextRendering = true;
            // 
            // label18
            // 
            this.label18.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label18.AllowDrop = true;
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label18.Location = new System.Drawing.Point(351, 100);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(110, 50);
            this.label18.TabIndex = 21;
            this.label18.Text = "Seller\'s Address:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label18.UseCompatibleTextRendering = true;
            // 
            // label19
            // 
            this.label19.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label19.AllowDrop = true;
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label19.Location = new System.Drawing.Point(351, 150);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(110, 50);
            this.label19.TabIndex = 22;
            this.label19.Text = "Buyer\'s Name:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label19.UseCompatibleTextRendering = true;
            // 
            // label21
            // 
            this.label21.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label21.AllowDrop = true;
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label21.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label21.Location = new System.Drawing.Point(699, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(110, 50);
            this.label21.TabIndex = 24;
            this.label21.Text = "Buyer\'s Address";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label21.UseCompatibleTextRendering = true;
            // 
            // label22
            // 
            this.label22.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label22.AllowDrop = true;
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label22.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label22.Location = new System.Drawing.Point(699, 50);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(110, 50);
            this.label22.TabIndex = 25;
            this.label22.Text = "Buyer\'s Code:";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label22.UseCompatibleTextRendering = true;
            // 
            // lbInvoiceSellerName
            // 
            this.lbInvoiceSellerName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbInvoiceSellerName.AutoSize = true;
            this.lbInvoiceSellerName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbInvoiceSellerName.Location = new System.Drawing.Point(467, 0);
            this.lbInvoiceSellerName.Name = "lbInvoiceSellerName";
            this.lbInvoiceSellerName.Size = new System.Drawing.Size(226, 50);
            this.lbInvoiceSellerName.TabIndex = 18;
            this.lbInvoiceSellerName.Text = "Text";
            this.lbInvoiceSellerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbSellerTaxCode
            // 
            this.lbSellerTaxCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSellerTaxCode.AutoSize = true;
            this.lbSellerTaxCode.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSellerTaxCode.Location = new System.Drawing.Point(467, 50);
            this.lbSellerTaxCode.Name = "lbSellerTaxCode";
            this.lbSellerTaxCode.Size = new System.Drawing.Size(226, 50);
            this.lbSellerTaxCode.TabIndex = 27;
            this.lbSellerTaxCode.Text = "Text";
            this.lbSellerTaxCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbSellerAddress
            // 
            this.lbSellerAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSellerAddress.AutoSize = true;
            this.lbSellerAddress.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSellerAddress.Location = new System.Drawing.Point(467, 100);
            this.lbSellerAddress.Name = "lbSellerAddress";
            this.lbSellerAddress.Size = new System.Drawing.Size(226, 50);
            this.lbSellerAddress.TabIndex = 28;
            this.lbSellerAddress.Text = "Text";
            this.lbSellerAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbBuyerName
            // 
            this.lbBuyerName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBuyerName.AutoSize = true;
            this.lbBuyerName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbBuyerName.Location = new System.Drawing.Point(467, 150);
            this.lbBuyerName.Name = "lbBuyerName";
            this.lbBuyerName.Size = new System.Drawing.Size(226, 50);
            this.lbBuyerName.TabIndex = 29;
            this.lbBuyerName.Text = "Text";
            this.lbBuyerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbBuyerTaxCode
            // 
            this.lbBuyerTaxCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBuyerTaxCode.AutoSize = true;
            this.lbBuyerTaxCode.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbBuyerTaxCode.Location = new System.Drawing.Point(467, 200);
            this.lbBuyerTaxCode.Name = "lbBuyerTaxCode";
            this.lbBuyerTaxCode.Size = new System.Drawing.Size(226, 54);
            this.lbBuyerTaxCode.TabIndex = 30;
            this.lbBuyerTaxCode.Text = "Text";
            this.lbBuyerTaxCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbBuyerAddress
            // 
            this.lbBuyerAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBuyerAddress.AutoSize = true;
            this.lbBuyerAddress.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbBuyerAddress.Location = new System.Drawing.Point(815, 0);
            this.lbBuyerAddress.Name = "lbBuyerAddress";
            this.lbBuyerAddress.Size = new System.Drawing.Size(226, 50);
            this.lbBuyerAddress.TabIndex = 16;
            this.lbBuyerAddress.Text = "Text";
            this.lbBuyerAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbBuyerAddress.Click += new System.EventHandler(this.label23_Click);
            // 
            // lbBuyerCode
            // 
            this.lbBuyerCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBuyerCode.AutoSize = true;
            this.lbBuyerCode.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbBuyerCode.Location = new System.Drawing.Point(815, 50);
            this.lbBuyerCode.Name = "lbBuyerCode";
            this.lbBuyerCode.Size = new System.Drawing.Size(226, 50);
            this.lbBuyerCode.TabIndex = 16;
            this.lbBuyerCode.Text = "Text";
            this.lbBuyerCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbImpoertedDate
            // 
            this.lbImpoertedDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbImpoertedDate.AutoSize = true;
            this.lbImpoertedDate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbImpoertedDate.Location = new System.Drawing.Point(815, 100);
            this.lbImpoertedDate.Name = "lbImpoertedDate";
            this.lbImpoertedDate.Size = new System.Drawing.Size(226, 50);
            this.lbImpoertedDate.TabIndex = 15;
            this.lbImpoertedDate.Text = "Text";
            this.lbImpoertedDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbCurrency
            // 
            this.lbCurrency.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCurrency.AutoSize = true;
            this.lbCurrency.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCurrency.Location = new System.Drawing.Point(815, 150);
            this.lbCurrency.Name = "lbCurrency";
            this.lbCurrency.Size = new System.Drawing.Size(226, 50);
            this.lbCurrency.TabIndex = 12;
            this.lbCurrency.Text = "Text";
            this.lbCurrency.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label20
            // 
            this.label20.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label20.AllowDrop = true;
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label20.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label20.Location = new System.Drawing.Point(351, 200);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(110, 54);
            this.label20.TabIndex = 23;
            this.label20.Text = "Buyer\'s Tax Code:";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label20.UseCompatibleTextRendering = true;
            // 
            // lbPayment
            // 
            this.lbPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPayment.AutoSize = true;
            this.lbPayment.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPayment.Location = new System.Drawing.Point(815, 200);
            this.lbPayment.Name = "lbPayment";
            this.lbPayment.Size = new System.Drawing.Size(226, 54);
            this.lbPayment.TabIndex = 26;
            this.lbPayment.Text = "Text";
            this.lbPayment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label10.AllowDrop = true;
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.Location = new System.Drawing.Point(699, 200);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 54);
            this.label10.TabIndex = 13;
            this.label10.Text = "Payment:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.UseCompatibleTextRendering = true;
            // 
            // lbInvoiceName
            // 
            this.lbInvoiceName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbInvoiceName.AutoSize = true;
            this.lbInvoiceName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbInvoiceName.Location = new System.Drawing.Point(119, 200);
            this.lbInvoiceName.Name = "lbInvoiceName";
            this.lbInvoiceName.Size = new System.Drawing.Size(226, 54);
            this.lbInvoiceName.TabIndex = 31;
            this.lbInvoiceName.Text = "Text";
            this.lbInvoiceName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label14.AllowDrop = true;
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(3, 200);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 54);
            this.label14.TabIndex = 17;
            this.label14.Text = "Invoice Name:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label14.UseCompatibleTextRendering = true;
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // FrmInvoiceDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 845);
            this.Controls.Add(this.pnComonInvoiceData);
            this.Controls.Add(this.pnHeader);
            this.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "FrmInvoiceDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnHeader.ResumeLayout(false);
            this.pnComonInvoiceData.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceDetail)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.Panel pnComonInvoiceData;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbCreateDate;
        private System.Windows.Forms.Label lbCreatDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbInvoiceCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbInvoiceSymbol;
        private System.Windows.Forms.Label lbInvoiceNo;
        private System.Windows.Forms.Label lbCurrency;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbBuyerCode;
        private System.Windows.Forms.Label lbImpoertedDate;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lbBuyerAddress;
        private System.Windows.Forms.Label lbInvoiceSellerName;
        private System.Windows.Forms.Label lbSellerTaxCode;
        private System.Windows.Forms.Label lbSellerAddress;
        private System.Windows.Forms.Label lbBuyerName;
        private System.Windows.Forms.Label lbBuyerTaxCode;
        private System.Windows.Forms.Label lbPayment;
        private System.Windows.Forms.Label lbInvoiceName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvInvoiceDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNote;
        private Panel panel5;
        private Label lbTotalMoney;
        private Label label30;
    }
}
