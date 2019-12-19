using System;
using System.Collections.Generic;
using System.Text;

namespace HomeExamLibrary
{
    public class Sphere : I3DStorageObject
    {
        public int iD;
  
        public Sphere(double radius, double weight, string description, double maxDimension, bool isFragile)
        {

            Area = 4 / 3 * Math.PI * radius * radius * radius;
            Volume = Math.PI * 4 * radius * radius;
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
        public int SpotID { get; set; }
        public void InsuranceValue()
        {
            throw new NotImplementedException();
        }
    }
}
