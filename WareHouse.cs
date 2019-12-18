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
       
        public I3DStorageObject CreateBox(string Description)
        {
            Storage storage = new I3DStorageObject();
           //Cannot create an instance of the abstract class or interface 'I3DStorageObject'
            // ska automatiskt lagra lådor
            // Kunna lagra lådor på angiven plats
            return null;
        }
        public void SearchForBox() 
        {
            //söka efter lådor med hjälp av Description.
            
        }
    
    }
}
