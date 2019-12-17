using System;
using System.Collections.Generic;
using System.Text;

namespace HomeExamLibrary
{
    class Cube : I3DStorageObject
    {
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
