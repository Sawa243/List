using System;

namespace List
{
    public class ArrayList
    {
        private int[] _list;
        public int Length { get; set; }

        public int this[int index]
        {
            get
            {
                Exceptions.CheckExceptionIndex(index, Length);
                return _list[index];
            }
            set
            {
                Exceptions.CheckExceptionIndex(index, Length);
                _list[index] = value;
            }
        }

        public ArrayList()
        {
            Length = 0;
            _list = new int[10];
        }

        public ArrayList(int value)
        {
            Length = 1;
            _list = new int[10];
            _list[0] = value;
        }

        public ArrayList(int[] list)
        {
            _list = list;
            Length = _list.Length;
        }

        public void AddValueLastInList(int value)
        {
            AddValueByIndexInList(Length, value);
        }

        public void AddValueByFirstInList(int value)
        {
            AddValueByIndexInList(0, value);
        }

        public void AddValueByIndexInList(int index, int value)
        {
            Exceptions.CheckExceptionIndex(index, Length);
            CheckUpSize();
            for (int i = Length; i > index; i--)
            {
                _list[i] = _list[i - 1];
            }
            _list[index] = value;
            Length++;
        }

        public void RemoveValueInEndInList()
        {
            RemoveGivenQuantityOfValuesByIndexInList(Length);
        }

        public void RemoveValueInStartInList()
        {
            RemoveGivenQuantityOfValuesByIndexInList(0);
        }

        public void RemoveValueByIndexInList(int index)
        {
            Exceptions.CheckExceptionIndex(index, Length);
            RemoveGivenQuantityOfValuesByIndexInList(index);
        }

        public void RemoveGivenQuantityOfValuesTheEndByList(int count)
        {
            Exceptions.CheckExceptionByCountToRemove(count);
            Exceptions.CheckExceptionByCountToRemoveInLast(Length, count);
            for (int i = 0; i < count; i++)
            {
                if (Length == 0)
                {
                    return;
                }
                RemoveGivenQuantityOfValuesByIndexInList(Length);
            }
        }

        public void RemoveGivenQuantityOfValuesTheStartByList(int count)
        {
            Exceptions.CheckExceptionByCountToRemove(count);
            Exceptions.CheckExceptionByCountToRemoveInLast(Length, count);
            RemoveGivenQuantityOfValuesByIndexInList(0, count);
        }

        public void RemoveGivenQuantityOfValuesByIndexInList(int index, int count = 1)
        {
            Exceptions.CheckExceptionIndex(index, Length);
            Exceptions.CheckExceptionByCountToRemoveInLast(Length, count);
            Exceptions.CheckExceptionByCountToRemove(count);
            if (Length != 0)
            {
                for (int i = index; i < Length - count; i++)
                {
                    _list[i] = _list[i + count];
                }
                CheckDownSize(count);
            }
            else
            {
                Exceptions.CheckNullReferenceException(Length);
            }
        }

        public int GetFirstIndexByValue(int value)
        {
            int index = -1;
            for (int i = 0; i < Length; i++)
            {
                if (_list[i] == value)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        public void ChangeValueByIndex(int index, int value)
        {
            Exceptions.CheckExceptionIndex(index, Length);
            _list[index] = value;
        }

        public void ReversList()
        {
            int halfLength = Length / 2;
            for (int i = 0; i < halfLength; i++)
            {
                int tmp = _list[i];
                _list[i] = _list[Length - i - 1];
                _list[Length - i - 1] = tmp;
            }
        }

        public int FindMaxValueByList()
        {
            return _list[FindIndexMaxValueByList()];
        }

        public int FindMinValueByList()
        {
            return _list[FindIndexMinValueByList()];
        }

        public int FindIndexMaxValueByList()
        {
            int index = FindIndexMaxOrMinValueByList();
            return index;
        }

        public int FindIndexMinValueByList()
        {
            int index = FindIndexMaxOrMinValueByList(false);
            return index;
        }

        public void SortAscending()
        {
            SortAscendingOrDescending();
        }

        public void SortDescending()
        {
            SortAscendingOrDescending(false);
        }

        public int RemoveByValueFirstMatchInList(int value)
        {
            return RemoveByValueFirstOrAllMatchInList(value, true);
        }

        public int RemoveByValueAllMatchInList(int value)
        {
            return RemoveByValueFirstOrAllMatchInList(value);
        }

        public void AddNewListToEndList(int[] array)
        {
            AddNewListByIndexInList(Length, array);
        }

        public void AddNewListToBeginList(int[] array)
        {
            AddNewListByIndexInList(0, array);
        }

        public void AddNewListByIndexInList(int index, int[] array)
        {
            Exceptions.CheckExceptionIndex(index, Length);
            CheckUpSize(array.Length);
            int generalLength = Length + array.Length;
            int length = generalLength - array.Length - index;
            for (int i = 0; i < length; i++)
            {
                _list[generalLength - i - 1] = _list[length - i - 1 + index];
            }

            for (int i = 0; i < array.Length; i++)
            {
                _list[index++] = array[i];
                Length++;
            }
        }

        public override bool Equals(object obj)
        {
            ArrayList arrayList = (ArrayList)obj;
            if (arrayList == null)
            {
                return false;
            }
            if (this.Length != arrayList.Length)
            {
                return false;
            }
            for (int i = 0; i < this.Length; i++)
            {
                if (this._list[i] != arrayList._list[i])
                {
                    return false;
                }
            }
            return true;
        }

        public override string ToString()
        {
            string arrayToString = "";
            for (int i = 0; i < Length; i++)
            {
                arrayToString += $"{_list[i]} ";
            }
            return arrayToString;
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }

        private int RemoveByValueFirstOrAllMatchInList(int value, bool oneElement = false)
        {
            int count = 0;
            int index = -1;
            for (int i = 0; i < Length; i++)
            {
                if (_list[i] == value)
                {
                    RemoveGivenQuantityOfValuesByIndexInList(i);
                    if (oneElement)
                    {
                        index = i;
                        break;
                    }
                    i--;
                    count++;
                }
            }
            if (oneElement)
            {
                return index;
            }
            return count;
        }

        private void SortAscendingOrDescending(bool signUpOrDown = true)
        {
            int tmp;
            for (int i = 0; i < Length - 1; i++)
            {
                for (int j = i + 1; j < Length; j++)
                {
                    if (CheckingSignUpOrDown(_list[j], _list[i], signUpOrDown))
                    {
                        tmp = _list[j];
                        _list[j] = _list[i];
                        _list[i] = tmp;
                    }
                }
            }
        }
        private int FindIndexMaxOrMinValueByList(bool maxOrMin = true)
        {
            Exceptions.CheckNullReferenceException(Length);
            int index = 0;
            int tmp = _list[0];
            for (int i = 0; i < Length; i++)
            {
                if (CheckingSignUpOrDown(tmp, _list[i], maxOrMin))
                {
                    tmp = _list[i];
                    index = i;
                }
            }
            return index;
        }

        private static bool CheckingSignUpOrDown(int tmp, int current, bool signUpOrDown = true)
        {
            if (tmp < current && signUpOrDown ||
               tmp > current && !signUpOrDown)
            {
                return true;
            }
            return false;
        }

        private void CheckUpSize(int length = 0)
        {
            if (Length + length >= _list.Length)
            {
                UpSize(length);
            }
        }

        private void CheckDownSize(int length = 1)
        {
            Length -= length;
            if (Length < (_list.Length / 2))
            {
                DownSize();
            }
        }

        private void UpSize(int length = 0)
        {
            int newLength = (int)((_list.Length + length + 1) * 1.33d);
            int[] tmpList = new int[newLength];
            for (int i = 0; i < _list.Length; i++)
            {
                tmpList[i] = _list[i];
            }
            _list = tmpList;
        }
        private void DownSize()
        {
            int newLength = (int)(_list.Length * 0.67d + 1);
            int[] tmpList = new int[newLength];
            for (int i = 0; i < tmpList.Length; i++)
            {
                tmpList[i] = _list[i];
            }
            _list = tmpList;
        }
    }
}
