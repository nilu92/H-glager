using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace HomeExamLibrary
{
    public class WareHouse : ICloneable
    {

        public List<WareHouseLocation> locations;
         
        private int iDCounter;
        //WareHouse wareHouse = new WareHouse();
        public WareHouse()
        {
            
            locations = new List<WareHouseLocation>();
            
            for (int i = 0; i < 100; i++)
            {
                WareHouseLocation whl = new WareHouseLocation(150, 150, 150);
                locations.Add(whl);
                whl.FloorID = 1;

            }

            for (int i = 0; i < 100; i++)
            {
                WareHouseLocation whl = new WareHouseLocation(150, 150, 150);
                locations.Add(whl);
                whl.FloorID = 2;

            }
            for (int i = 0; i < 100; i++)
            {
                WareHouseLocation whl = new WareHouseLocation(150, 150, 150);
                locations.Add(whl);
                whl.FloorID = 3;
            }

        }

       
        public I3DStorageObject CreateCube(double side, double weight, string description, double maxDimension, bool isFragile)
        {
            Cube cube = new Cube(side, weight, description, maxDimension, isFragile);
            cube.ID = iDCounter++;

            return cube;
        }

        public I3DStorageObject CreateCubeoid(double x, double y, double z, double weight, double maxDimension, string description, bool isFragile)
        {
            Cubeoid cubeoid = new Cubeoid(x, y, z, weight, maxDimension, description, isFragile);
            cubeoid.ID = iDCounter++;
            return cubeoid;
        }

        public I3DStorageObject CreateSphere(double radius, double weight, string description, double maxDimension, bool isFragile)
        {
            Sphere sphere = new Sphere(radius, weight, description, maxDimension, isFragile);
            sphere.ID = iDCounter++;

            return sphere;
        }

        public I3DStorageObject CreateBlob(double side, double weight, string description, double maxDimension)
        {
            Blob blob = new Blob(side, weight, description, maxDimension);
            blob.ID = iDCounter++;

            return blob;
        }


        public bool AddStorageAuto(I3DStorageObject s)
        {
            foreach (WareHouseLocation wareHouselocation in locations)
            {
                bool available = wareHouselocation.hasAvailableVolumeForObject(s);
                if (available)
                {
                    wareHouselocation.AddtoLocation(s);
                  //  wareHouselocation.storage.Add(s);
                    return true;
                }

            }

            return false;
        }

        public bool AddStorageManual(I3DStorageObject s, int spot)
        {
            WareHouseLocation wareHouseLocation = locations[spot];
            bool available = wareHouseLocation.hasAvailableVolumeForObject(s);
            if (available)
            {
                wareHouseLocation.storage.Add(s);
                return true;
            }

            return false;
        }

        public I3DStorageObject Search(int id)
        {
            foreach (WareHouseLocation whl in locations)
            {
                foreach (I3DStorageObject obj in whl.storage)
                 {
                     
                    if (obj.ID == id)
                    {
                        return obj;
                    }
                    
                }

            }

            return null;
        }

        public bool Remove(int id)
        {
            foreach (WareHouseLocation whl in locations)
            {
                foreach (I3DStorageObject obj in whl.storage)
                {

                    if (obj.ID == id)
                    {
                        whl.Remove(obj);
                        // whl.storage.Remove(obj);
                        return true;
                        
                    }
                }
            }

            return false;
        }
        public bool Move(int id, int spot) 
        {
            foreach (WareHouseLocation wareHouseLocation in locations)
            {
                I3DStorageObject box = Search(id);
                bool didRemove = Remove(id);
                if (didRemove) 
                {
                    bool didPlace = AddStorageManual(box, spot);
                     return didPlace;
                }
            }

            return false;
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }

       

    }


   

}
