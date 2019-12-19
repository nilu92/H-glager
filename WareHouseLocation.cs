using System;
using System.Collections.Generic;
using System.Text;

namespace HomeExamLibrary
{
    public class WareHouseLocation
    {
        public int FloorID { get; set; }
        public List<I3DStorageObject> storage = new List<I3DStorageObject>();


        public double MaxVolume;
        public double MaxWeight;

        public WareHouseLocation(double height, double width, double depth)
        {
            MaxVolume = height * width * depth;
            MaxWeight = 1000;
        }


        public bool hasAvailableVolumeForObject(I3DStorageObject s)
        {
            double currentVolume = 0;

            foreach (I3DStorageObject obj in storage)
            {
                currentVolume += obj.Volume;
            }

            bool available = MaxVolume - currentVolume;
            if (s.Volume <= available)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
