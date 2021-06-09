using NUnit.Framework;
using List;
using System;

namespace ListsTests
{
    class ArrayListTests
    {
        
        [TestCase(9, new[] { 5, 6, 6, 1 }, new[] { 5, 6, 6, 1, 9 })]
        [TestCase(68, new int[] { }, new[] { 68 })]
        [TestCase(-5, new[] { 5 }, new[] { 5, -5 })]
        public void AddValueLastInList_Tests(int value, int[] actualArray, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(actualArray);
            actual.AddValueLastInList(value);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(9, new[] { 5, 6, 6, 1 }, new[] { 9, 5, 6, 6, 1 })]
        [TestCase(68, new int[] { }, new[] { 68 })]
        [TestCase(-5, new[] { 5 }, new[] { -5, 5 })]
        public void AddValueByFirstInList_Tests(int value, int[] actualArray, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(actualArray);
            actual.AddValueByFirstInList(value);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(9, new[] { 5, 6, 6, 1 }, new[] { 5, 9, 6, 6, 1 }, 1)]
        [TestCase(68, new int[] { }, new[] { 68 })]
        [TestCase(-5, new[] { 5 }, new[] { -5, 5 })]
        public void AddValueByIndexInList_Tests(int value, int[] actualArray, int[] expectedArray, int index = 0)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(actualArray);
            actual.AddValueByIndexInList(index, value);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 5, 6, 6, 1 }, new[] { 5, 6, 6, })]
        [TestCase(new[] { 1 }, new int[] { })]
        [TestCase(new[] { 5, 9, 0 }, new[] { 5, 9 })]
        public void RemoveValueInEndInList_Tests(int[] actualArray, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(actualArray);
            actual.RemoveValueInEndInList();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 5, 6, 6, 1 }, new[] { 6, 6, 1 })]
        [TestCase(new[] { 1 }, new int[] { })]
        [TestCase(new[] { 5, 9, 0 }, new[] { 9, 0 })]
        public void RemoveValueInStartInList_Tests(int[] actualArray, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(actualArray);
            actual.RemoveValueInStartInList();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 5, 6, 7, 1 }, new[] { 5, 6, 7 }, 3)]
        [TestCase(new[] { 1 }, new int[] { })]
        [TestCase(new[] { 5, 9, 0 }, new[] { 5, 0 }, 1)]
        public void RemoveValueByIndexInList_Tests(int[] actualArray, int[] expectedArray, int index = 0)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(actualArray);
            actual.RemoveValueByIndexInList(index);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 5, 6, 7, 1 }, new[] { 5, 6 }, 2)]
        [TestCase(new[] { 1 }, new int[] { }, 1)]
        [TestCase(new[] { 5, 9, 0 }, new[] { 5, 9, 0 })]
        public void RemoveGivenQuantityOfValuesTheEndByList_Tests(int[] actualArray, int[] expectedArray, int count = 0)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(actualArray);
            actual.RemoveGivenQuantityOfValuesTheEndByList(count);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 5, 6, 7, 1 }, new[] { 7, 1 }, 2)]
        [TestCase(new[] { 1 }, new int[] { }, 1)]
        [TestCase(new[] { 5, 9, 0 }, new[] { 5, 9, 0 })]
        public void RemoveGivenQuantityOfValuesTheStartByList_Tests(int[] actualArray, int[] expectedArray, int count = 0)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(actualArray);
            actual.RemoveGivenQuantityOfValuesTheStartByList(count);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 5, 6, 7, 1 }, new[] { 5, 6 }, 2, 2)]
        [TestCase(new[] { 1 }, new int[] { }, 0, 1)]
        [TestCase(new[] { 5, 9, 0 }, new[] { 5, 9, 0 })]
        public void RemoveGivenQuantityOfValuesByIndexInList_Tests(int[] actualArray, int[] expectedArray, int index = 0, int count = 0)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(actualArray);
            actual.RemoveGivenQuantityOfValuesByIndexInList(index, count);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 5, 6, 7, 1 }, 1, 3)]
        [TestCase(new[] { 1 }, 1, 0)]
        [TestCase(new[] { 9, 9, 5, 0 }, 5, 2)]
        public void GetFirstIndexByValueTests(int[] actualArray, int value, int expectedArray)
        {
            int expected = expectedArray;
            ArrayList list = new ArrayList(actualArray);
            int actual = list.GetFirstIndexByValue(value);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 5, 6, 7, 1 }, 1, 3, new[] { 5, 3, 7, 1 })]
        [TestCase(new[] { 1 }, 0, 5, new[] { 5 })]
        [TestCase(new[] { 9, 9, 5, 0 }, 2, 2, new[] { 9, 9, 2, 0 })]
        public void ChangeValueByIndexTests(int[] actualArray, int index, int value, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(actualArray);
            actual.ChangeValueByIndex(index, value);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 6, 7, 1 }, new[] { 1, 7, 6 })]
        [TestCase(new[] { 1 }, new[] { 1 })]
        [TestCase(new[] { 9, 9, 5, 0 }, new[] { 0, 5, 9, 9 })]
        public void ReversList_Tests(int[] actualArray, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(actualArray);
            actual.ReversList();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 6, 7, 1 }, 7)]
        [TestCase(new[] { 1 }, 1)]
        [TestCase(new[] { 9, 9, 5, 0 }, 9)]
        [TestCase(new[] { -9, -29, -5, 0 }, 0)]
        public void FindMaxValueByList_Tests(int[] actualArray, int expectedArray)
        {
            int expected = expectedArray;
            ArrayList list = new ArrayList(actualArray);
            int actual = list.FindMaxValueByList();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 6, 7, 1 }, 1)]
        [TestCase(new[] { 1 }, 1)]
        [TestCase(new[] { 9, 9, 5, 0 }, 0)]
        [TestCase(new[] { -9, -29, -5, 0 }, -29)]
        public void FindMinValueByList_Tests(int[] actualArray, int expectedArray)
        {
            int expected = expectedArray;
            ArrayList list = new ArrayList(actualArray);
            int actual = list.FindMinValueByList();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 6, 7, 1 }, 1)]
        [TestCase(new[] { 1 }, 0)]
        [TestCase(new[] { 9, 9, 5, 0 }, 0)]
        [TestCase(new[] { -9, -29, -5, 0 }, 3)]
        public void FindIndexMaxValueByList_Tests(int[] actualArray, int expectedArray)
        {
            int expected = expectedArray;
            ArrayList list = new ArrayList(actualArray);
            int actual = list.FindIndexMaxValueByList();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 6, 7, 1 }, 2)]
        [TestCase(new[] { 1 }, 0)]
        [TestCase(new[] { 9, 9, 5, 0 }, 3)]
        [TestCase(new[] { -9, -29, -5, 0 }, 1)]
        public void FindIndexMinValueByList_Tests(int[] actualArray, int expectedArray)
        {
            int expected = expectedArray;
            ArrayList list = new ArrayList(actualArray);
            int actual = list.FindIndexMinValueByList();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 6, 7, 1 }, new[] { 1, 6, 7 })]
        [TestCase(new[] { 1 }, new[] { 1 })]
        [TestCase(new[] { 9, 9, 5, 0 }, new[] { 0, 5, 9, 9 })]
        [TestCase(new[] { -9, -29, -5, 0 }, new[] { -29, -9, -5, 0 })]
        public void SortAscendingTests(int[] actualArray, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(actualArray);
            actual.SortAscending();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 6, 7, 1 }, new[] { 7, 6, 1 })]
        [TestCase(new[] { 1 }, new[] { 1 })]
        [TestCase(new[] { 9, 9, 5, 0 }, new[] { 9, 9, 5, 0 })]
        [TestCase(new[] { -9, -29, -5, 0 }, new[] { 0, -5, -9, -29 })]
        public void SortDescendingTests(int[] actualArray, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(actualArray);
            actual.SortDescending();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(7, new[] { 7, 3, 6, 7, 1 }, new[] { 3, 6, 7, 1 })]
        [TestCase(1, new[] { 1 }, new int[] { })]
        [TestCase(0, new[] { 9, 9, 5, 0 }, new[] { 9, 9, 5 })]
        public void RemoveByValueFirstMatchInList_Tests(int value, int[] actualArray, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(actualArray);
            actual.RemoveByValueFirstMatchInList(value);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(7, new[] { 7, 3, 6, 7, 1 }, 2)]
        [TestCase(1, new[] { 1 }, 1)]
        [TestCase(9, new[] { 9, 9, 9, 9, 9, 9, 9, 5, 0 }, 7)]
        public void RemoveByValueAllMatchInList_Tests(int value, int[] actualArray, int expected)
        {
            ArrayList list = new ArrayList(actualArray);
            int actual = list.RemoveByValueAllMatchInList(value);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 7, 3, 6, 7, 1 }, new[] { 3, 6, 1 }, new[] { 7, 3, 6, 7, 1, 3, 6, 1 })]
        [TestCase(new int[] { }, new[] { 3, 6, 1 }, new[] { 3, 6, 1 })]
        [TestCase(new[] { 7, 7, 1 }, new[] { 3, 6, 1 }, new[] { 7, 7, 1, 3, 6, 1, })]
        public void AddNewListToEndList_Tests(int[] list, int[] actualArray, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(list);
            actual.AddNewListToEndList(actualArray);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 7, 3, 6, 7, 1 }, new[] { 3, 6, 1 }, new[] { 3, 6, 1, 7, 3, 6, 7, 1 })]
        [TestCase(new int[] { }, new[] { 3, 6, 1 }, new[] { 3, 6, 1 })]
        [TestCase(new[] { 7, 7, 1 }, new[] { 3, 6, 1 }, new[] { 3, 6, 1, 7, 7, 1 })]
        public void AddNewListToBeginList_Tests(int[] list, int[] actualArray, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(list);
            actual.AddNewListToBeginList(actualArray);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, new[] { 7, 3, 6, 7, 1 }, new[] { 3, 6, 1 }, new[] { 7, 3, 6, 3, 6, 1, 7, 1 })]
        [TestCase(0, new int[] { }, new[] { 3, 6, 1 }, new[] { 3, 6, 1 })]
        [TestCase(1, new[] { 7, 7, 1 }, new[] { 3, 6, 1 }, new[] { 7, 3, 6, 1, 7, 1 })]
        public void AddNewListByIndexInList_Tests(int index, int[] list, int[] actualArray, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(list);
            actual.AddNewListByIndexInList(index, actualArray);
            Assert.AreEqual(expected, actual);
        }

        //NegativeTest

        [TestCase(new[] { 0, 4, -1, 5 }, 4, -1)]
        [TestCase(new[] { 1 }, -2, 2)]
        public void AddValueByIndexInList_ExceptionTests(int[] array, int value, int index)
        {
            ArrayList actual = new ArrayList(array);
            Assert.Throws<IndexOutOfRangeException>(() => actual.AddValueByIndexInList(index, value));
        }

        [TestCase(new[] { 0, 4, -1, 5 }, -1)]
        [TestCase(new[] { 1 }, 2)]
        public void RemoveValueByIndexInList_ExceptionTests(int[] array, int index)
        {
            ArrayList actual = new ArrayList(array);
            Assert.Throws<IndexOutOfRangeException>(() => actual.RemoveValueByIndexInList(index));
        }

        [TestCase(new[] { 0, 4, -1, 5 }, -4)]
        [TestCase(new[] { 1 }, -2)]
        public void RemoveGivenQuantityOfValuesTheEndByList_ExceptionTests(int[] array, int count)
        {
            ArrayList actual = new ArrayList(array);
            Assert.Throws<ArgumentException>(() => actual.RemoveGivenQuantityOfValuesTheEndByList(count));
        }

        [TestCase(new int[] { }, 22)]
        [TestCase(new[] { 4, 5, 6, 1, 6 }, 92)]

        public void RemoveGivenQuantityOfValuesTheEndByList_ExceptionTests2(int[] array, int count)
        {
            ArrayList actual = new ArrayList(array);
            Assert.Throws<ArgumentException>(() => actual.RemoveGivenQuantityOfValuesTheEndByList(count));
        }

        [TestCase(new[] { 0, 4, -1, 5 }, -1)]
        [TestCase(new int[] { }, -2)]
        public void RemoveGivenQuantityOfValuesTheStartByList_ExceptionTests(int[] array, int count)
        {
            ArrayList actual = new ArrayList(array);
            Assert.Throws<ArgumentException>(() => actual.RemoveGivenQuantityOfValuesTheStartByList(count));
        }

        [TestCase(new[] { 0, 4, -1, 5 }, 99)]
        [TestCase(new[] { 1 }, -2)]
        public void RemoveGivenQuantityOfValuesByIndexInList_ExceptionTests_Index(int[] array, int index)
        {
            ArrayList actual = new ArrayList(array);
            Assert.Throws<IndexOutOfRangeException>(() => actual.RemoveGivenQuantityOfValuesByIndexInList(index));
        }

        [TestCase(new[] { 0, 4, -1, 5 }, 4, -1)]
        [TestCase(new[] { 1 }, 1, -2)]
        public void RemoveGivenQuantityOfValuesByIndexInList_ExceptionTests_Remove(int[] array, int index, int count)
        {
            ArrayList actual = new ArrayList(array);
            Assert.Throws<ArgumentException>(() => actual.RemoveGivenQuantityOfValuesByIndexInList(index, count));
        }

        [TestCase(2, 9)]
        public void RemoveGivenQuantityOfValuesByIndexInList_ExceptionTests_ByZero(int index, int count)
        {
            ArrayList actual = null;
            Assert.Throws<NullReferenceException>(() => actual.RemoveGivenQuantityOfValuesByIndexInList(index, count));
        }

        [TestCase(new[] { 0, 4, -1, 5 }, 4, -1)]
        [TestCase(new[] { 1 }, -2, 2)]
        public void ChangeValueByIndex_ExceptionTests(int[] array, int value, int index)
        {
            ArrayList actual = new ArrayList(array);
            Assert.Throws<IndexOutOfRangeException>(() => actual.ChangeValueByIndex(index, value));
        }
  
        [TestCase(new int[] { })]
        public void FindIndexMaxValueByList_ExceptionTests(int[] array)
        {
            ArrayList actual = new ArrayList(array);
            Assert.Throws<NullReferenceException>(() => actual.FindIndexMaxValueByList());
        }
      
        [TestCase(new int[] { })]
        public void FindIndexMinValueByList_ExceptionTests(int[] array)
        {
            ArrayList actual = new ArrayList(array);
            Assert.Throws<NullReferenceException>(() => actual.FindIndexMinValueByList());
        }
      
        [TestCase(new[] { 0, 4, -1, 5 }, new[] { 79, 8 }, -11)]
        [TestCase(new[] { 1 }, new[] { 1 }, 99)]
        public void AddNewListByIndexInList_ExceptionTests(int[] array, int[] actualArray, int index)
        {
            ArrayList actual = new ArrayList(array);
            Assert.Throws<IndexOutOfRangeException>(() => actual.AddNewListByIndexInList(index, actualArray));
        }
    }
}