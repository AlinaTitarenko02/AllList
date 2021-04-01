using NUnit.Framework;
using DoubleLinked;
using System;

namespace DoubleListTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(new[] { 1, 2, 5, 3 }, 6, new[] { 1, 2, 5, 3, 6 })]
        [TestCase(new int[] { }, 666, new[] { 666 })]
        [TestCase(new[] { 1, 9, 11 }, 1, new[] { 1, 9, 11, 1 })]
        public void AddTests_WhenAddElementInList_ListWithNewElementInTheEndReturned(int[] input, int value,
           int[] output)
        {
            DoubleLinkedList actual = new DoubleLinkedList(input);
            DoubleLinkedList expected = new DoubleLinkedList(output);

            actual.Add(value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { }, 666, new[] { 666 })]
        [TestCase(new[] { 1, 2, 3, 4, 5 }, 666, new[] { 666, 1, 2, 3, 4, 5 })]
        [TestCase(new[] { 1, 2, 3, 4, 5 }, 0, new[] { 0, 1, 2, 3, 4, 5 })]
        public void AddFirstTests_WhenAddFirstElementInList_ListWithNewElementInTheFirstPositionReturned(int[] input,
            int value, int[] output)
        {
            DoubleLinkedList actual = new DoubleLinkedList(input);
            DoubleLinkedList expected = new DoubleLinkedList(output);

            actual.AddFirst(value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { }, 0, 666, new[] { 666 })]
        [TestCase(new[] { 1, 3, 4, 5, 6, 7 }, 1, 2, new[] { 1, 2, 3, 4, 5, 6, 7 })]
        [TestCase(new[] { 1, 3, 4, 5, 6, 7 }, 0, 666, new[] { 666, 1, 3, 4, 5, 6, 7 })]
        public void AddByIndexTests_WhenAddElementByIndexInList_ListWithNewElementInTheIndexPositionReturned(
            int[] input, int index, int value, int[] output)
        {
            DoubleLinkedList actual = new DoubleLinkedList(input);
            DoubleLinkedList expected = new DoubleLinkedList(output);

            actual.AddByIndex(index, value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 1, 2, 3, 4 }, new[] { 2, 3, 4 })]
        [TestCase(new[] { 3, 4 }, new[] { 4 })]
        [TestCase(new[] { 4 }, new int[] { })]

        public void RemoveFirstTests_WhenRemoveFirstElementInList_ListWithoutElementInFirstPositionReturned(int[] input,
            int[] output)
        {
                DoubleLinkedList actual = new DoubleLinkedList(input);
                DoubleLinkedList expected = new DoubleLinkedList(output);

            actual.RemoveFirst();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 1, 2, 3 }, new[] { 1, 2 })]
        [TestCase(new[] { 1, 2 }, new int[] { 1 })]
        public void RemoveLastTests_WhenRemoveLastElementInList_ListWithoutElementInLastPositionReturned(int[] input,
            int[] output)
        {
            DoubleLinkedList actual = new DoubleLinkedList(input);
            DoubleLinkedList expected = new DoubleLinkedList(output);

            actual.RemoveEnd();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 1, 2, 3, 4 }, 2, new[] { 1, 2 })]
        [TestCase(new[] { 1, 2, 3, 4 }, 0, new[] { 1, 2, 3, 4 })]
        public void
                    RemoveRangeFromLastTests_WhenRemoveRangeOfElementsFromLastOfList_ListWithoutCountElementsInThisRangeFromEndReturned(
                        int[] input, int count, int[] output)
        {
            DoubleLinkedList actual = new DoubleLinkedList(input);
            DoubleLinkedList expected = new DoubleLinkedList(output);

            actual.RemoveRangeFromLast(count);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 1, 2, 3, 4 }, 3, new[] { 1, 2, 3 })]
        [TestCase(new[] { 1, 2, 3, 4 }, 0, new[] { 2, 3, 4 })]
        [TestCase(new[] { 1, 2, 3, 4 }, 2, new[] { 1, 2, 4 })]
        public void RemoveByIndexTests_WhenRemoveElementByIndexInList_ListWithoutElementInTheIndexPositionReturned(
            int[] input, int index, int[] output)
        {
            DoubleLinkedList actual = new DoubleLinkedList(input);
            DoubleLinkedList expected = new DoubleLinkedList(output);

            actual.RemoveByIndex(index);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] {1, 2, 3}, 4)]
        [TestCase(new[] { 1, 2, 3 }, -3)]
        public void RemoveRangeFromLastTests_WhenRangeGreaterThenLengthOrLessThen0_ArgumentExceptionReturned(
                int[] input, int count)
        {
            DoubleLinkedList actual = new DoubleLinkedList(input);

            Assert.Throws<ArgumentException>(() => actual.RemoveRangeFromLast(count));
        }

        [TestCase(new[] { 1, 2, 3, 4 }, 2, new[] { 3, 4 })]
        [TestCase(new[] { 1, 2, 3, 4 }, 4, new int[] { })]
        [TestCase(new[] { 1, 2, 3, 4 }, 0, new[] { 1, 2, 3, 4 })]
        public void
            RemoveRangeFromFirstTests_WhenRemoveRangeOfElementsFromFirstOfList_ListWithoutCountElementsInThisRangeFromBeginReturned(
                int[] input, int count, int[] output)
        {
            DoubleLinkedList actual = new DoubleLinkedList(input);
            DoubleLinkedList expected = new DoubleLinkedList(output);

            actual.RemoveRangeFromFirst(count);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7 }, 2, 2, new[] { 1, 2, 5, 6, 7 })]
        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7 }, 5, 2, new[] { 1, 2, 3, 4, 5 })]
        [TestCase(new[] { 1, 2, 3, 4 }, 0, 4, new int[] { })]
        [TestCase(new[] { 1, 2, 3, 4 }, 3, 0, new[] { 1, 2, 3, 4 })]
        public void
            RemoveRangeFromIndexTests_WhenRemoveRangeOfElementsFromIndexOfList_ListWithoutCountElementsInThisRangeFromIndexReturned(
                int[] input, int index, int count, int[] output)
        {
            DoubleLinkedList actual = new DoubleLinkedList(input);
            DoubleLinkedList expected = new DoubleLinkedList(output);

            actual.RemoveRangeFromIndex(index, count);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 1, 2, 3, 5 }, 2, 3)]
        [TestCase(new[] { 1, 2, 3, 5 }, 1, -1)]
        public void RemoveRangeFromIndexTests_WhenRangeGreaterThenLengthOrLessThen0_ArgumentExceptionReturned(
            int[] input,
            int index, int count)
        {
            DoubleLinkedList actual = new DoubleLinkedList(input);

            Assert.Throws<System.ArgumentException>(() => actual.RemoveRangeFromIndex(index, count));
        }

        [TestCase(new[] { 1, 2, 3, 5 }, -2, 2)]
        [TestCase(new[] { 1, 2, 3, 5 }, 4, 1)]
        public void
            RemoveRangeFromIndexTests_WhenIndexLessThen0OrGreaterThatLastValueIndex_IndexOutOfRangeExceptionReturned(
                int[] input,
                int index, int count)
        {
            DoubleLinkedList actual = new DoubleLinkedList(input);

            Assert.Throws<System.IndexOutOfRangeException>(() => actual.RemoveRangeFromIndex(index, count));
        }


        [TestCase(new[] { 1, 2, 3, 4 }, 4)]
        [TestCase(new[] { 1, 2, 3, 4, 6, 7, 8 }, 7)]
        [TestCase(new[] { 1 }, 1)]
        [TestCase(new int[] { }, 0)]
        public void GetLengthTests_WhenArrayListsHasElements_CountOfElementsReturned(int[] input, int expected)
        {
            DoubleLinkedList actu = new DoubleLinkedList(input);

            int actual = actu.GetLength();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 1, 1, 1, 1 }, 1, 0)]
        [TestCase(new[] { 1, 2, 3, 4, 6, 7, 8 }, 7, 5)]
        [TestCase(new[] { 1 }, 1, 0)]
        [TestCase(new[] { 1, 1, 2, 3, 4, 6, 7, 8 }, 9, -1)]
        public void GetFirstIndexByValueTests_WhenArrayListsContainValues_IndexOfFirstFoundValueReturned(int[] input,
           int value, int expected)
        {
            DoubleLinkedList actu = new DoubleLinkedList(input);

            int actual = actu.GetFirstIndexByValue(value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 1, 2, 3, 4 }, new[] { 4, 3, 2, 1 })]
        [TestCase(new[] { 1, 2, 5, 3, 4 }, new[] { 4, 3, 5, 2, 1 })]
        [TestCase(new[] { 1 }, new[] { 1 })]
        [TestCase(new[] { 0 }, new[] { 0 })]
        public void ReverseTests_WhenArrayList_ReversedArrayListReturned(int[] input, int[] output)
        {
            DoubleLinkedList actual = new DoubleLinkedList(input);

            actual.Reverse();

            DoubleLinkedList expected = new DoubleLinkedList(output);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 1, 10, 5 }, 1)]
        [TestCase(new[] { 1, 10, 5, 14, 999 }, 4)]
        [TestCase(new[] { 0 }, 0)]
        public void FindIndexOfMaxValueTests_WhenFindListMaxValue_IndexOfMaxValueReturned(int[] input, int expected)
        {
            DoubleLinkedList actua = new DoubleLinkedList(input);
            int actual = actua.FindIndexOfMaxValue();

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new[] { 1, 2, 3, 4 }, 0)]
        [TestCase(new[] { 1, 2, 3, 4, 6, 7, 8 }, 0)]
        [TestCase(new[] { 55, 10, 5 }, 2)]
        public void FindIndexOfMinValueTests_WhenFindListMinValue_IndexOfMinValueReturned(int[] input, int expected)
        {
            DoubleLinkedList actua = new DoubleLinkedList(input);
            int actual = actua.FindIndexOfMinValue();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 1, 10, 15 }, 15)]
        [TestCase(new[] { 1, 15, 15 }, 15)]
        [TestCase(new[] { 1, 10, 5, 1 }, 10)]
        [TestCase(new[] { 0 }, 0)]
        public void FindMaxValueTests_WhenArrayListHasElements_MaxValueReturned(int[] input, int expected)
        {
            DoubleLinkedList actua = new DoubleLinkedList(input);
            int actual = actua.FindMaxValue();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 1, 2, 3, 4 }, 1)]
        [TestCase(new[] { 1, 2, 3, 4, 3, 7, 0 }, 0)]
        [TestCase(new[] { 55, 10, 5 }, 5)]
        public void FindMinValueTests_WhenArrayListHasElements_MinValueReturned(int[] input, int expected)
        {
            DoubleLinkedList actua = new DoubleLinkedList(input);
            int actual = actua.FindMinValue();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 1, 2, 3, 5 }, 5, 3)]
        [TestCase(new[] { 1, 2, 3, 2 }, 2, 1)]
        [TestCase(new[] { 1, 2, 3, 5 }, 7, -1)]
        public void RemoveFirstByValueTests_WhenFirstValueFoundRemoveItFromList_IndexOfThatValueReturned(int[] input,
            int value, int expected)
        {
            DoubleLinkedList actua = new DoubleLinkedList(input);

            int actual = actua.RemoveFirstByValue(value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 1, 2, 3, 5 }, 5, 1)]
        [TestCase(new[] { 1, 2, 3, 2 }, 2, 2)]
        [TestCase(new[] { 1, 2, 3, 5 }, 7, 0)]
        [TestCase(new[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, 1, 10)]
        public void RemoveAllByValueTests_WhenValuesFoundRemoveItFromList_CountOfThatValuesReturned(int[] input,
            int value,
            int expected)
        {
            DoubleLinkedList actua = new DoubleLinkedList(input);

            int actual = actua.RemoveAllByValue(value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 1, 2, 3, 4 }, 2, new[] { 6, 7, 8, 9 }, new[] { 1, 2, 6, 7, 8, 9, 3, 4 })]
        [TestCase(new[] { 1, 2 }, 1, new[] { 6, 7, 8, 9, 1, 2, 3, 4 }, new[] { 1, 6, 7, 8, 9, 1, 2, 3, 4, 2 })]
        [TestCase(new[] { 1, 6, 7, 8, 9, 1, 2, 3, 4, 2 }, 4, new[] { 1, 6, 7, 8, 9, 1, 2, 3, 4, 2 }, new[] { 1, 6, 7, 8, 1, 6, 7, 8, 9, 1, 2, 3, 4, 2, 9, 1, 2, 3, 4, 2 })]
        public void AddListByIndexTests_WhenToListAddAnotherListByIndex_ListWithInsertedInIndexListReturned(int[] input,
                     int index, int[] Elements, int[] output)
        {
            DoubleLinkedList input1 = new DoubleLinkedList(input);
            DoubleLinkedList input2 = new DoubleLinkedList(Elements);
            DoubleLinkedList expected = new DoubleLinkedList(output);

            input1.AddListByIndex(index, input2);

            Assert.AreEqual(expected, input1);
        }

        [TestCase(new[] { 1, 2, 3, 4 }, new[] { 6, 7, 8, 9 }, new[] { 6, 7, 8, 9, 1, 2, 3, 4 })]
        [TestCase(new[] { 1, 2 }, new[] { 6, 7, 8, 9, 1, 2, 3, 4 }, new[] { 6, 7, 8, 9, 1, 2, 3, 4, 1, 2 })]
        public void AddListFirstTests_WhenToFirstListAddAnotherListInFirstPosition_ListWithInsertedInFirstPositionListReturned(int[] input,
             int[] Elements, int[] output)
        {
            DoubleLinkedList input1 = new DoubleLinkedList(input);
            DoubleLinkedList input2 = new DoubleLinkedList(Elements);
            DoubleLinkedList expected = new DoubleLinkedList(output);

            input1.AddListFirst(input2);

            Assert.AreEqual(expected, input1);
        }



        [TestCase(new[] { 1, 2, 3, 4 }, new[] { 6, 7, 8, 9 }, new[] { 1, 2, 3, 4, 6, 7, 8, 9 })]
        [TestCase(new[] { 1, 2 }, new[] { 6, 7, 8, 9, 1, 2, 3, 4 }, new[] { 1, 2, 6, 7, 8, 9, 1, 2, 3, 4 })]
        public void
            AddListLastTests_WhenToFirstListAddAnotherListInLastPosition_ListWithInsertedInLasttPositionListReturned(
                int[] input,
                int[] Elements, int[] output)
        {
            DoubleLinkedList input1 = new DoubleLinkedList(input);
            DoubleLinkedList input2 = new DoubleLinkedList(Elements);
            DoubleLinkedList expected = new DoubleLinkedList(output);

            input1.AddListLast(input2);

            Assert.AreEqual(expected, input1);
        }

        [TestCase(new[] { 1 }, new[] { 1 })]
        [TestCase(new[] { 1, 3, 5, 7, 8 }, new[] { 1, 3, 5, 7, 8 })]
        [TestCase(new[] { 8, 7, 5, 3, 1 }, new[] { 1, 3, 5, 7, 8 })]
        public void SortTests_WhenArrayList_SortedArrayListByDescendingReturned(int[] input,
                    int[] output)
        {
            DoubleLinkedList input1 = new DoubleLinkedList(input);
            DoubleLinkedList expected = new DoubleLinkedList(output);

            input1 = input1.Sort(input1);

            Assert.AreEqual(expected, input1);
        }
    }
}