using System;
using System.Collections.Generic;
using System.Text;

namespace HomeExamLibrary
{
    public class WareHouseLocation : WareHouse
    {

        List<WareHouseLocation>[] locations = new List<WareHouseLocation>[]
        {
            new List<WareHouseLocation>(100),
            new List<WareHouseLocation>(100),
            new List<WareHouseLocation>(100),
        };    

        public double MaxVolume;
        public double MaxWeight;

        public WareHouseLocation(double height, double width, double depth)
        {
            MaxVolume = height * width * depth;
            MaxWeight = 1000;

        }



    }
}
