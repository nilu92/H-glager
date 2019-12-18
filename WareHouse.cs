﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HomeExamLibrary
{
    public class WareHouse
    {
        

        List<WareHouseLocation>[] a = new List<WareHouseLocation>[]
             {
                new List<WareHouseLocation>(100),
                new List<WareHouseLocation>(100),
                new List<WareHouseLocation>(100),

                
             };
       
            
        public I3DStorageObject CreateCube(int iD,double side,double weight, string description, double maxDimension, bool isFragile) 
        {
            Cube cube = new Cube(iD,side,weight,description,maxDimension,isFragile);
            return cube;
        }
        
        public I3DStorageObject CreateCubeoid(int iD, double x, double y, double z, double weight,double maxDimension, string description,bool isFragile) 
        {
            Cubeoid cubeoid = new Cubeoid(iD,x,y,z,weight,maxDimension,description,isFragile);
            return cubeoid;
        }
       
        public I3DStorageObject CreateSphere(int iD, double radius, double weight,string description,double maxDimension,bool isFragile) 
        {
            Sphere sphere = new Sphere(iD,radius,weight,description,maxDimension,isFragile);
            return sphere;
        }

        public I3DStorageObject CreateBlob(int iD, double side, double weight, string description, double maxDimension) 
        {
            Blob blob = new Blob(iD,side,weight,description,maxDimension);
            return blob;
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
