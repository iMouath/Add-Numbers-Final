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
        private Shims shims;
        public LabelForm(Shims shims)
        {
            InitializeComponent();
            this.shims = shims;
            //shims.CalculateAverage();
            //shims.CalculateMax();
            //shims.CalculateMin();
            //shims.CalculateSD();
            //shims.CalculateShimsWeight();
            fillInterface();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void fillInterface()
        {
            //Labels
            Label totalShimCountLabel = new Label();
            totalShimCountLabel.Dock = DockStyle.Fill;
            totalShimCountLabel.Text = "Total Shim Count: ";
            totalShimCountLabel.TextAlign = ContentAlignment.MiddleLeft;

            Label totalWeightLabel = new Label();
            totalWeightLabel.Dock = DockStyle.Fill;
            totalWeightLabel.Text = "Total Weight: ";
            totalWeightLabel.TextAlign = ContentAlignment.MiddleLeft;

            Label sdWeightsLabel = new Label();
            sdWeightsLabel.Dock = DockStyle.Fill;
            sdWeightsLabel.Text = "Standard Deviation of Weights: ";
            sdWeightsLabel.TextAlign = ContentAlignment.MiddleLeft;

            Label averageWeightLabel = new Label();
            averageWeightLabel.Dock = DockStyle.Fill;
            averageWeightLabel.Text = "Average Weight: ";
            averageWeightLabel.TextAlign = ContentAlignment.MiddleLeft;

            Label minWeightLabel = new Label();
            minWeightLabel.Dock = DockStyle.Fill;
            minWeightLabel.Text = "Minimum Weight: ";
            minWeightLabel.TextAlign = ContentAlignment.MiddleLeft;

            Label maxWeightLabel = new Label();
            maxWeightLabel.Dock = DockStyle.Fill;
            maxWeightLabel.Text = "Maximum Weight: ";
            maxWeightLabel.TextAlign = ContentAlignment.MiddleLeft;

            //Values
            Label totalShimCount = new Label();
            totalShimCount.Dock = DockStyle.Fill;
            totalShimCount.Text = shims.Count + " Shims";
            totalShimCount.TextAlign = ContentAlignment.MiddleLeft;

            Label totalWeight = new Label();
            totalWeight.Dock = DockStyle.Fill;
            totalWeight.Text = string.Format("{0:#,0.000} lbs", shims.TotalWeight);
            totalWeight.TextAlign = ContentAlignment.MiddleLeft;

            Label sdWeights = new Label();
            sdWeights.Dock = DockStyle.Fill;
            sdWeights.Text = string.Format("{0:#,0.000} lbs", shims.ShimsSD);
            sdWeights.TextAlign = ContentAlignment.MiddleLeft;

            Label averageWeight = new Label();
            averageWeight.Dock = DockStyle.Fill;
            averageWeight.Text = string.Format("{0:#,0.000} lbs", shims.Average);
            averageWeight.TextAlign = ContentAlignment.MiddleLeft;

            Label minWeight = new Label();
            minWeight.Dock = DockStyle.Fill;
            minWeight.Text = string.Format("{0:#,0.000} lbs", shims.MinimumWeight);
            minWeight.TextAlign = ContentAlignment.MiddleLeft;

            Label maxWeight = new Label();
            maxWeight.Dock = DockStyle.Fill;
            maxWeight.Text = string.Format("{0:#,0.000} lbs", shims.MaximumWeight);
            maxWeight.TextAlign = ContentAlignment.MiddleLeft;

            tableLayoutPanel1.Controls.Add(totalShimCountLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(totalWeightLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(sdWeightsLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(averageWeightLabel, 0, 3);
            tableLayoutPanel1.Controls.Add(minWeightLabel, 0, 4);
            tableLayoutPanel1.Controls.Add(maxWeightLabel, 0, 5);

            tableLayoutPanel1.Controls.Add(totalShimCount, 1, 0);
            tableLayoutPanel1.Controls.Add(totalWeight, 1, 1);
            tableLayoutPanel1.Controls.Add(sdWeights, 1, 2);
            tableLayoutPanel1.Controls.Add(averageWeight, 1, 3);
            tableLayoutPanel1.Controls.Add(minWeight, 1, 4);
            tableLayoutPanel1.Controls.Add(maxWeight, 1, 5);

            minWeight.Text = string.Format("{0:#,0.000} lbs", shims.MinimumWeight);

            tableLayoutPanel1.AutoSize = true;


        }
    }
}
