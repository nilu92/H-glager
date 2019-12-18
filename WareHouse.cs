using System;
using System.Collections.Generic;
using System.Text;

namespace HomeExamLibrary
{
    public class WareHouse
    {
        public List<I3DStorageObject> Storage { get; }
        public WareHouse()
        {
            Storage = new List<I3DStorageObject>();
        }
       
      //Kalla på den här när en 'Storage' skapas.  
        
        public I3DStorageObject createCube(double side,double weight, string description, double maxDimension, bool isFragile) 
        {
            Cube cube = new Cube(side,weight,description,maxDimension,isFragile);
            Storage.Add(cube);
            return cube;
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
