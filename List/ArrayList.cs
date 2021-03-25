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
            UpSize();
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
        public void Add(int value)
        {
            if (Length == _array.Length)
            {
                UpSize();
            }
            _array[Length] = value;
            Length++;
        }
        public void AddElementInBeginning(int value)
        {
            if (Length == _array.Length)
            {
                UpSize();
            }
            for(int i = Length; i>=0;i--)
            {
                _array[i] = _array[i + 1];
            }
            _array[0] = value;
            Length++;
        }
        public void RemoveAdd()
        {
            //_array[Length] = 0;
            Length--;
            if (Length < (0.67d * _array.Length + 1))
            {
                ReduceSize();
            }
        }
        public void RemoveFirsElement()
        {
            for (int i = 0; i >= Length; i++)
            {
                _array[i] = _array[i+1];
            }
            Length--;
            if (Length < (0.67d * _array.Length + 1))
            {
                ReduceSize();
            }
        }
        public void DeletByIndex(int value)
        {
            if(Length<(0.67d*_array.Length+1))
            {
                ReduceSize();
            }
            if (value != Length)
            {
                for (int i = value; i <= Length; i++)
                {
                    _array[i] = _array[i + 1];
                }
                Length--;
            }
            else
            {
                Length--;
            }
        }
        public void RemovingNElementsFromTheEnd(int value)
        {
            Length=Length-value;
            if (Length < (0.67d * _array.Length + 1))
            {
                ReduceSize();
            }
        }
        public void RemovingNElementsFromTheBeginning(int value)
        {
            for (int i = 0;i<Length - value;i++)
            {
                _array[i] = _array[i+value];
            }
            Length = Length - value;
            if (Length < (0.67d * _array.Length + 1))
            {
                ReduceSize();
            }
        }
        public void DeletingNElementsByIndex(int index, int count)
        {
            for (int i = index; i < Length - count; i++)
            {
                _array[i] = _array[i+count];
            }
            Length = Length - count;
            if (Length < (_array.Length/2))
            {
                ReduceSize();
            }
        }
        public int FirstIndexByValue(int value)
        {
            for(int i = 0; i<= Length;i++)
            {
                if(_array[i]== value)
                {
                    return i;
                }

            }
            
            return -1;
        } //?

        public int[] Revers()
        {
            int tmp = 0;
            for(int i =0;i<Length/2;i++)
            {
                tmp = _array[i];
                _array[i] = _array[Length-i-1];
                _array[Length] = tmp;
            }
            return _array;
        }
        private void UpSize()
        {
            int newLength = (int)(_array.Length * 1.33d + 1);
            int[] tmpArray = new int[newLength];
            for (int i = 0; i < _array.Length; i++)
            {
                tmpArray[i] = _array[i];
            }
            _array = tmpArray;
        }

        private void ReduceSize()
        {
            int newLength = (int)(_array.Length * 0.67d + 1);
            int[] tmpArray = new int[newLength];
            for (int i = 0; i < _array.Length; i++)
            {
                tmpArray[i] = _array[i];
            }
            _array = tmpArray;
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
