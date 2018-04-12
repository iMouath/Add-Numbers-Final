////////////////////////////////////////////////////////////////////////////////////////////////////
/// File:   labelform.cs.
///
/// Summary:    Implements the labelform class.
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Add_Numbers_Final
{
    public partial class LabelForm : Form
    {
        public LabelForm(decimal result, int count)
        {
            InitializeComponent();
            label3.Text = Convert.ToString(count) + " Shims";
            label4.Text = Convert.ToString(String.Format("{0:#,0.000}", result)) + " lb";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
