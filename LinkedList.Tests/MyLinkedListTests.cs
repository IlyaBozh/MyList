using NUnit.Framework;
using System.Collections;
using System;


namespace MyLinkedList.Tests
{
    public class MyLinkedListTests
    {
        [TestCaseSource(typeof(AddLastTestSource))]
        public void AddLastTest(int value, MyLinkedList list, MyLinkedList expectedList)
        {
            list.AddLast(value);
            MyLinkedList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AddFirstTestSource))]
        public void AddFirstTest(int value, MyLinkedList list, MyLinkedList expectedList)
        {
            list.AddFirst(value);
            MyLinkedList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AddByIndexTestSource))]
        public void AddByIndexTest(int index, int value, MyLinkedList list, MyLinkedList expectedList)
        {
            list.AddByIndex(index, value);
            MyLinkedList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

       [TestCaseSource(typeof(AddByIndexTest_WhenIndexOutOfRange_ShouldReturnOutOfRangeExeptionSource))]
        public void AddByIndexTest_WhenIndexOutOfRange_ShouldReturnOutOfRangeExeption(int index, int value, MyLinkedList list)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => list.AddByIndex(index, value));
        }

        [TestCaseSource(typeof(DeleteLastTestSource))]
        public void DeleteLastTest(MyLinkedList list, MyLinkedList expectedList)
        {
            list.DeleteLast();
            MyLinkedList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }
        
        [TestCaseSource(typeof(DeleteLastTest_WhenListIsEmpty_ShouldReturnExeptionSource))]
        public void DeleteLastTest_WhenListIsEmpty_ShouldReturnExeption(MyLinkedList list)
        {
            Assert.Throws<Exception>(() => list.DeleteLast());
        }
        
        [TestCaseSource(typeof(DeleteFirstTestSource))]
        public void DeleteFirstTest(MyLinkedList list, MyLinkedList expectedList)
        {
            list.DeleteFirst();
            MyLinkedList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteFirstTest_WhenListIsEmpty_ShouldReturnExeptionSource))]
        public void DeleteFirstTest_WhenListIsEmpty_ShouldReturnExeption(MyLinkedList list)
        {
            Assert.Throws<Exception>(() => list.DeleteLast());
        }
      
        [TestCaseSource(typeof(DeleteByIndexTestSource))]
        public void DeleteByIndexTest(int index, MyLinkedList list, MyLinkedList expectedList)
        {
            list.DeleteByIndex(index);
            MyLinkedList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteByIndexTest_WhenIndexOutOfRange_ShouldReturnOutOfRangeExeptionSource))]
        public void DeleteByIndexTest_WhenIndexOutOfRange_ShouldReturnOutOfRangeExeption(int index, MyLinkedList list)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => list.DeleteByIndex(index));
        }
        
        [TestCaseSource(typeof(DeleteElementsFromEndTestSource))]
        public void DeleteElementsFromEndTest(int countElement, MyLinkedList list, MyLinkedList expectedList)
        {
            list.DeleteElementsFromEnd(countElement);
            MyLinkedList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteElementsFromEndTest_WhenCountLessThanOne_ShouldReturnArgumentExeptionSource))]
        public void DeleteElementsFromEndTest_WhenCountLessThanOne_ShouldReturnArgumentExeption(int countElement, MyLinkedList list)
        {
            Assert.Throws<ArgumentException>(() => list.DeleteElementsFromEnd(countElement));
        }
        
        [TestCaseSource(typeof(DeleteElementsFromBeginTestSource))]
        public void DeleteElementsFromBeginTest(int countElement, MyLinkedList list, MyLinkedList expectedList)
        {
            list.DeleteElementsFromBegin(countElement);
            MyLinkedList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteElementsFromBeginTest_WhenCountLessThanOne_ShouldReturnArgumentExeptionSource))]
        public void DeleteElementsFromBeginTest_WhenCountLessThanOne_ShouldReturnArgumentExeption(int countElement, MyLinkedList list)
        {
            Assert.Throws<ArgumentException>(() => list.DeleteElementsFromBegin(countElement));
        }
        
        [TestCaseSource(typeof(DeleteElementsByIndexTestSource))]
        public void DleteElementsByIndexTest(int index, int countElement, MyLinkedList list, MyLinkedList expectedList)
        {
            list.DeleteElementsByIndex(index, countElement);
            MyLinkedList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteElementsByIndexTest_WhenCountLessThanOne_ShouldReturnArgumentExeptionSource))]
        public void DleteElementsByIndexTest_WhenCountLessThanOne_ShouldReturnArgumentExeption(int index, int countElement, MyLinkedList list)
        {
            Assert.Throws<ArgumentException>(() => list.DeleteElementsByIndex(index, countElement));
        }

        [TestCaseSource(typeof(DeleteElementsByIndexTest_WhenIndexOutOfRange_ShouldReturnOutOfRangeExeption))]
        public void DleteElementsByIndexTest_WhenIndexOutOfRange_ShouldReturnOutOfRangeExeption(int index, int countElement, MyLinkedList list)
        {
            Assert.Throws<IndexOutOfRangeException>(() => list.DeleteElementsByIndex(index, countElement));
        }
        
        [TestCaseSource(typeof(FindIndexFirstElementByValueTestSource))]
        public void FindFirstElementByValueTest(int value, MyLinkedList list, int expectedIndex)
        {
            int actualIndex = list.FindIndexFirstElementByValue(value);
            Assert.AreEqual(expectedIndex, actualIndex);
        }
        
        [TestCaseSource(typeof(ReverseTestSource))]
        public void ReverseTest(MyLinkedList list, MyLinkedList expectedList)
        {
            list.Reverse();
            MyLinkedList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }
        
        [TestCaseSource(typeof(FindMaxTestSource))]
        public void FindMaxTest(MyLinkedList list, int expectedMaxElement)
        {
            int actualMaxElement = list.FindMax();
            Assert.AreEqual(expectedMaxElement, actualMaxElement);
        }

        [TestCaseSource(typeof(FindMaxTest_WhenEmpyList_ShouldReturnExeptionSource))]
        public void FindMaxTest_WhenEmpyList_ShouldReturnExeption(MyLinkedList list)
        {
            Assert.Throws<Exception>(() => list.FindMax());
        }
        
        [TestCaseSource(typeof(FindMinTestSource))]
        public void FindMinTest(MyLinkedList list, int expectedMinElement)
        {
            int actualMinElement = list.FindMin();
            Assert.AreEqual(expectedMinElement, actualMinElement);
        }

        [TestCaseSource(typeof(FindMinTest_WhenEmpyList_ShouldReturnExeptionSource))]
        public void FindMinTest_WhenEmpyList_ShouldReturnExeption(MyLinkedList list)
        {
            Assert.Throws<Exception>(() => list.FindMin());
        }
        
        [TestCaseSource(typeof(FindIndexOfMaxElementTestSource))]
        public void FindIndexOfMaxElementTest(MyLinkedList list, int expectedIndexOfMaxElement)
        {
            int actualIndexOfMaxElement = list.FindIndexOfMaxElement();
            Assert.AreEqual(expectedIndexOfMaxElement, actualIndexOfMaxElement);
        }

        [TestCaseSource(typeof(FindIndexOfMaxElementTest_WhenEmpyList_ShouldReturnExeptionSource))]
        public void FindIndexOfMaxElementTest_WhenEmpyList_ShouldReturnExeption(MyLinkedList list)
        {
            Assert.Throws<Exception>(() => list.FindIndexOfMaxElement());
        }
        
        [TestCaseSource(typeof(FindIndexOfMinElementTestSource))]
        public void FindIndexOfMinElementTest(MyLinkedList list, int expectedIndexOfMinElement)
        {
            int actualIndexOfMinElement = list.FindIndexOfMinElement();
            Assert.AreEqual(expectedIndexOfMinElement, actualIndexOfMinElement);
        }

        [TestCaseSource(typeof(FindIndexOfMinElementTest_WhenEmpyList_ShouldReturnExeptionSource))]
        public void FindIndexOfMinElementTest_WhenEmpyList_ShouldReturnExeption(MyLinkedList list)
        {
            Assert.Throws<Exception>(() => list.FindIndexOfMinElement());
        }
        /*
        [TestCaseSource(typeof(SortAscendingTestSource))]
        public void SortAscendingTest(MyLinkedList list, MyLinkedList expectedList)
        {
            list.SortAscending();
            MyLinkedList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(SortDescendingTestSource))]
        public void SortDescendingTest(MyLinkedList list, MyLinkedList expectedList)
        {
            list.SortDescending();
            MyLinkedList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }
        */
        [TestCaseSource(typeof(DeleteFirstElementByValueTestSource))]
        public void DeleteFirstElementByValueTest(int value, MyLinkedList list, int expectedIndexOfElement, MyLinkedList expectedList)
        {
            int actualIndexOfElement = list.DeleteFirstElementByValue(value);
            MyLinkedList actualList = list;
            Assert.AreEqual(expectedIndexOfElement, actualIndexOfElement);
            Assert.AreEqual(expectedList, actualList);
        }
        
        [TestCaseSource(typeof(DeleteAllElementByValueTestSource))]
        public void DeleteAllElementByValueTest(int value, MyLinkedList list, int expectedCountOfElements, MyLinkedList expectedList)
        {
            int actualCountOfElements = list.DeleteAllElementByValue(value);
            MyLinkedList actualList = list;
            Assert.AreEqual(expectedCountOfElements, actualCountOfElements);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteAllElementByValueTest_WhenEmpyList_ShouldReturnExeptionSource))]
        public void DeleteAllElementByValueTest_WhenEmpyList_ShouldReturnExeption(int value, MyLinkedList list)
        {
            Assert.Throws<Exception>(() => list.DeleteAllElementByValue(value));
        }
        
        [TestCaseSource(typeof(AddListToEndTestSource))]
        public void AddListToEndTest(MyLinkedList list, MyLinkedList originalList, MyLinkedList expectedList)
        {
            originalList.AddListToEnd(list);
            MyLinkedList actualList = originalList;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AddListToBeginTestSource))]
        public void AddListToBeginTest(MyLinkedList list, MyLinkedList originalList, MyLinkedList expectedList)
        {
            originalList.AddListToBegin(list);
            MyLinkedList actualList = originalList;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AddListByIndexTestSource))]
        public void AddListByIndexTest(MyLinkedList list, int index, MyLinkedList originalList, MyLinkedList expectedList)
        {
            originalList.AddListByIndex(list, index);
            MyLinkedList actualList = originalList;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AddListByIndexTest_WhenIndexOutOfRange_ShouldReturnArgumentOutOfRangeExceptionSource))]
        public void AddListByIndexTest_WhenIndexOutOfRange_ShouldReturnArgumentOutOfRangeException(
            MyLinkedList list, int index, MyLinkedList originalList
            )
        {
            Assert.Throws<IndexOutOfRangeException>(() => originalList.AddListByIndex(list, index));
        }
    }
}
