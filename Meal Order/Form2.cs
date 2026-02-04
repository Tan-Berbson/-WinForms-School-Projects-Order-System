using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meal_Order
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_Ordernow_Click(object sender, EventArgs e)
        {
            if(rb_DineIn.Checked)
            {
                MessageBox.Show("Order Successfully Dine in","Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (rb_takeout.Checked)
            {
                MessageBox.Show("Order Successfully Take out","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Plss Select Dine Type","Information",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
