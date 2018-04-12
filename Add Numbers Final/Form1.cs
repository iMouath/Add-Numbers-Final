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

       private decimal result = 0;
       private const decimal shimsBagWeight = 5.0M; //per the requirements the bag max weight is 5lb
       public Form1()
       {
           InitializeComponent();
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
           //Check if enter key pressed. IF YES add value to shimsLB and clear the textbox
           if (e.KeyChar == (char)13)
           {
                if(Convert.ToDecimal(enterWeightTB.Text) == 0)
                {
                    //User input invalid weight of 0
                    toolTip1.ToolTipTitle = "Invalid Weight!";
                    toolTip1.Show("Make Sure You are entering above 0 values", enterWeightTB);
                    return;
                }
               if (enterWeightTB.Text != "")
               {
                   decimal value = Convert.ToDecimal(enterWeightTB.Text); //convert value to decimal
                   if (!(value + result > shimsBagWeight)) //shims weight cannot exceed bag weight
                   {
                       if (value <= shimsBagWeight) // cannot add a shims bigger in size the actual bag
                       {
                           addChim(value);
                           enterWeightTB.ResetText(); //reset textbox for new entry's
                       }

                   }
                   else
                   {
                       toolTip1.ToolTipTitle = "Weight Exceed bag!";
                       toolTip1.Show("Make sure you are adding a shim that does not exceed the total of 5lb!", enterWeightTB);
                   }
               }

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

       private void addChim(decimal value)
       {
           if (result < shimsBagWeight) // check if we reached the target weight of the bag
           {
               shimsLB.Items.Add(value); //add value to shimsLB
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
           int i = 0;
           result = 0;
           while (i < shimsLB.Items.Count) //running through the list of shims and adding them
           {
               result += Convert.ToDecimal(shimsLB.Items[i++]);
           }
           totalTB.Text = Convert.ToString(result); //update total textbox
           countToolStrip.Text = Convert.ToString(shimsLB.Items.Count); // update count interface for individual shims

       }

       /*
        * Updated for HW 17
        * User now can print label at any given weight
        */
private void button1_Click(object sender, EventArgs e)
        {
            //print Label
            int count = shimsLB.Items.Count;
            if(count > 0)
            {
                LabelForm labelForm = new LabelForm(result, count);
                labelForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nothing to Print!");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (shimsLB.Items.Count != 0) // making sure theres items in the list before removing any
            {
                shimsLB.Items.RemoveAt(shimsLB.Items.Count - 1);
                updateTotal();
            }
        }
    }

}
