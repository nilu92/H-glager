using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using HomeExamLibrary;

namespace HomeExam
{
    public class Menu
    {

        public WareHouse wareHouse;
        public WareHouseLocation wareHouseLocation;

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
                Console.WriteLine("**********MENU***********");
                selection = Convert.ToInt32(Console.ReadLine());
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

                selection = Convert.ToInt32(Console.ReadLine());
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

        public void SearchBox()
        {
            Console.WriteLine("Funkar!");
            Console.ReadLine();
            MainMenu();
        }

        public void RemoveBox()
        {
            Console.WriteLine("Funkar!");
            Console.ReadLine();
            MainMenu();
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
            var area = cube.Area;
            var Volume = cube.Volume;
            Console.WriteLine("Side: {0}cm , Weight {1}Kg , Your Description: {2}, IsContent Fragile:{3}\n"+ " The Area of your cube is: {4}cm^2\n"+"The volume of your cube is: {5}cm^3", side, weight, description, isFragile,area,Volume);
            Console.ReadLine();
            wareHouse.AddStorageAuto(cube);
            Console.ReadLine();
            MainMenu();

        }
        public void CreateCubeoid()
        {
            
            //Cubeoid cubeoid = new Cubeoid(1, 2, 3, 4, 100, "", true);
            var maxDimension = 1000;
            Console.WriteLine(" Enter length");
            double x;
            while(!double.TryParse(Console.ReadLine(),out x)) 
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
            var cubeoid = wareHouse.CreateCubeoid(x,y,z,weight,maxDimension,description,isFragile);
            var area = cubeoid.Area;
            var volume = cubeoid.Volume;
            Console.WriteLine("Lenght:{0}cm, Height{1}, Depths{2},Weight{3}, Description :{4},IsFragile:{5}\n"+"Total area: {6}cm\n" + "Total Volume: {7}cm^3",x,y,z,weight,description,isFragile,area,volume);
            wareHouse.AddStorageAuto(cubeoid);
            Console.ReadLine();
            MainMenu();

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
            Console.WriteLine("Radius: {0}cm , Weight: {1}kg,Description: {2},IsFragile: {3}\n"+"Total Area: {4}\n"+"Total Volume: {5}",radius,weight,description,isFragile,area,volume);
            wareHouse.AddStorageAuto(sphere);
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

        }



    }


}

