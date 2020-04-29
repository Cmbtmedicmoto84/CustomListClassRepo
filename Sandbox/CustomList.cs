using DocumentFormat.OpenXml.Drawing.ChartDrawing;
using DocumentFormat.OpenXml.Office.CustomUI;
using DocumentFormat.OpenXml.Office2013.PowerPoint.Roaming;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class CustomList<T>
    {
        // member variables (HAS A) Declare array to store the elements
        private T[] pieces;
        private int count;

        private int capacity;

        //// constructor (SPAWNER)
        public T this[int index]
        {
            get
            {
                if(index < count && index >= 0)
                {
                    return pieces[index];
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            set
            {
                pieces[index] = value;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }
        }
        public int Capacity
        {
            get
            {
                return capacity;
            }
        }

        public CustomList()
        {
            count = 0;
            capacity = 4;
            pieces = new T[capacity];
        }
        // member methods (CAN DO)
        public void Add(T item)
        { 
            if (count == capacity)
            {
                capacity = capacity * 2;
                T[] tempArray = new T[capacity];
                //pieces is [1, 1, 1, 1]
                //tempArray is [_, _, _, _, _, _, _, _]
                //What can we do to make 
                //tempArray [1, 1, 1, 1, _, _, _, _,]
                tempArray[0] = pieces[0];
                //Instead of hardcoding each index value = each index value
                //use a forloop to automate this for everything in pieces

                for (int i = 0; i < count; i++)
                {
                    tempArray[i] = pieces[i];
                }
                               
            }

            pieces[count] = item;
            count++;  //this method works when I comment this line out.  but every other test fails.
        }

        public void Remove(T item)
        {
            if (count <= capacity)
            {

            }
            pieces[count] = item; //if statements??
            count--;
        }
    }
}
