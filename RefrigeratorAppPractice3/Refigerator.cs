using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefrigeratorAppPractice3
{
    public class Refigerator
    {
        
        public double maxweight { set; get; }
        public double noOfItems { set; get; }
        public double unitOfWeight { set; get; }
        //public List<double> maxweight = new List<double>();
        //public List<double> noOfItems = new List<double>();
        //public List<double> unitOfWeight = new List<double>();
        //public List<double> remainingWeight = new List<double>();

        public double GetRemainingWeight()
        {
            double remainingWeight = maxweight - (noOfItems * unitOfWeight);
            return remainingWeight;
        }
        public double GetCurrentWeight()

        {
            double currentWeight = noOfItems * unitOfWeight;
            return currentWeight;

        }
    }
   
   
    
}
      
    

