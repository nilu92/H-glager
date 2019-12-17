using System;
using System.Collections.Generic;
using System.Text;

namespace HomeExamLibrary
{
    class Blob : I3DStorageObject
    {
        public double x;
        public double z;
        public double y;
        public Blob(double side, double weight, string description, double maxDimension, bool isFragile)
        {
            x = y = z = side;
            Area = side * side * 6;
            Volume = side * side * side;
            Weight = weight;
            Description = description;
            MaxDimension = maxDimension;
            IsFragile = isFragile;


        }

        public string Description { get; set; }
        public double Weight { get; set; }
        public double Volume { get; set; }
        public double Area { get; set; }
        public double MaxDimension { get; set; }
        public bool IsFragile { get; set; }


        public void InsuranceValue()
        {
            throw new NotImplementedException();
        }

    }
}
