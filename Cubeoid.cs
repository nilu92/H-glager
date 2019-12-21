using System;
using System.Collections.Generic;
using System.Text;

namespace HomeExamLibrary
{
    public class Cubeoid : I3DStorageObject
    {
        public int iD;
      
        public Cubeoid(double x, double y, double z, double weight, double maxDimension, string description, bool isFragile)
        {
            //formel SA = 2lh + 2wh + 2lw
            Area = 2 * (x * y) + 2 * (z * y) + 2 * (x * z);
            Volume = x * y * z;
            Weight = weight;
            MaxDimension = maxDimension;
            Description = description;
            IsFragile = isFragile;
            ID = iD;
            

        }
        public string Description { get; set; }
        public double Weight { get; set; }
        public double Volume { get; set; }
        public double Area { get; set; }
        public double MaxDimension { get; set; }
        public bool IsFragile { get; set; }

        public int ID { get; set; }
       
        public void InsuranceValue()
        {

        }
    }
}
