﻿using System;

namespace HomeExamLibrary
{
    public interface I3DStorageObject : ICloneable
    {
        string Description { get; set; }
        double Weight { get; set; }
        double Volume { get; set; }
        double Area { get; set; }
        double MaxDimension { get; set; }
         int ID { get; set; }
        bool IsFragile { get; set; }
      
        void InsuranceValue();


    }
}
