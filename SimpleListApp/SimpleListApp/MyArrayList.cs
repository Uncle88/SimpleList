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
        const double size = 2;
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
                return myMass[index];
            }

            set
            {
                myMass[index] = value;
            }
        }

        public int Count
        {
            get
            {
                return myMass.Length;
                //hello from Alex' computer
                //Second hello from Alex
                //What the @hello from Alex' computer@ & second????
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
            pov=2;
            currentValue = (int)Math.Pow(size, pov);
            myMass = new object[currentValue];
        }

        public bool Contains (object value)
        {
            object a= null;
            for (int i = 0; i < currentValue; i++)
            {
                object s = myMass[i];
                if (a == s)
                {
                    return true;
                }
                else
                    return false;
            }
            return false;
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
            return (IEnumerator)GetEnumerator();
        }

        public int IndexOf(object value)
        {
            object a = null;
            for (int i = 0; i < currentValue; i++)
            {
                if (a == myMass[i])
                {
                    return i;
                }
            }
            return -1;
        }

        public void Insert(int index, object value)
        {
            {
                if ((currentValue + 1 <= myMass.Length) && (index < Count) && (index >= 0))
                {
                    currentValue++;

                    for (int i = Count - 1; i > index; i--)
                    {
                        myMass[i] = myMass[i - 1];
                    }
                    myMass[index] = value;
                }
            }
        }

        public void Remove(object value)
        {
            RemoveAt(IndexOf(value));
        }

        public void RemoveAt(int index)
        {
            if ((index >= 0) && (index < Count))
            {
                for (int i = index; i < Count - 1; i++)
                {
                    myMass[i] = myMass[i + 1];
                }
                currentValue--;
            }
        }

        public void CopyTo (Array array, int index)
        {
            int j = index;
            for (int i = 0; i < Count; i++)
            {
                array.SetValue(myMass[i], j);
                j++;
            }
        }
    }
}
