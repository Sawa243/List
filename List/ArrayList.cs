using System;
using System.Collections.Generic;
using System.Text;

namespace List
{
    public class ArrayList
    {
        private int[] _array;
        public int Length { get; private set; }

        public ArrayList()
        {
            Length = 0;
            _array = new int[10];
        }
        public ArrayList(int value)
        {
            if (value<0)
            {
                throw new ArgumentOutOfRangeException();
            }
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
                if (index<0|| index>Length)
                {
                    throw new IndexOutOfRangeException();
                }
                return _array[index];
            }
            set
            {
                if (index < 0 || index > Length)
                {
                    throw new IndexOutOfRangeException();
                }
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
            for(int i = Length; i> 0; i--)
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
            if (value < 0 || value > Length)
            {
                throw new IndexOutOfRangeException();
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
            if (Length < (0.67d * _array.Length + 1))
            {
                ReduceSize();
            }
        }
        public void RemovingNElementsFromTheEnd(int value)
        {
            if (value > Length || value < 0)
            {
                throw new IndexOutOfRangeException();
            }
            Length =Length-value;
            if (Length < (0.67d * _array.Length + 1))
            {
                ReduceSize();
            }
        }
        public void RemovingNElementsFromTheBeginning(int value)
        {
            if (Length < value || value < 0)
            {
                throw new IndexOutOfRangeException();
            }

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
            if (Length < count || count < 0)
            {
                throw new IndexOutOfRangeException();
            }
            if (index < 0 || index > Length)
            {
                throw new IndexOutOfRangeException();
            }

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
        } 
        public void ChangesByindex (int value, int index)
        {
            if (index < 0 || index >= Length)
            {
                throw new IndexOutOfRangeException();
            }
            _array[index] = value;
        }
        public int AccessByIndex (int index)
        {
            if (index < 0 || index > Length)
            {
                throw new IndexOutOfRangeException();
            }
            return _array[index];
        }
        public void AddByIndex(int value, int index)
        {
            if (Length == _array.Length)
            {
                UpSize();
            }
            if (index < 0 || index > Length)
            {
                throw new IndexOutOfRangeException();
            }
            for (int i = Length; i >= index; i--)
            {
                _array[i] = _array[i + 1];
            }
            _array[index] = value;

            Length++;
        }
        public int TheMaximumElementValue()
        {
            int max = _array[0];
            for (int i = 1; i <= Length; i++)
            {
                if (_array[i] > max)
                {
                    max = _array[i];
                }
            }
            return max;
        }
        public int TheMinElementValue()
        {
            int min = _array[0];
            for (int i = 1; i <= Length; i++)
            {
                if (_array[i] < min)
                {
                    min = _array[i];
                }
            }
            return min;
        }
        public int TheIndexMaxValue()
        {
            int max = _array[0];
            int maxIndex = 0;
            for (int i = 1; i <= Length; i++)
            {
                if (_array[i] > max)
                {
                    max = _array[i];
                    maxIndex = i;
                }
            }
            return maxIndex;
        }
        public int TheIndexMinValue()
        {
            int min = _array[0];
            int Index = 0;
            for (int i = 1; i <= Length; i++)
            {
                if (_array[i] < min)
                {
                    min = _array[i];
                    Index = i;
                }
            }
            return Index;
        }
        public int[] Revers()
        {
            int tmp = 0;
            for(int i = 0; i<Length/2; i++)
            {
                tmp = _array[i];
                _array[i] = _array[Length-i-1];
                _array[Length] = tmp;
            }
            return _array;
        }
        public void SortInAscendingOrder ()
        {
            for (int i = 0; i < Length; i++)
            {
                for (int j = 0; j <= Length - i; j++)
                {
                    if (_array[j] > _array[j + 1])
                    {
                        Swap(ref _array[j], ref _array[j + 1]);
                    }
                }
            }
        }
        public void SortInDescendingOrder()
        {
            for (int i = 0; i < Length - 1; i++)
            {
                int indexOfMax = i;
                for (int j = i; j < Length; j++)
                {
                    if (_array[indexOfMax] < _array[j])
                    {
                        indexOfMax = j;
                    }
                }
                Swap(ref _array[i], ref _array[indexOfMax]);
            }
        }
        private void Swap(ref int e1,ref int e2)
        {
            var temp = e1;
            e1 = e2;
            e2 = temp;
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
                StringList += _array[i] + " ";
            }
            return StringList;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
