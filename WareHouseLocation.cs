using System;
using System.Collections.Generic;
using System.Text;

namespace HomeExamLibrary
{
    class WareHouseLocation : WareHouse
    {
        public double MaxVolume;
        public double MaxWeight;

        public WareHouseLocation(double height, double width, double depth)
        {
            MaxVolume = height * width * depth;
            MaxWeight = 1000;

        }



    }
}
