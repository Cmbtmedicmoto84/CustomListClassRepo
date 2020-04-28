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
        private T[] testList = new T[8];
        int nextList = 8;

        //// constructor (SPAWNER)
        public T this[int i] => testList[i];

        // member methods (CAN DO)
        public void Add(T value)
        {
            if (nextList >= testList.Length)
                throw new IndexOutOfRangeException($"The collection can only hold {testList.Length} elemets.");
            testList[nextList++] = value;
        }
    }
}
