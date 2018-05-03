using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_Numbers_Final
{

    public class Shims
    {
        private int count;
        private List<double> shimsWeight;
        private double totalWeight;
        private double average;
        private double shimsSD;
        private double minimumWeight;
        private double maximumWeight;

        public Shims()
        {
            this.shimsWeight = new List<double>();
        }

        public int Count { get => count; set => count = value; }
        public List<double> ShimsWeight { get => shimsWeight; set => shimsWeight = value; }
        public double TotalWeight
        {

            get
            {
                CalculateShimsWeight();
                return totalWeight;
            }
        }
        public double Average
        {
            get
            {
                CalculateAverage();
                return average;
            }
        }
        public double ShimsSD
        {
            get
            {
                CalculateSD();
                return shimsSD;
            }
        }
        public double MinimumWeight
        {
            get
            {
                CalculateMin();
                return minimumWeight;
            }
        }
        public double MaximumWeight
        {
            get
            {
                CalculateMax();
                return maximumWeight;
            }
        }
        public void CalculateShimsWeight()
        {
            totalWeight = 0;
            for (int i = 0; i < count; i++)
            {
                totalWeight = totalWeight + shimsWeight[i];
            }
        }

        public void CalculateAverage()
        {
            average = shimsWeight.Average();
        }

        public void CalculateSD()
        {
            double sumOfSquaresOfDifferences = shimsWeight.Select(val => (val - average) * (val - average)).Sum();
            shimsSD = Math.Sqrt(sumOfSquaresOfDifferences / shimsWeight.Count);
        }

        public void CalculateMin()
        {
            minimumWeight = shimsWeight.Min();
        }

        public void CalculateMax()
        {
            maximumWeight = shimsWeight.Max();
        }
    }
}
