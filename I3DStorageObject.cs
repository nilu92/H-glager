﻿using System;

namespace Library
{
    public interface I3DStorageObject
    {

        string Description { get; set; }
        double Weight { get; set; }
        double Volume { get; set; }
        double Area { get; set; }
        double MaxDimension { get; set; }

        bool IsFragile { get; set; }

        void InsuranceValue();
    }
}
