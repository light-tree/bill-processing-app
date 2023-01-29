using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home
{
    public partial class Home : Form
    {
        private static bool isBigForm = false;
        public Home()
        {
            InitializeComponent();
        }

        private void Home_SizeChanged(object sender, EventArgs e)
        {
            if (Width >= 1280 && !isBigForm)
            {
                tableLayoutPanel1.Controls.Remove(tableLayoutPanel1);
                tableLayoutPanel1.Controls.Remove(panel2);

                tableLayoutPanel1.ColumnStyles.RemoveAt(0);
                tableLayoutPanel1.ColumnCount = 2;
                tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 375F));
                tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));

                tableLayoutPanel1.RowStyles.RemoveAt(0);
                tableLayoutPanel1.RowStyles.RemoveAt(0);
                tableLayoutPanel1.RowCount = 1;
                tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));

                tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 0);
                tableLayoutPanel1.Controls.Add(panel2, 1, 0);
                isBigForm = true;

                panel4.Margin = new Padding(50, 3, 3, 3);
                panel3.Margin = new Padding(50, 3, 3, 3);
                panel5.Margin = new Padding(50, 3, 3, 3);
                panel6.Margin = new Padding(50, 3, 3, 3);
            }
            if (Width < 1280 && isBigForm)
            {
                tableLayoutPanel1.Controls.Remove(tableLayoutPanel1);
                tableLayoutPanel1.Controls.Remove(panel2);

                tableLayoutPanel1.ColumnStyles.RemoveAt(0);
                tableLayoutPanel1.ColumnStyles.RemoveAt(0);
                tableLayoutPanel1.ColumnCount = 1;
                tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));

                tableLayoutPanel1.RowStyles.RemoveAt(0);
                tableLayoutPanel1.RowCount = 2;
                tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
                tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));

                tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 0);
                tableLayoutPanel1.Controls.Add(panel2, 0, 1);
                isBigForm = false;

                panel4.Margin = new Padding(3, 3, 3, 3);
                panel3.Margin = new Padding(3, 3, 3, 3);
                panel5.Margin = new Padding(3, 3, 3, 3);
                panel6.Margin = new Padding(3, 3, 3, 3);
            }
        }
    }
}
