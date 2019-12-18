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
        public Storage CreateBox(string description,double weight,double volume,double area,double maxDimension, bool isFragile, DateTime timeStored)
        {
            Storage storage = new Storage(description,weight,volume,area,maxDimension,isFragile,timeStored);
            Storage.Add(storage);
            //Cannot create an instance of the abstract class or interface 'I3DStorageObject'
            // ska automatiskt lagra lådor
            // Kunna lagra lådor på angiven plats
            return storage;
        }
        
        public void RemoveBox(Storage storage) 
        {
            Storage.Remove(storage);
        }
        public Storage SearchForBox(string description) 
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
    
        public void CheckIfMaxWeight() 
        {
        
        
        }     
    }
}
