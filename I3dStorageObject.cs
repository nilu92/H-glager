using System;

namespace HomeExamLibrary
{
    public interface I3DStorageObject
    {
        string Description { get; set; }
        double Weight { get; set; }
        double Volume { get; set; }
        double Area { get; set; }
        double MaxDimension { get; set; }
         int ID { get; set; }
        bool IsFragile { get; set; }
        int SpotID { get; set; }
        void InsuranceValue();


    }
}
