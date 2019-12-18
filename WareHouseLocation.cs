using System;
using System.Collections.Generic;
using System.Text;

namespace HomeExamLibrary
{
    public class WareHouseLocation
    {

        public List<I3DStorageObject> storage;
       
        public double MaxVolume;
        public double MaxWeight;

        public WareHouseLocation(double height, double width, double depth)
        {
            MaxVolume = height * width * depth;
            MaxWeight = 1000;
            storage = new List<I3DStorageObject>();
        }



    }
}
