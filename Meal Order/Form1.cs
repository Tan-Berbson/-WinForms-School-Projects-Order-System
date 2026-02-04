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
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            
            if (cbm_Order.SelectedItem == null)
            {
                MessageBox.Show("Please select an order before confirming.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string order = cbm_Order.SelectedItem.ToString();

            string checkbox = "";
            if (chk_Friess.Checked )
            {
                checkbox += "," + "Friess ,";
            }
            if( chk_Gravy.Checked )
            {
                checkbox += "," + "Gravy ,";
            }
            if (chk_sundae.Checked )
            {
                checkbox += "," + "Sundae";
            }
            ListViewItem ordersum = new ListViewItem(order);
            ordersum.SubItems.Add(checkbox);
            listview_OrderSum.Items.Add(ordersum);
           


        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            listview_OrderSum.Columns.Add("Order", 120);
            listview_OrderSum.Columns.Add("Adds on", 120);
        }
        private void clear()
        {
            cbm_Order.SelectedItem = null;
            chk_Friess.Checked = false;
            chk_Gravy.Checked = false;
            chk_sundae.Checked = false;
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            if ( cbm_Order.SelectedItem == null)
            {
                MessageBox.Show("Please select an order before confirming.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            Form2 f = new Form2();
            foreach(ListViewItem ord in listview_OrderSum.Items)
            {
                string order = ord.Text;
                string addons = ord.SubItems[1].Text;
                f.listBox1.Items.Add(order);
                f.listBox1.Items.Add("Adds - on" + addons);

            }
            f.Show();
            this.Hide();
        }
    }
}
