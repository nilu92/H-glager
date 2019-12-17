using System;
using System.Collections.Generic;
using System.Text;

namespace HomeExamLibrary
{
    class Cube : I3DStorageObject
    {
        double x;
        double z;
        double y;
        //constructor
        public Cube(double side, double aArea, double aVolume,double aWeight,string aDescription,double aMaxDimension,bool aIsFragile) 
        {
            x = y = z = side;
            Area = aArea;
            Volume = aVolume;
            Weight = aWeight;
            Description = aDescription;
            MaxDimension = aMaxDimension;
            IsFragile = aIsFragile;
            
            
        }
        public string Description { get; set; }
        public double Weight { get; set; }
        public double Volume { get; set; }
        public double Area { get; set; }
        public double MaxDimension { get; set; }
        public bool IsFragile { get; set; }

        public void InsuranceValue()
        {
           
        }
    }
}
