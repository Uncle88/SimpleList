using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleListApp
{
    class MyArrayList : IList
    {
        int index;
<<<<<<< HEAD
        const double size = 2;
=======
        const  double size = 2;
>>>>>>> 1665d406c0ae18a8821e054fd4da612555fae116
        double pov = 2;
        int currentValue;

        object[] myMass;

        public MyArrayList()
        {
            currentValue = (int)Math.Pow(size, pov);
            myMass = new object[currentValue];

        }

        public object this[int index]
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public int Count
        {
            get
            {
                return myMass.Length;
                //hello from Alex' computer
            }
        }

        public bool IsFixedSize
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool IsReadOnly
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool IsSynchronized
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public object SyncRoot
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int Add(object value)
        {
            myMass[index++] = value;
            if (index == currentValue)
            {
                currentValue = (int)Math.Pow(size, ++pov);
                object[] temp = new object[currentValue];
                for (int i = 0; i < index; i++)
                {
                    temp[i] = myMass[i];
                }

                myMass = temp;
            }

            return index;
        }

        public void Clear()
        {
<<<<<<< HEAD
            pov=2;
=======
            pov = 2;
>>>>>>> 1665d406c0ae18a8821e054fd4da612555fae116
            currentValue = (int)Math.Pow(size, pov);
            myMass = new object[currentValue];
        }

        public bool Contains(object value)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(Array array)
        {
            object[] Array = new object[currentValue];
            for (int i = 0; i < index; i++)
            {
                Array[i] = myMass[i];
            }

        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(object value)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, object value)
        {
            throw new NotImplementedException();
        }

        public void Remove(object value)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

       
    }
}
