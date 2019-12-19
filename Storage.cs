using System;
using System.Collections.Generic;
using System.Text;

namespace HomeExamLibrary
{
   public class Storage : I3DStorageObject
    {
        public Storage(string description,int storageSpot,double weight, double volume, double area, double maxDimension, bool isFragile, DateTime timeStored) 
        {
            
            Description = description;
            Weight = weight;
            Volume = volume;
            Area = area;
            MaxDimension = maxDimension;
            IsFragile = isFragile;
            TimeStored = timeStored;
            StorageSpot = storageSpot;
        }
        
        public DateTime TimeStored { get; set; }
        public string Description { get; set; }
        public double Weight { get; set; }
        public double Volume { get; set; }
        public double Area { get; set; }
        public double MaxDimension { get; set; }
        public bool IsFragile { get; set; }

        public int StorageSpot { get; set; }

        public void InsuranceValue()
        {
            throw new NotImplementedException();
        }
    }
}
