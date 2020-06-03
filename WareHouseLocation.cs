using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TentaBibliotek
{
    [Serializable]
   public class WareHouseLocation : IEnumerable<I3DStorage>
    {
        
        public List<I3DStorage> Boxes { get; set; }

        internal bool KanLagraFragile { get; set; }
        public double Height { get; }
        public double Width { get; }
        public double Depth { get; }
        public double MaxDimension { get; }
        public double MaxVolume { get; }
        public decimal MaxWeight { get; }
        public WareHouseLocation(double height=200,double width=200,double depth=200)
        {
           this.Boxes = new List<I3DStorage>();
            this.Height = height;
            this.Width = width;
            this.Depth = depth;
            this.KanLagraFragile = true;
            this.MaxDimension = 200;
            this.MaxVolume  = height * width * depth;
            this.MaxWeight = 1000;
            
            
            
            
        }
      public object Clone()
        {
            WareHouseLocation clone = new WareHouseLocation(this.Height, this.Width, this.Depth);
            foreach (I3DStorage box in this.Boxes)
            {
                I3DStorage Copylåda = box.Clone() as I3DStorage;
                clone.Boxes.Add(Copylåda);
            }
            return clone;

        }
       public void Content()
        {
            WareHouseLocation clone = this.Clone() as WareHouseLocation;
            foreach (I3DStorage box in clone.Boxes)
            {
                Console.Write("| {0} ", box);
            }
            Console.WriteLine();
        }


        public int AddLådatolocation(I3DStorage Låda)
        {
           int result = -1;
            decimal currentWeight = 0;
            double currentVolume = 0;
            if (Låda.IsFragile==true && this.KanLagraFragile==true )
            {
                Boxes.Add(Låda);
                this.KanLagraFragile= false;

                result = Låda.ID;
                

            }

          
            foreach (I3DStorage obj in this.Boxes)
            {
                currentWeight = currentWeight + obj.Weight;
                currentVolume = currentVolume + obj.Volume;
            }
            if (currentWeight + Låda.Weight < this.MaxWeight && Låda.MaxDimension < this.MaxDimension && currentVolume < this.MaxVolume && Låda.IsFragile == false)
            {
                this.Boxes.Add(Låda);
                this.KanLagraFragile = false;
                result = Låda.ID;
            }
            return result;
        }
       public int Hittalåda(int id)
        {
            if (Boxes.Count == 0)
            {

            }
            else
            {
                for (int i = 0; i < Boxes.Count; i++)
                {
                    if (Boxes[i].ID == id)
                    {
                        return i;
                    }
                }
               
            }

            return -1; 

        }
     
        public void Tabort(int index)
        {
            if (index == -1)
            {

            }
            else
            {
                Boxes.RemoveAt(index);
            }
        }

        public IEnumerator<I3DStorage> GetEnumerator()
        {
            return this.Boxes.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        public List<I3DStorage> ListOfContent()
        {
            List<I3DStorage> inhålletList = new List<I3DStorage>();
            foreach (I3DStorage box in Boxes)
            {
                inhålletList.Add(box);
            }
            return inhålletList;
        }
    }
}
