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

        [TestCaseSource(typeof(DeleteElementsFromEndTestSource))]
        public void DeleteElementsFromEndTest(int countElement, MyArrayList list, MyArrayList expectedList)
        {
            list.DeleteElementsFromEnd(countElement);
            MyArrayList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteElementsFromEndTest_WhenCountLessThanOne_ShouldReturnArgumentExeptionSource))]
        public void DeleteElementsFromEndTest_WhenCountLessThanOne_ShouldReturnArgumentExeption(int countElement, MyArrayList list)
        {
            Assert.Throws<ArgumentException>(() => list.DeleteElementsFromEnd(countElement));
        }

        [TestCaseSource(typeof(DeleteElementsFromBeginTestSource))]
        public void DeleteElementsFromBeginTest(int countElement, MyArrayList list, MyArrayList expectedList)
        {
            list.DeleteElementsFromBegin(countElement);
            MyArrayList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteElementsFromBeginTest_WhenCountLessThanOne_ShouldReturnArgumentExeptionSource))]
        public void DeleteElementsFromBeginTest_WhenCountLessThanOne_ShouldReturnArgumentExeption(int countElement, MyArrayList list)
        {
            Assert.Throws<ArgumentException>(() => list.DeleteElementsFromBegin(countElement));
        }

        [TestCaseSource(typeof(DeleteElementsByIndexTestSource))]
        public void DleteElementsByIndexTest(int index, int countElement, MyArrayList list, MyArrayList expectedList)
        {
            list.DeleteElementsByIndex(index, countElement);
            MyArrayList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteElementsByIndexTest_WhenCountLessThanOne_ShouldReturnArgumentExeptionSource))]
        public void DleteElementsByIndexTest_WhenCountLessThanOne_ShouldReturnArgumentExeption(int index, int countElement, MyArrayList list)
        {
            Assert.Throws<ArgumentException>(() => list.DeleteElementsByIndex(index, countElement));
        }

        [TestCaseSource(typeof(DeleteElementsByIndexTest_WhenIndexOutOfRange_ShouldReturnOutOfRangeExeption))]
        public void DleteElementsByIndexTest_WhenIndexOutOfRange_ShouldReturnOutOfRangeExeption(int index, int countElement, MyArrayList list)
        {
            Assert.Throws<IndexOutOfRangeException>(() => list.DeleteElementsByIndex(index, countElement));
        }

        [TestCaseSource(typeof(FindFirstElementByValueTestSource))]
        public void FindFirstElementByValueTest(int value, MyArrayList list, int expectedIndex)
        {
            int actualIndex = list.FindFirstElementByValue(value);
            Assert.AreEqual(expectedIndex, actualIndex);
        }

        [TestCaseSource(typeof(ReverseTestSource))]
        public void ReverseTest(MyArrayList list, MyArrayList expectedList)
        {
            list.Reverse();
            MyArrayList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(FindMaxTestSource))]
        public void FindMaxTest(MyArrayList list, int expectedMaxElement)
        {
            int actualMaxElement = list.FindMax();
            Assert.AreEqual(expectedMaxElement, actualMaxElement);
        }

        [TestCaseSource(typeof(FindMaxTest_WhenEmpyList_ShouldReturnExeptionSource))]
        public void FindMaxTest_WhenEmpyList_ShouldReturnExeption(MyArrayList list)
        {
            Assert.Throws<Exception>(() => list.FindMax());
        }

        [TestCaseSource(typeof(FindMinTestSource))]
        public void FindMinTest(MyArrayList list, int expectedMinElement)
        {
            int actualMinElement = list.FindMin();
            Assert.AreEqual(expectedMinElement, actualMinElement);
        }

        [TestCaseSource(typeof(FindMinTest_WhenEmpyList_ShouldReturnExeptionSource))]
        public void FindMinTest_WhenEmpyList_ShouldReturnExeption(MyArrayList list)
        {
            Assert.Throws<Exception>(() => list.FindMin());
        }

        [TestCaseSource(typeof(FindIndexOfMaxElementTestSource))]
        public void FindIndexOfMaxElementTest(MyArrayList list, int expectedIndexOfMaxElement)
        {
            int actualIndexOfMaxElement = list.FindIndexOfMaxElement();
            Assert.AreEqual(expectedIndexOfMaxElement, actualIndexOfMaxElement);
        }

        [TestCaseSource(typeof(FindIndexOfMaxElementTest_WhenEmpyList_ShouldReturnExeptionSource))]
        public void FindIndexOfMaxElementTest_WhenEmpyList_ShouldReturnExeption(MyArrayList list)
        {
            Assert.Throws<Exception>(() => list.FindIndexOfMaxElement());
        }

        [TestCaseSource(typeof(FindIndexOfMinElementTestSource))]
        public void FindIndexOfMinElementTest(MyArrayList list, int expectedIndexOfMinElement)
        {
            int actualIndexOfMinElement = list.FindIndexOfMinElement();
            Assert.AreEqual(expectedIndexOfMinElement, actualIndexOfMinElement);
        }

        [TestCaseSource(typeof(FindIndexOfMinElementTest_WhenEmpyList_ShouldReturnExeptionSource))]
        public void FindIndexOfMinElementTest_WhenEmpyList_ShouldReturnExeption(MyArrayList list)
        {
            Assert.Throws<Exception>(() => list.FindIndexOfMinElement());
        }

        [TestCaseSource(typeof(SortAscendingTestSource))]
        public void SortAscendingTest(MyArrayList list, MyArrayList expectedList)
        {
            list.SortAscending();
            MyArrayList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(SortDescendingTestSource))]
        public void SortDescendingTest(MyArrayList list, MyArrayList expectedList)
        {
            list.SortDescending();
            MyArrayList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteFirstElementByValueTestSource))]
        public void DeleteFirstElementByValueTest(int value, MyArrayList list, int expectedIndexOfElement, MyArrayList expectedList)
        {
            int actualIndexOfElement = list.DeleteFirstElementByValue(value);
            MyArrayList actualList = list;
            Assert.AreEqual(expectedIndexOfElement, actualIndexOfElement);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteAllElementByValueTestSource))]
        public void DeleteAllElementByValueTest(int value, MyArrayList list, int expectedCountOfElements, MyArrayList expectedList)
        {
            int actualCountOfElements = list.DeleteAllElementByValue(value);
            MyArrayList actualList = list;
            Assert.AreEqual(expectedCountOfElements, actualCountOfElements);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AddListToEndTestSource))]
        public void AddListToEndTest(MyArrayList list, MyArrayList originalList, MyArrayList expectedList)
        {
            originalList.AddListToEnd(list);
            MyArrayList actualList = originalList;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AddListToEndTest_WhenListIsNull_ShouldReturnArgumentNullExceptionSource))]
        public void AddListToEndTest_WhenListIsNull_ShouldReturnArgumentNullException(MyArrayList list, MyArrayList originalList)
        {
            Assert.Throws<ArgumentNullException>(() => originalList.AddListToEnd(list));
        }

        [TestCaseSource(typeof(AddListToBeginTestSource))]
        public void AddListToBeginTest(MyArrayList list, MyArrayList originalList, MyArrayList expectedList)
        {
            originalList.AddListToBegin(list);
            MyArrayList actualList = originalList;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AddListToBeginTest_WhenListIsNull_ShouldReturnArgumentNullExceptionSource))]
        public void AddListToBeginTest_WhenListIsNull_ShouldReturnArgumentNullException(MyArrayList list, MyArrayList originalList)
        {
            Assert.Throws<ArgumentNullException>(() => originalList.AddListToBegin(list));
        }

        [TestCaseSource(typeof(AddListByIndexTestSource))]
        public void AddListByIndexTest(MyArrayList list, int index, MyArrayList originalList, MyArrayList expectedList)
        {
            originalList.AddListByIndex(list, index);
            MyArrayList actualList = originalList;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AddListByIndexTest_WhenIndexOutOfRange_ShouldReturnArgumentOutOfRangeExceptionSource))]
        public void AddListByIndexTest_WhenIndexOutOfRange_ShouldReturnArgumentOutOfRangeException(
            MyArrayList list, int index, MyArrayList originalList
            )
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => originalList.AddListByIndex(list, index));
        }

        [TestCaseSource(typeof(AddListByIndexTest_WhenListIsNull_ShouldReturnArgumentNullExceptionSource))]
        public void AddListByIndexTest_WhenListIsNull_ShouldReturnArgumentNullException(
            MyArrayList list, int index, MyArrayList originalList
            )
        {
            Assert.Throws<ArgumentNullException>(() => originalList.AddListByIndex(list, index));
        }
    }
}