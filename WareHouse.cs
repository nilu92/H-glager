using System;
using System.Collections.Generic;
using System.Text;

namespace HomeExamLibrary
{
    public class WareHouse
    {
        public List<I3DStorageObject> Storage { get; }

        List<WareHouseLocation>[] a = new List<WareHouseLocation>[]
             {
                new List<WareHouseLocation>(100),
                new List<WareHouseLocation>(100),
                new List<WareHouseLocation>(100),
             };
        //Kalla på den här när en 'Storage' skapas.  

        public I3DStorageObject CreateCube(double side,double weight, string description, double maxDimension, bool isFragile) 
        {
            Cube cube = new Cube(side,weight,description,maxDimension,isFragile);
            Storage.Add(cube);
            return cube;
        }
        
        public I3DStorageObject CreateCubeoid(double x, double y, double z, double weight,double maxDimension, string description,bool isFragile) 
        {
            Cubeoid cubeoid = new Cubeoid(x,y,z,weight,maxDimension,description,isFragile);
            return cubeoid;
        }
       
        public I3DStorageObject CreateSphere(double radius, double weight,string description,double maxDimension,bool isFragile) 
        {
            Sphere sphere = new Sphere(radius,weight,description,maxDimension,isFragile);
            return sphere;
        }

        public I3DStorageObject CreateBlob(double side, double weight, string description, double maxDimension,bool isFragile) 
        {
            Blob blob = new Blob(side,weight,description,maxDimension,isFragile);
            return blob;
        }
        public I3DStorageObject CreateBox(string description,int storageSpot,double weight,double volume,double area,double maxDimension, bool isFragile, DateTime timeStored)
        {
            Storage storage = new Storage(description,storageSpot,weight,volume,area,maxDimension,isFragile,timeStored);
            Storage.Add(storage);
            //Cannot create an instance of the abstract class or interface 'I3DStorageObject'
            // ska automatiskt lagra lådor
            // Kunna lagra lådor på angiven plats
            return storage;
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
