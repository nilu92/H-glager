using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using HomeExamLibrary;

namespace HomeExam
{


    public class Menu
    {

        public WareHouse wareHouse;
        public WareHouseLocation wareHouseLocation;


        double radius;
        double weight;
        string description;
        int maxDimension;
        bool isFragile;


        public Menu()
        {
            wareHouse = new WareHouse();
            wareHouseLocation = new WareHouseLocation(150, 150, 150);
        }

        public void MainMenu()
        {
            Console.Clear();
            DateTime localDate = DateTime.Now;

            int selection;
            do
            {
                Console.WriteLine("**********MENU***********\n" + "[1]AddBox\n" + "[2]SearchBox\n" + "[3]RemoveBox\n" + "[4]MoveBox");
                while (!int.TryParse(Console.ReadLine(), out selection))
                {
                    Console.Clear();
                    MainMenu();
                }
                switch (selection)
                {
                    case 1:
                        AddBox();
                        break;
                    case 2:
                        SearchBox();
                        break;
                    case 3:
                        RemoveBox();
                        break;
                    case 4:
                        break;

                    default:
                        MainMenu();
                        break;
                }


                ;
            } while (selection < 5);

            Console.ReadLine();

        }

        public void AddBox()
        {
            int selection;
            do
            {

                Console.WriteLine("Enter type of shape\n" + "[1]{Cube}\n" + "[2]{Cubeoid}\n" + "[3]{Sphere}\n" + "[4]{Blob}");


                while (!int.TryParse(Console.ReadLine(), out selection))
                {
                    Console.WriteLine("Wrong input!");
                    Console.Clear();
                    AddBox();
                }
                switch (selection)
                {
                    case 1:
                        CreateCube();
                        break;
                    case 2:
                        CreateCubeoid();
                        break;
                    case 3:
                        CreateSphere();
                        break;
                    case 4:
                        CreateBlob();
                        break;
                    case 5:
                        MainMenu();
                        break;
                    default:
                        MainMenu();
                        break;
                }


            } while (selection < 5);

        }



        public void RemoveBox()
        {
            //Sök efter box
            // ta bort box
        }

        public void Move()
        {
            //Sök box som ska flyttas
            //välja plats att flytta till
            //Kolla om plats är ledig
            //Flytta till ledig plats

        }
        public static int UserInt(int input) 
        {
            
            bool wrongInput = true;
             do
            {

                try
                {
                    input = Convert.ToInt32(Console.ReadLine());
                    if (input < 1) throw new Exception();
                    wrongInput = false;
                }
                catch
                {
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong input!\n" +
                        " Try again: ");
                    Console.ResetColor();
                    wrongInput = true;
                }

            } while (wrongInput == true);

            return input;
        }
       
        public  void SearchBox()
        {
            int spot = 0;
            int ID = 0;
            bool exist;
            Console.Clear();
            Console.WriteLine("Enter box ID: ");
             UserInt(ID);
            exist = wareHouse.Contains(ID);
            Console.WriteLine(exist);


        }


        public void CreateCube()
        {
            //Create cube
            var maxDimension = 1000;
            Console.WriteLine("Enter side of the cube");
            double side;
            while (!double.TryParse(Console.ReadLine(), out side))
            {
                Console.WriteLine("Invalid input!");
            }

            Console.WriteLine("enter the weight");
            double weight;
            while (!double.TryParse(Console.ReadLine(), out weight))
            {
                Console.WriteLine("Invalid input!");
            }
            Console.WriteLine("Enter a short description");
            string description = Console.ReadLine();
            while (description.Length > 15)
            {
                Console.WriteLine("Description to long try again...");
                description = Console.ReadLine();
            }
            Console.WriteLine("Is content Fragile?\n" + "[1]Yes\n" + "[2]No");
            string answer = Console.ReadLine();
            bool isFragile = false;
            if (answer == "1" || answer == "Yes" || answer == "yes" || answer == "y" || answer == "Y")
            {
                isFragile = true;
            }
            else
            {
                if (answer == "2" || answer == "No" || answer == "no" || answer == "n" || answer == "N")
                {
                    isFragile = false;
                }
            }

            var cube = wareHouse.CreateCube(side, weight, description, maxDimension, isFragile);

            wareHouse.AddStorageAuto(cube);
            var area = cube.Area;
            var Volume = cube.Volume;
            var ID = cube.ID;
            ID++;
            Console.WriteLine("Side: {0}cm , Weight {1}Kg , Your Description: {2}, IsContent Fragile:{3}, ID:{6}\n" + " The Area of your cube is: {4}cm^2\n" + "The volume of your cube is: {5}cm^3", side, weight, description, isFragile, area, Volume, ID);
            Console.ReadLine();

            MainMenu();

        }
        public void CreateCubeoid()
        {

            //Cubeoid cubeoid = new Cubeoid(1, 2, 3, 4, 100, "", true);
            var maxDimension = 1000;
            Console.WriteLine(" Enter length");
            double x;
            while (!double.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Invalid input!");
            }

            double y;
            Console.WriteLine("Enter Height");
            while (!double.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("Invalid input!");
            }
            double z;
            Console.WriteLine("Enter Depths");
            while (!double.TryParse(Console.ReadLine(), out z))
            {
                Console.WriteLine("Invalid input!");
            }
            double weight;
            Console.WriteLine("Enter weight");
            while (!double.TryParse(Console.ReadLine(), out weight))
            {
                Console.WriteLine("Invalid input!");
            }
            Console.WriteLine("Enter a short description");
            string description = Console.ReadLine();
            while (description.Length > 15)
            {
                Console.WriteLine("Description to long try again...");
                description = Console.ReadLine();
            }
            Console.WriteLine("Is content Fragile?\n" + "[1]Yes\n" + "[2]No");
            string answer = Console.ReadLine();
            bool isFragile = true;
            //bool isFragile = Convert.ToBoolean(answer);
            if (answer == "1" || answer == "Yes" || answer == "yes" || answer == "y" || answer == "Y")
            {
                isFragile = true;
            }
            else
            {
                if (answer == "2" || answer == "No" || answer == "no" || answer == "n" || answer == "N")
                {
                    isFragile = false;
                }
            }

            int id;
            Console.WriteLine("Enter an  Search ID");
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Invalid input!");
            }
            var cubeoid = wareHouse.CreateCubeoid(x, y, z, weight, maxDimension, description, isFragile);
            wareHouse.AddStorageAuto(cubeoid);
            bool didPlace = wareHouse.AddStorageAuto(cubeoid);
            Console.WriteLine(didPlace);

            var area = cubeoid.Area;
            var volume = cubeoid.Volume;
            Console.WriteLine("Lenght:{0}cm, Height{1}, Depths{2},Weight{3}, Description :{4},IsFragile:{5}\n" + "Total area: {6}cm\n" + "Total Volume: {7}cm^3, ID:{8}", x, y, z, weight, description, isFragile, area, volume, id);
            wareHouse.Search(id);
            if (wareHouse == null)
            {
                Console.WriteLine("Does not work!");

            }
            else
            {
                Console.WriteLine("{0}", cubeoid.Description);
            }




            Console.ReadLine();
           // MainMenu();

        }
        public void CreateSphere()
        {
            var maxDimension = 1000;
            Console.WriteLine("Enter Radius");
            double radius;
            while (!double.TryParse(Console.ReadLine(), out radius))
            {
                Console.WriteLine("Invalid input!");
            }
            Console.WriteLine("Enter Weight");
            double weight;
            while (!double.TryParse(Console.ReadLine(), out weight))
            {
                Console.WriteLine("Invalid input!");
            }
            Console.WriteLine("Enter a short description");
            string description = Console.ReadLine();
            while (description.Length > 15)
            {
                Console.WriteLine("Description to long try again...");
                description = Console.ReadLine();
            }
            Console.WriteLine("Is content Fragile?\n" + "[1]Yes\n" + "[2]No");
            string answer = Console.ReadLine();
            bool isFragile = true;
            //bool isFragile = Convert.ToBoolean(answer);
            if (answer == "1" || answer == "Yes" || answer == "yes" || answer == "y" || answer == "Y")
            {
                isFragile = true;
            }
            else
            {
                if (answer == "2" || answer == "No" || answer == "no" || answer == "n" || answer == "N")
                {
                    isFragile = false;
                }
            }

            var sphere = wareHouse.CreateSphere(radius, weight, description, maxDimension, isFragile);
            var area = sphere.Area;
            var volume = sphere.Volume;
            var id = sphere.ID;
            id++;
            Console.WriteLine("Radius: {0}cm , Weight: {1}kg,Description: {2},IsFragile: {3}\n" + "Total Area: {4}\n" + "Total Volume: {5}", radius, weight, description, isFragile, area, volume);
            wareHouse.AddStorageAuto(sphere);
            MainMenu();
        }
        public void CreateBlob()
        {
            var maxDimension = 1000;

            Console.WriteLine("Enter side:");
            double side;
            while (!double.TryParse(Console.ReadLine(), out side))
            {
                Console.WriteLine("Invalid input!");
            }
            Console.WriteLine("Enter weight");
            double weight;
            while (!double.TryParse(Console.ReadLine(), out weight))
            {
                Console.WriteLine("Invalid input!");
            }
            Console.WriteLine("Enter a short description");
            string description = Console.ReadLine();
            while (description.Length > 15)
            {
                Console.WriteLine("Description to long try again...");
                description = Console.ReadLine();
            }
            Console.WriteLine("Enter an  Search ID");
            int ID;
            while (!int.TryParse(Console.ReadLine(), out ID))
            {
                Console.WriteLine("Invalid input!");
            }

            var blob = wareHouse.CreateBlob(side, weight, description, maxDimension);
            var area = blob.Area;
            var volume = blob.Volume;

            wareHouse.AddStorageAuto(blob);
            Console.WriteLine(" Search ID: {5} ,Side:{0}cm,Weight:{1}kg,Description: {2}\n" + "Total Area: {3}cm\n" + "Total volume: {4}cm^", side, weight, description, area, volume, ID);
            Console.ReadLine();
            MainMenu();


        }


    }



}
