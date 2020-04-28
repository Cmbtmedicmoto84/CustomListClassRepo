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
        private int[] pieces;
        private int count;

        private int capacity;

        //// constructor (SPAWNER)
        public int this[int index]
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
            pieces = new int[capacity];
        }
        // member methods (CAN DO)
        public void Add(int item)
        {
            pieces[count] = item;
            count++;
        }
    }
}
