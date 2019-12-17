using System;
using System.Collections.Generic;
using System.Text;

namespace HomeExamLibrary
{
    class Cubeoid : I3DStorageObject
    {
        public Cubeoid(double x, double y,double z,  double weight,double maxDimension, string description,bool isFragile) 
        {
            Area = 
            Volume = 
            Weight = weight;
            MaxDimension = maxDimension;
            Description = description;
            IsFragile = isFragile;

           
        
        }
        public string Description { get; set; }
        public double Weight { get; set; }
        public double Volume { get ; set; }
        public double Area { get; set; }
        public double MaxDimension { get ; set ; }
        public bool IsFragile { get; set ; }

        public void InsuranceValue()
        {
         
        }
    }
}
