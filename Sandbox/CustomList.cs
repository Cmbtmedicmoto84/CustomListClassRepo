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
            }
            pieces[count] = item;
            count++;
            
            
        }

        public void Remove(T item)
        {
            pieces[count] = item; //if statements??
            count--;
        }
    }
}
