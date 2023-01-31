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
            this.tblInvoiceDetailComon = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Home = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnHeader.SuspendLayout();
            this.pnComonInvoiceData.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceDetail)).BeginInit();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnHeader
            // 
            this.pnHeader.Controls.Add(this.flowLayoutPanel2);
            this.pnHeader.Controls.Add(this.flowLayoutPanel1);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Padding = new System.Windows.Forms.Padding(10);
            this.pnHeader.Size = new System.Drawing.Size(1064, 150);
            this.pnHeader.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDelete.Location = new System.Drawing.Point(888, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(5);
            this.btnDelete.Size = new System.Drawing.Size(133, 48);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // pnComonInvoiceData
            // 
            this.pnComonInvoiceData.AutoScroll = true;
            this.pnComonInvoiceData.AutoScrollMinSize = new System.Drawing.Size(900, 500);
            this.pnComonInvoiceData.Controls.Add(this.panel5);
            this.pnComonInvoiceData.Controls.Add(this.panel4);
            this.pnComonInvoiceData.Controls.Add(this.panel3);
            this.pnComonInvoiceData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnComonInvoiceData.Location = new System.Drawing.Point(0, 150);
            this.pnComonInvoiceData.MinimumSize = new System.Drawing.Size(960, 540);
            this.pnComonInvoiceData.Name = "pnComonInvoiceData";
            this.pnComonInvoiceData.Padding = new System.Windows.Forms.Padding(10);
            this.pnComonInvoiceData.Size = new System.Drawing.Size(1064, 695);
            this.pnComonInvoiceData.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lbTotalMoney);
            this.panel5.Controls.Add(this.label30);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(10, 373);
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
            this.lbTotalMoney.Size = new System.Drawing.Size(134, 35);
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
            this.label30.Size = new System.Drawing.Size(86, 35);
            this.label30.TabIndex = 0;
            this.label30.Text = "Total:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvInvoiceDetail);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(10, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1044, 363);
            this.panel4.TabIndex = 1;
            // 
            // dgvInvoiceDetail
            // 
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
            this.dgvInvoiceDetail.Dock = System.Windows.Forms.DockStyle.Top;
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
            this.dgvInvoiceDetail.RowHeadersWidth = 51;
            this.dgvInvoiceDetail.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.dgvInvoiceDetail.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvInvoiceDetail.RowTemplate.Height = 25;
            this.dgvInvoiceDetail.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInvoiceDetail.Size = new System.Drawing.Size(1044, 308);
            this.dgvInvoiceDetail.TabIndex = 0;
            // 
            // dgvNo
            // 
            this.dgvNo.HeaderText = "No";
            this.dgvNo.MinimumWidth = 6;
            this.dgvNo.Name = "dgvNo";
            // 
            // dgvName
            // 
            this.dgvName.HeaderText = "Name";
            this.dgvName.MinimumWidth = 6;
            this.dgvName.Name = "dgvName";
            // 
            // dgvUnit
            // 
            this.dgvUnit.HeaderText = "Unit";
            this.dgvUnit.MinimumWidth = 6;
            this.dgvUnit.Name = "dgvUnit";
            // 
            // dgvQuantity
            // 
            this.dgvQuantity.HeaderText = "Quantity";
            this.dgvQuantity.MinimumWidth = 6;
            this.dgvQuantity.Name = "dgvQuantity";
            // 
            // dgvPrice
            // 
            this.dgvPrice.HeaderText = "Price";
            this.dgvPrice.MinimumWidth = 6;
            this.dgvPrice.Name = "dgvPrice";
            // 
            // dgvTotal
            // 
            this.dgvTotal.HeaderText = "Total";
            this.dgvTotal.MinimumWidth = 6;
            this.dgvTotal.Name = "dgvTotal";
            // 
            // dgvNote
            // 
            this.dgvNote.HeaderText = "Note";
            this.dgvNote.MinimumWidth = 6;
            this.dgvNote.Name = "dgvNote";
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.tblInvoiceDetailComon);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(10, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1044, 0);
            this.panel3.TabIndex = 0;
            // 
            // tblInvoiceDetailComon
            // 
            this.tblInvoiceDetailComon.AutoSize = true;
            this.tblInvoiceDetailComon.ColumnCount = 3;
            this.tblInvoiceDetailComon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblInvoiceDetailComon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblInvoiceDetailComon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblInvoiceDetailComon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblInvoiceDetailComon.Location = new System.Drawing.Point(0, 0);
            this.tblInvoiceDetailComon.Name = "tblInvoiceDetailComon";
            this.tblInvoiceDetailComon.RowCount = 1;
            this.tblInvoiceDetailComon.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblInvoiceDetailComon.Size = new System.Drawing.Size(1044, 0);
            this.tblInvoiceDetailComon.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Home);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1044, 56);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // Home
            // 
            this.Home.AutoSize = true;
            this.Home.Location = new System.Drawing.Point(13, 10);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(94, 35);
            this.Home.TabIndex = 0;
            this.Home.Text = "Home";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnDelete);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(10, 66);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.flowLayoutPanel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1044, 56);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // FrmInvoiceDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 845);
            this.Controls.Add(this.pnComonInvoiceData);
            this.Controls.Add(this.pnHeader);
            this.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.MinimumSize = new System.Drawing.Size(960, 540);
            this.Name = "FrmInvoiceDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmInvoiceDetail_Load);
            this.pnHeader.ResumeLayout(false);
            this.pnComonInvoiceData.ResumeLayout(false);
            this.pnComonInvoiceData.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceDetail)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.Panel pnComonInvoiceData;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tblInvoiceDetailComon;
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
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label Home;
    }
}
