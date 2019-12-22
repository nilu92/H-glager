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
            //Test
            double Side = 50;
            double weight = 50;
            string description = "kaffe";
            double MaxDimension = 500;
            bool isFragile = true;




           
            var box = wareHouse.CreateCube(Side, weight, description, MaxDimension, isFragile);
            var spot = 5;
            wareHouse.AddStorageManual(box,spot);
            bool didPlace = wareHouse.AddStorageManual(box, spot);
            Console.WriteLine(didPlace);
            Console.WriteLine(box.Weight);
            box = wareHouse.Search(1);
            bool didFind = box.ID == 1;
            Console.WriteLine(didFind);
            wareHouse.Remove(box,1);
            bool didRemove = box.ID == 1;
            Console.WriteLine(didRemove);
            
             

            
            Console.ReadLine();

            
            menu.MainMenu();
            
        }



    }
}
