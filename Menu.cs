using System;
using HomeExamLibrary;

namespace HomeExam
{
    public class Menu
    {
        public Menu() 
        {
        
        }

        public void MainMenu()
        {
            DateTime localDate = DateTime.Now;

            int selection;
            do
            {
                Console.WriteLine("**********MENU***********");
                selection = Convert.ToInt32(Console.ReadLine());
                switch (selection)
                {
                    case 1:
                        break;
                    
                    case 2:
                        break;
                    case 3:
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

    }


}

