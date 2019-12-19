using System;
using System.Collections.Generic;
using System.Text;

namespace HomeExamLibrary
{
    public class WareHouse
    {
        public WareHouse wareHouse;
        public List<WareHouseLocation> locations = new List<WareHouseLocation>();
        
        private WareHouseLocation whl;


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
     
        private int iDCounter;


        Cube c1 = new Cube(5,10,"Kaffe",100,true);
        public I3DStorageObject CreateCube(double side,double weight, string description, double maxDimension, bool isFragile) 
        {
            Cube cube = new Cube(side,weight,description,maxDimension,isFragile);
            cube.ID = iDCounter++;
            
            return cube;
        }
        
        public I3DStorageObject CreateCubeoid(double x, double y, double z, double weight,double maxDimension, string description,bool isFragile) 
        {
            Cubeoid cubeoid = new Cubeoid(x,y,z,weight,maxDimension,description,isFragile);
            cubeoid.ID = iDCounter++;
            return cubeoid;
        }
       
        public I3DStorageObject CreateSphere(double radius, double weight,string description,double maxDimension,bool isFragile) 
        {
            Sphere sphere = new Sphere(radius,weight,description,maxDimension,isFragile);
            sphere.ID = iDCounter++;
            
            return sphere;
        }

        public I3DStorageObject CreateBlob( double side, double weight, string description, double maxDimension) 
        {
            Blob blob = new Blob(side,weight,description,maxDimension);
            blob.ID = iDCounter++;
            
            return blob;
        }

        public bool AddStorageAuto(I3DStorageObject s)
        {
            double currentVolume = 0;
            
            foreach( I3DStorageObject obj in  storage )
            
            
            foreach (WareHouseLocation wareHouselocation in locations)
            {
                
               
                if (s.Volume >= wareHouselocation.MaxVolume)
                {
                    return true;
                }
              
            }

            return false;
        }

        public int CheckSpotID(int spotID) 
        {
            int i = 0;
            foreach(WareHouseLocation location in locations)
            {
                if(location.FloorID == spotID) 
                {
                    i++; 
                }

                return i;
            }
            return spotID;
        }
        public void RemoveObject(WareHouseLocation box) 
        {
            locations.Remove(box);
        }
       
        
        /* 
        public void RemoveBox(Storage storage) 
        {
            Storage.Remove(storage);
        }
        public I3DStorageObject SearchForBox(string description) 
        {
            foreach (Storage storage in Storage)
            {
                if(storage.Description == description) 
                {
                    return storage;
                }
            }
            //söka efter lådor med hjälp av Description.
            return null;
        }
    
       
        public void CheckIfMaxWeight(double weight ) 
        {
            
        
        }     
    
        public int CheckStorage(int storageSpot) 
        {
            int i = 0;
            foreach (Storage storage in Storage)
            {
                if(storage.StorageSpot == storageSpot) 
                {
                    i++;
                }
            }
            return i;
        }
        //
        public bool CheckifStorageisEmpty(int storageSpot) 
        {
            if(Storage.Count == 0) 
            {
                return false;
            }
            foreach (Storage storage in Storage)
            {
                int check = CheckStorage(storageSpot);
                if(check == 0) 
                {
                    return false;
                }
            }

            return true;
        }
    */
    }
}
