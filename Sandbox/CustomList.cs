using DocumentFormat.OpenXml.Drawing.ChartDrawing;
using DocumentFormat.OpenXml.Office.CustomUI;
using DocumentFormat.OpenXml.Office2013.PowerPoint.Roaming;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class CustomList<T>
    {
        // member variables (HAS A) Declare array to store the elements
        private T[] items;
        private int count;

        private int capacity;

        //// constructor (SPAWNER)
        public T this[int index]
        {
            get
            {
                if(index < count && index >= 0) 
                {
                    return items[index];
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            set
            {
                items[index] = value;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }

        }
        public virtual int Capacity 
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
            items = new T[capacity];
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < capacity; i++)
            {
                yield return items[i];
            }
        }

        // member methods (CAN DO)
        public void Add(T item)
        {
            if (count == capacity)
            {
                capacity = capacity * 2;
                T[] tempArray = new T[capacity];

                for (int i = 0; i < count; i++)
                {
                    tempArray[i] = items[i];  //just added
                }
                items = tempArray;
            }
            items[count] = item;  //changed to 'item'
            count++;
        }
        
        //What can we do to make 
        //tempArray [1, 1, 1, 1, _, _, _, _,]
        //tempArray[0] = pieces[0];
        //Instead of hardcoding each index value = each index value
        //use a forloop to automate this for everything in pieces


        public virtual void Remove(T item)
        {
             
            if (count >= capacity)
            {

            }
            items[count] = item; //if statements??
            count--;
        }
    }
}
