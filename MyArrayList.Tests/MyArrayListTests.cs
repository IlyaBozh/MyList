using NUnit.Framework;
using System.Collections;
using System;

namespace MyArrayList.Tests
{
    public class MyArrayListTests
    {
        [TestCaseSource(typeof(AddLastTestSource))]
        public void AddLastTest(int element, MyArrayList list, MyArrayList expectedList)
        {
            list.AddLast(element);
            MyArrayList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AddFirstTestSource))]
        public void AddFirstTest(int element, MyArrayList list, MyArrayList expectedList)
        {
            list.AddFirst(element);
            MyArrayList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AddByIndexTestSource))]
        public void AddByIndexTest(int index, int element, MyArrayList list, MyArrayList expectedList)
        {
            list.AddByIndex(index, element);
            MyArrayList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AddByIndexTest_WhenIndexOutOfRange_ShouldReturnOutOfRangeExeptionSource))]
        public void AddByIndexTest_WhenIndexOutOfRange_ShouldReturnOutOfRangeExeption(int index, int value, MyArrayList list)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => list.AddByIndex(index, value));
        }

        [TestCaseSource(typeof(DeleteLastTestSource))]
        public void DeleteLastTest(MyArrayList list, MyArrayList expectedList)
        {
            list.DeleteLast();
            MyArrayList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteLastTest_WhenListIsEmpty_ShouldReturnExeptionSource))]
        public void DeleteLastTest_WhenListIsEmpty_ShouldReturnExeption(MyArrayList list)
        {
            Assert.Throws<Exception>(() => list.DeleteLast());
        }

        [TestCaseSource(typeof(DeleteFirstTestSource))]
        public void DeleteFirstTest(MyArrayList list, MyArrayList expectedList)
        {
            list.DeleteFirst();
            MyArrayList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteFirstTest_WhenListIsEmpty_ShouldReturnExeptionSource))]
        public void DeleteFirstTest_WhenListIsEmpty_ShouldReturnExeption(MyArrayList list)
        {
            Assert.Throws<Exception>(() => list.DeleteLast());
        }
        
        [TestCaseSource(typeof(DeleteByIndexTestSource))]
        public void DeleteByIndexTest(int index, MyArrayList list, MyArrayList expectedList)
        {
            list.DeleteByIndex(index);
            MyArrayList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteByIndexTest_WhenIndexOutOfRange_ShouldReturnOutOfRangeExeptionSource))]
        public void DeleteByIndexTest_WhenIndexOutOfRange_ShouldReturnOutOfRangeExeption(int index, MyArrayList list)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => list.DeleteByIndex(index));
        }
    }
}