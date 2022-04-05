using NUnit.Framework;
using System.Collections;
using System;


namespace MyLinkedList.Tests
{
    public class MyLinkedListTests
    {
        [TestCaseSource(typeof(AddTestSource))]
        public void AddTest(int value, MyLinkedList list, MyLinkedList expectedList)
        {
            list.Add(value);
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
        
        [TestCaseSource(typeof(FindIndexByValueTestSource))]
        public void FindIndexByValueTest(int value, MyLinkedList list, int expectedIndex)
        {
            int actualIndex = list.FindIndexByValue(value);
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
        
        [TestCaseSource(typeof(FindIndexOfMaxTestSource))]
        public void FindIndexOfMaxTest(MyLinkedList list, int expectedIndexOfMaxElement)
        {
            int actualIndexOfMaxElement = list.FindIndexOfMax();
            Assert.AreEqual(expectedIndexOfMaxElement, actualIndexOfMaxElement);
        }

        [TestCaseSource(typeof(FindIndexOfMaxTest_WhenEmpyList_ShouldReturnExeptionSource))]
        public void FindIndexOfMaxTest_WhenEmpyList_ShouldReturnExeption(MyLinkedList list)
        {
            Assert.Throws<Exception>(() => list.FindIndexOfMax());
        }
        
        [TestCaseSource(typeof(FindIndexOfMinTestSource))]
        public void FindIndexOfMinTest(MyLinkedList list, int expectedIndexOfMinElement)
        {
            int actualIndexOfMinElement = list.FindIndexOfMin();
            Assert.AreEqual(expectedIndexOfMinElement, actualIndexOfMinElement);
        }

        [TestCaseSource(typeof(FindIndexOfMinTest_WhenEmpyList_ShouldReturnExeptionSource))]
        public void FindIndexOfMinTest_WhenEmpyList_ShouldReturnExeption(MyLinkedList list)
        {
            Assert.Throws<Exception>(() => list.FindIndexOfMin());
        }
        
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
        
        [TestCaseSource(typeof(DeleteFirstByValueTestSource))]
        public void DeleteFirstByValueTest(int value, MyLinkedList list, int expectedIndexOfElement, MyLinkedList expectedList)
        {
            int actualIndexOfElement = list.DeleteFirstByValue(value);
            MyLinkedList actualList = list;
            Assert.AreEqual(expectedIndexOfElement, actualIndexOfElement);
            Assert.AreEqual(expectedList, actualList);
        }
        
        [TestCaseSource(typeof(DeleteAllByValueTestSource))]
        public void DeleteAllByValueTest(int value, MyLinkedList list, int expectedCountOfElements, MyLinkedList expectedList)
        {
            int actualCountOfElements = list.DeleteAllByValue(value);
            MyLinkedList actualList = list;
            Assert.AreEqual(expectedCountOfElements, actualCountOfElements);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteAllByValueTest_WhenEmpyList_ShouldReturnExeptionSource))]
        public void DeleteAllByValueTest_WhenEmpyList_ShouldReturnExeption(int value, MyLinkedList list)
        {
            Assert.Throws<Exception>(() => list.DeleteAllByValue(value));
        }
        
        [TestCaseSource(typeof(AddListTestSource))]
        public void AddListTest(MyLinkedList list, MyLinkedList originalList, MyLinkedList expectedList)
        {
            originalList.AddList(list);
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
