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
            Console.WriteLine("Funkar!");
            Console.ReadLine();
            MainMenu();
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

    }


}

