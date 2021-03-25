using NUnit.Framework;
using List;


namespace ListsTests
{
    public class LinkedListTests
    {

        [Test]
        public void Test1()
        {
            LinkedList a = new LinkedList(new int[] { 1, 2, 3, 4 });
            LinkedList b = new LinkedList(new int[] { 1, 2, 3 });

            b.Add(4);
            Assert.AreEqual(a, b);
        }
    }
}