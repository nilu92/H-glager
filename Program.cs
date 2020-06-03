using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeExamLibrary;

namespace HomeExam
{
    
    
    class Program
    {
        public Menu menu;
        public WareHouse wareHouse;
        public WareHouseLocation wareHouseLocation;
        static void Main(string[] args)
        {
           
            /*Cube c1 = new Cube(5, 10, "111111", 100, true);
            Cubeoid Test = new Cubeoid(100, 50, 35, 150, 150, "hjg", true);
            
            Console.WriteLine(" Cube Area: {0} ,  Volume: {1}",c1.Area,c1.Volume);
            Console.WriteLine(" Cubeoid Area: {0} ,  Volume: {1}", Test.Area, Test.Volume);
            */
            new Program().Run();
          
        }
        public Program() 
        {
            menu = new Menu();
            wareHouse = new WareHouse();
            wareHouseLocation = new WareHouseLocation(150,150,150);

            // Funkar ju ha bra som helst
            wareHouse.CreateCube(100, 2323, "kaffe", 10000, true); 
                
            
        }



        public void Run()
        {
            
            //Test cube
            double Side = 50;
            double weight = 50;
            string description = "kaffe";
            double MaxDimension = 500;
            bool isFragile = true;

            //Test Cubeoid
            double x = 5;
            double y = 5;
            double z = 5;
          
            int ID = 1;
            var box = wareHouse.CreateCube(Side, weight, description, MaxDimension, isFragile);
            var spot = 5;
            wareHouse.AddStorageManual(box,spot);
            bool didPlace = wareHouse.AddStorageManual(box, spot);
            Console.WriteLine(didPlace);
            Console.WriteLine(box.Weight);
            box = wareHouse.Search(ID);
            bool didFind = box.ID == 1;
            Console.WriteLine("{0},{1}",didFind,spot);

            var cubeoid = wareHouse.CreateCubeoid(x, y, z, weight, MaxDimension, description, isFragile);
            wareHouse.AddStorageAuto(cubeoid);
            Console.ReadLine();
            wareHouse.Remove(cubeoid,ID);
            Console.ReadLine();
            bool didRemove = wareHouse.Remove(cubeoid, ID);
            Console.WriteLine(didRemove);
            
          


    

           
           
             menu.MainMenu();
            
        }



    }
}
