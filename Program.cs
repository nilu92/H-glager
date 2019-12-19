﻿using System;
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

            // Funkar ju ha bra som helst
            wareHouse.CreateCube(100, 2323, "kaffe", 10000, true); 
                
            
        }



        public void Run()
        {
            menu.MainMenu();
            
        }



    }
}
