using NUnit.Framework;
using ListsProject;

namespace ListProject.Tests
{
    public class Tests
    {
        // len 
        [Theory]
        [TestCase(new int[] {1, 2, 3, 4}, 4)]
        [TestCase(new int[] {1, 2, 3, 4, 6, 7, 8}, 7)]
        [TestCase(new int[] {1}, 1)]
        public void GetLenght_WhenArrayLists_IntOfLenght(int[] actual, int expected)
        {
            ArrayList a = new ArrayList(actual);
            int length = a.GetLength();
            Assert.AreEqual(length, expected);
        }

    }
}