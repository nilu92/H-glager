using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Threading;
using System.Linq;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using TentaBibliotek;


namespace TentaBibliotek
{
    [Serializable]

    public class WareHouse

    {


        public int ID = 99;
        WareHouseLocation[,] Höglager = new WareHouseLocation[4, 101];
        public List<int> IDLåda { get; set; }
        //public WareHouseLocation warehousetest = new WareHouseLocation();
       
        public WareHouse()
        {

            for (int floor = 1; floor < Höglager.GetLength(0); floor++)
            {
                for (int collumn = 1; collumn < Höglager.GetLength(1); collumn++)
                {
                    Höglager[floor, collumn] = new WareHouseLocation();
                }
            }
            this.ID = Få_ID();

       

        }
        public int Få_ID()
        {
            for (int floor = 1; floor < Höglager.GetLength(0); floor++)
            {
                for (int collumn = 1; collumn < Höglager.GetLength(1); collumn++)
                {
                    if (Höglager[floor, collumn].Boxes.Count == 0)
                    {
                        
                    }
                    else
                    {
                        foreach (I3DStorage box in Höglager[floor, collumn].Boxes)
                        {
                            this.ID++;
                        }
                    }

                }
            }
            return this.ID + 1;
        }

        



        public int Konverteraochläggtillplats(UserInputLåda userLåda, int specifikplats, int våning = 0, int plats = 0)
        {
           int result = -1;
            if (userLåda.Description == "Cube")
            {
                Cube cube = new Cube(userLåda.Side,this.ID, userLåda.Description, userLåda.Weight, userLåda.isFragile,userLåda.Insured);
                if (specifikplats == 1)
                {
                    result = LäggtillSpecifikWareHouseLocation(cube, våning, plats);
                }
                else if (specifikplats == 2)
                {
                    result = läggadirekttillWareHouseLocation(cube);
                }
            }
            if (userLåda.Description == "Blob")
            {
                Blob blob = new Blob(userLåda.Side, this.ID, userLåda.Weight, userLåda.Description,userLåda.Insured );
                if (specifikplats == 1)
                {
                   result = LäggtillSpecifikWareHouseLocation(blob, våning, plats);
                }
                else if (specifikplats == 2)
                {
                    result = läggadirekttillWareHouseLocation(blob);
                }
            }
            if (userLåda.Description == "Sphere")
            {
                Sphere sphere = new Sphere(userLåda.Side / 2, this.ID, userLåda.Weight, userLåda.Description, userLåda.isFragile,userLåda.Insured);
                if (specifikplats == 1)
                {
                    result= LäggtillSpecifikWareHouseLocation(sphere, våning, plats);
                }
                else if (specifikplats == 2)
                {
                    result = läggadirekttillWareHouseLocation(sphere);
                }
            }
            if (userLåda.Description == "Cubeoid")
            {
                Cubeoid cubeoid = new Cubeoid(userLåda.XSide, userLåda.YSide, userLåda.ZSide, this.ID, userLåda.Weight, userLåda.Description, userLåda.isFragile,userLåda.Insured);
                if (specifikplats == 1)
                {
                    result = LäggtillSpecifikWareHouseLocation(cubeoid, våning, plats);
                }
                else if (specifikplats == 2)
                {
                    result = läggadirekttillWareHouseLocation(cubeoid);
                }
            }
            if (result!=-1)
            {
                this.ID++;
            }
            return result;
        }
        public  int LäggtillSpecifikWareHouseLocation(I3DStorage låda, int våning, int plats)
        {
            int result = -1;
            if (Höglager[våning, plats].AddLådatolocation(låda)!=-1)
            {
                
               result= låda.ID;
            }
            else if(Höglager[våning, plats].AddLådatolocation(låda)==-1)
            {
                result=-1;
            }
            return result;


            

            


        }
        public void SkrivUT()
        {


            for (int floor = 1; floor < Höglager.GetLength(0); floor++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Våning {0}", floor);
                Console.ForegroundColor = ConsoleColor.White;

                for (int collumn = 1; collumn < Höglager.GetLength(1); collumn++)
                {
                    Console.Write("Plats {0}: ", collumn);
                    Höglager [floor, collumn].Content();
                }
                if (floor <= 2)
                {
                    Console.WriteLine("Tryck enter för nästa våning");
                    Console.ReadKey();
                    Console.Clear();
                }

            }


        }
        public int läggadirekttillWareHouseLocation(I3DStorage userLåda)
        {
            int result = -1;

            for (int våning = 1; våning< Höglager.GetLength(0); våning++)
            {
                for (int plats = 1; plats < Höglager.GetLength(1); plats++)
                {

                    result = Höglager[våning, plats].AddLådatolocation(userLåda);
                    if(result !=-1)
                    {
                        
                        result= userLåda.ID;
                        return result;
                    }
                }
                //break;
            }
            return result;
        }
        public int[] HittaLådaviaID(int ID)
        {
            int[] index = new int[2];
            index[0] = -1; 
            int found; 
            for (int våning = 1; våning < Höglager.GetLength(0); våning++)
            {
                for (int plats = 1; plats < Höglager.GetLength(1); plats++)
                {
                    found = Höglager[våning, plats].Hittalåda(ID);
                    if (found != -1)
                    {
                        index[0] = våning;
                        index[1] = plats;
                        return index;
                    }
                }
            }
            return index; 
        }
        public int FlyttaLådaviaIdVåningPlats(int ID, int våning, int plats)
        {
            int result = -1;
            int[] index = new int[2];
             index = HittaLådaviaID(ID);
            if (index[0] == -1)
            {
                
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Lådan som du vill flytta finns inte  ");
                Console.WriteLine(" Bekräfta ID Lådan igen!! ");
                Console.WriteLine(" Försöka igen  ");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                int indexplats = Höglager[index[0], index[1]].Hittalåda(ID);
               I3DStorage lådatillflytta = Höglager[index[0], index[1]].Boxes[indexplats].Clone() as I3DStorage;
                result = LäggtillSpecifikWareHouseLocation(lådatillflytta, våning, plats);
                if (result!=-1)
                {
                    Höglager[index[0], index[1]].Tabort(indexplats);
                }
            }
            return result;
        }
        public void TaBortLådaviaID(int ID)
        {
            int[] index = new int[2];

            index = HittaLådaviaID(ID);
            if (index[0] == -1)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Kunde inte hitta lådan att ta bort.");
                Console.WriteLine(" Bekräfta ID Lådan igen!! ");
                Console.WriteLine(" Försöka igen  ");
                Console.ForegroundColor = ConsoleColor.White;

            }
            else
            {
                int indexLager = Höglager[index[0], index[1]].Hittalåda(ID);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Lådan  Har tagit bort :\n {0}  ", Höglager[index[0], index[1]].Boxes[indexLager]);
                Console.ForegroundColor = ConsoleColor.White;

                Höglager[index[0], index[1]].Tabort(indexLager);
                Console.ReadKey();
            }

        }
        public object Clone(int våning, int plats)
        {
            WareHouseLocation copy = Höglager[våning, plats].Clone() as WareHouseLocation;
            return copy;
        }
        public WareHouseLocation this[int index1, int index2]
        {
            get { return this.Höglager[index1, index2]; }
            set { this.Höglager[index1, index2] = value; }
        }
        public void skrivinFile(WareHouse ObjectförskrinIn)
        {
            string Fileadress = "HÖLAGER.txt";
            using (Stream str = File.Open(Fileadress, FileMode.Create))
            {
                var file = new BinaryFormatter();
                file.Serialize(str, ObjectförskrinIn);
                str.Close();
            }
        }
        public WareHouse LäsaFile()
        {
            string Fileadress = "HÖLAGER.txt";
            using (Stream str = File.Open(Fileadress, FileMode.OpenOrCreate))
            {
                var file = new BinaryFormatter();
                
                return file.Deserialize(str) as WareHouse;
            }
        }






    }
}
       
    

