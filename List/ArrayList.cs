using System;
using System.Collections.Generic;
using System.Text;

namespace List
{
    public class ArrayList
    {
        public int Length { get; private set; }

        private int[] _array;

        public ArrayList()
        {
            Length = 0;
            _array = new int[10];
        }

        public ArrayList(int value)
        {
            Length = 1;
            _array = new int[10];
            _array[0] = value;
        }

        public ArrayList(int[] value)
        {
            Length = value.Length;
            _array = value;
            Upsize();
        }

        private void Upsize()
        {
            int newLength = (int)(_array.Length * 1.33d + 1);
            int[] tmpArray = new int[newLength];
            for (int i = 0; i < _array.Length; i++)
            {
                tmpArray[i] = _array[i];
            }
            _array = tmpArray;
        }

        public void Add(int value)
        {
            if (Length == _array.Length)
            {
                Upsize();
            }
            _array[Length] = value;
            Length++;
        }

        public int this[int index]
        {
            get
            {
                return _array[index];
            }
            set
            {
                _array[index] = value;
            }
        }

        public override bool Equals(object obj)
        {
            ArrayList arrayList = (ArrayList)obj;
            if (this.Length != arrayList.Length)
            {
                return false;
            }
            for (int i = 0; i < Length; i++)
            {
                if (this._array[i] != arrayList._array[i])
                {
                    return false;
                }
            }
            return true;
        }

        public override string ToString()
        {
            string StringList = "";
            for (int i = 0; i < Length; i++)
            {
                StringList += _array[i] + "";
            }
            return StringList;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
