/*
 * Assignment: 10
 * Program Name: Add Shims
 * Function: Program allows user to enter weight of shims, while keeping track of each shim and its weight
 *           Program will also print a label with amount of individual shims and the total weight.
 * Created: March 5, 2018
 * Updated: April 12, 2018
 * Muath Almubarrizi
 */

/* Product Function & test cases:
 * 
 * [x] adds multiple numbers
 * [x] user can delete last value
 * [x] displays running total
 * [x] displays number of shims in package
 * [x] user can reset and prepare for a new package
 * [x] print label
 * [x] error trapping
 * [X] identifies weight maximum at 5 pounds
 */

using System;
using System.Windows.Forms;

namespace Add_Numbers_Final
{

    public partial class Form1 : Form
    {
        //TODO: allow user to set size ... defaults is 5
       private double shimsBagWeight = 5.0d; //per the requirements the bag max weight is 5lb
       private Shims shims;

       public Form1()
       {
           InitializeComponent();
           shims = new Shims();
           this.shimsBagWeight = Convert.ToDouble(bagSizeTB.Text.ToString());
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Event handler. Called by enterWeightTB for check enter events. </summary>
        ///
        /// <remarks>   Mouath, 3/8/2018. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Key press event information. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void enterWeightTB_CheckEnter(object sender, KeyPressEventArgs e)
       {
           //Check if enter key pressed. IF YES call addChims()
           if (e.KeyChar == (char)13)
           {
                addShims();
           }
           // allows 0-9, backspace, and decimal
           if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
           {
               e.Handled = true;
               return;
           }

           // checks to make sure only 1 decimal is allowed
           if (e.KeyChar == 46)
           {
               if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                   e.Handled = true;
           }
       }

        private void enterSizeTB_CheckEnter(object sender, KeyPressEventArgs e)
        {
            //Check if enter key pressed.
            if (e.KeyChar == (char)13)
            {
                this.shimsBagWeight = Convert.ToDouble(bagSizeTB.Text.ToString());
            }
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Adds a shim. </summary>
        ///
        /// <remarks>   Mouath, 3/8/2018. </remarks>
        ///
        /// <param name="value">    The weight of the shim. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void addShim(double value)
       {
            
           if (shims.TotalWeight < this.shimsBagWeight) // check if we reached the target weight of the bag
           {
               shimsLB.Items.Add(value); //add value to shimsLB
                shims.Count = shimsLB.Items.Count;
                shims.ShimsWeight.Add(value);
                shims.CalculateShimsWeight();
                updateTotal();
           }
       }

       ////////////////////////////////////////////////////////////////////////////////////////////////////
       /// <summary>   Updates the total. </summary>
       /// this function will be called when we need to update the total of shims
       /// <remarks>   Mouath, 3/8/2018. </remarks>
       ////////////////////////////////////////////////////////////////////////////////////////////////////

       private void updateTotal()
       {
            totalTB.Text = Convert.ToString(shims.TotalWeight); //update total TextBox
           countToolStrip.Text = Convert.ToString(shims.Count); // update count interface for individual shims
            if(shimsBagWeight - shims.TotalWeight == 0)
            {
                amountDue.Text = "Full";
            }
            else
            {
                String amountDueString = Convert.ToString(shimsBagWeight - shims.TotalWeight);
                amountDue.Text = string.Format("{0:#,0.000} lbs", amountDueString);
            }
            shims.CalculateShimsWeight();
        }

        /*
         * Updated for HW 17
         * User now can print label at any given weight
         */
        private void button1_Click(object sender, EventArgs e)
        {
            //print Label
            shims.Count = shimsLB.Items.Count;
            if(shims.Count > 0)
            {
                using (LabelForm label = new LabelForm (shims))
                {
                    label.ShowDialog(this);
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nothing to Print!");
            }
        }

        private void clearLastEntryButton_Click(object sender, EventArgs e)
        {
            if (shimsLB.Items.Count != 0) // making sure theres items in the list before removing any
            {
                shimsLB.Items.RemoveAt(shimsLB.Items.Count - 1);
                shims.Count = shimsLB.Items.Count;
                shims.ShimsWeight.RemoveAt(shimsLB.Items.Count);
                updateTotal();
            }
        }
        //handles button clicks for add shims
        private void addButton_Click(object sender, EventArgs e)
        {
            addShims();
        }
        /*
         * This function will handle adding the shims to our running total
         */
        private void addShims()
        {
            if (enterWeightTB.Text.Length == 0)
            {
                toolTip1.ToolTipTitle = "Invalid Entry!";
                toolTip1.Show("Make Sure You are adding something!", enterWeightTB);
                enterWeightTB.ResetText();
            }
            else
            {
                if (Convert.ToDouble(enterWeightTB.Text) == 0)
                {
                    //User input invalid weight of 0
                    toolTip1.ToolTipTitle = "Invalid Weight!";
                    toolTip1.Show("Make Sure You are entering above 0 values", enterWeightTB);
                    enterWeightTB.ResetText();
                    return;
                }
                if (enterWeightTB.Text != "")
                {
                    double value = Convert.ToDouble(enterWeightTB.Text); //convert value to decimal
                    
                    if (!(value + shims.TotalWeight > this.shimsBagWeight)) //shims weight cannot exceed bag weight
                    {
                        if (value <= this.shimsBagWeight) // cannot add a shims bigger in size the actual bag
                        {
                            addShim(value);
                            enterWeightTB.ResetText(); //reset TextBox for new entry's
                        }
                    }
                    else
                    {
                        toolTip1.ToolTipTitle = "Weight Exceed bag!";
                        toolTip1.Show("Make sure you are adding a shim that does not exceed the total of " + shimsBagWeight + " lb!", enterWeightTB);
                        enterWeightTB.ResetText();
                    }
                }
            }
        }

        //Closes the application
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Shows about box
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AboutBox1 box = new AboutBox1())
            {
                box.ShowDialog(this);
            }
        }
        //shows help
        private void addHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (helpAddingShims help_1 = new helpAddingShims())
            {
                help_1.ShowDialog(this);
            }
        }
        //Gives the option to the user to set the bag size with no limitation as per the requiremnts
        private void saveBagSize_Click(object sender, EventArgs e)
        {
            this.shimsBagWeight = Convert.ToDouble(bagSizeTB.Text.ToString());
        }
    }

}
