using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HomeExamLibrary
{
    public class WareHouseLocation : ICloneable
    {
        public int FloorID { get; set; }
        private List<I3DStorageObject> storage;


        public double MaxVolume;
        public double MaxWeight;

        public WareHouseLocation(double height, double width, double depth)
        {
            storage = new List<I3DStorageObject>();
            
            MaxVolume = height * width * depth;
            MaxWeight = 1000;
        }

        public bool AddtoLocation(I3DStorageObject s) 
        {
            bool avaialable = hasAvailableVolumeForObject(s);
                if(avaialable) 
                {
                    storage.Add(s);
                    return true;
                }
            
            return false;
        }
       
        public bool Remove(I3DStorageObject s, int id) 
        {
            foreach (I3DStorageObject i3DStorageObject in storage)
            {
                    storage.Remove(s);
                    return true;
             }
            return false;
        }

        public I3DStorageObject Search(int id) 
        {
            foreach (I3DStorageObject i3DStorageObject in storage)
            {
                if(i3DStorageObject.ID == id) 
                {
                    return i3DStorageObject;
                }
            }
            return null;
        }

       
        public bool hasAvailableVolumeForObject(I3DStorageObject s)
        {
            double currentVolume = 0;
            

            foreach (I3DStorageObject obj in storage)
            {
                currentVolume += obj.Volume;
            }
          
            double available = MaxVolume - currentVolume;
            

            if (s.Volume <= available)
            {
                return true;
            }
            else
            {
                return false;
            }
        
        }
        public WareHouseLocation ListOfLocations(WareHouseLocation whl)
        {
            foreach (WareHouseLocation wareHouse in storage)
            {
                storage.OrderBy(wareHouseLocation => wareHouseLocation.ID);
                return wareHouse;
            }
            return whl;
        }
        public object Clone()
        {
            var copy = (WareHouseLocation)MemberwiseClone();
            copy.storage = storage.Select(item => (I3DStorageObject)item.Clone()).ToList();

            return copy;
        }
    }
}
