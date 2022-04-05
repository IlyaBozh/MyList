
using NUnit.Framework;
using System;

namespace MyArrayList.Tests
{
    public class MyArrayListTests
    {
        [TestCaseSource(typeof(AddTestSource))]
        public void AddTest(int element, ICollection list, ICollection expectedList)
        {
            list.Add(element);
            ICollection actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AddFirstTestSource))]
        public void AddFirstTest(int value, ICollection list, ICollection expectedList)
        {
            list.AddFirst(value);
            ICollection actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AddByIndexTestSource))]
        public void AddByIndexTest(int index, int value, ICollection list, ICollection expectedList)
        {
            list.AddByIndex(index, value);
            ICollection actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AddByIndexTest_WhenIndexOutOfRange_ShouldReturnOutOfRangeExeptionSource))]
        public void AddByIndexTest_WhenIndexOutOfRange_ShouldReturnOutOfRangeExeption(int index, int value, ICollection list)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => list.AddByIndex(index, value));
        }

        [TestCaseSource(typeof(DeleteLastTestSource))]
        public void DeleteLastTest(ICollection list, ICollection expectedList)
        {
            list.DeleteLast();
            ICollection actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteLastTest_WhenListIsEmpty_ShouldReturnExeptionSource))]
        public void DeleteLastTest_WhenListIsEmpty_ShouldReturnExeption(ICollection list)
        {
            Assert.Throws<Exception>(() => list.DeleteLast());
        }

        [TestCaseSource(typeof(DeleteFirstTestSource))]
        public void DeleteFirstTest(ICollection list, ICollection expectedList)
        {
            list.DeleteFirst();
            ICollection actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteFirstTest_WhenListIsEmpty_ShouldReturnExeptionSource))]
        public void DeleteFirstTest_WhenListIsEmpty_ShouldReturnExeption(ICollection list)
        {
            Assert.Throws<Exception>(() => list.DeleteLast());
        }
        
        [TestCaseSource(typeof(DeleteByIndexTestSource))]
        public void DeleteByIndexTest(int index, ICollection list, ICollection expectedList)
        {
            list.DeleteByIndex(index);
            ICollection actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteByIndexTest_WhenIndexOutOfRange_ShouldReturnOutOfRangeExeptionSource))]
        public void DeleteByIndexTest_WhenIndexOutOfRange_ShouldReturnOutOfRangeExeption(int index, ICollection list)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => list.DeleteByIndex(index));
        }

        [TestCaseSource(typeof(DeleteElementsFromEndTestSource))]
        public void DeleteElementsFromEndTest(int countElement, ICollection list, ICollection expectedList)
        {
            list.DeleteElementsFromEnd(countElement);
            ICollection actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteElementsFromEndTest_WhenCountLessThanOne_ShouldReturnArgumentExeptionSource))]
        public void DeleteElementsFromEndTest_WhenCountLessThanOne_ShouldReturnArgumentExeption(int countElement, ICollection list)
        {
            Assert.Throws<ArgumentException>(() => list.DeleteElementsFromEnd(countElement));
        }

        [TestCaseSource(typeof(DeleteElementsFromBeginTestSource))]
        public void DeleteElementsFromBeginTest(int countElement, ICollection list, ICollection expectedList)
        {
            list.DeleteElementsFromBegin(countElement);
            ICollection actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteElementsFromBeginTest_WhenCountLessThanOne_ShouldReturnArgumentExeptionSource))]
        public void DeleteElementsFromBeginTest_WhenCountLessThanOne_ShouldReturnArgumentExeption(int countElement, ICollection list)
        {
            Assert.Throws<ArgumentException>(() => list.DeleteElementsFromBegin(countElement));
        }

        [TestCaseSource(typeof(DeleteElementsByIndexTestSource))]
        public void DleteElementsByIndexTest(int index, int countElement, ICollection list, ICollection expectedList)
        {
            list.DeleteElementsByIndex(index, countElement);
            ICollection actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteElementsByIndexTest_WhenCountLessThanOne_ShouldReturnArgumentExeptionSource))]
        public void DleteElementsByIndexTest_WhenCountLessThanOne_ShouldReturnArgumentExeption(int index, int countElement, ICollection list)
        {
            Assert.Throws<ArgumentException>(() => list.DeleteElementsByIndex(index, countElement));
        }

        [TestCaseSource(typeof(DeleteElementsByIndexTest_WhenIndexOutOfRange_ShouldReturnOutOfRangeExeption))]
        public void DleteElementsByIndexTest_WhenIndexOutOfRange_ShouldReturnOutOfRangeExeption(int index, int countElement, ICollection list)
        {
            Assert.Throws<IndexOutOfRangeException>(() => list.DeleteElementsByIndex(index, countElement));
        }

        [TestCaseSource(typeof(FindIndexByValueTestSource))]
        public void FindIndexByValueTest(int value, ICollection list, int expectedIndex)
        {
            int actualIndex = list.FindIndexByValue(value);
            Assert.AreEqual(expectedIndex, actualIndex);
        }

        [TestCaseSource(typeof(ReverseTestSource))]
        public void ReverseTest(ICollection list, ICollection expectedList)
        {
            list.Reverse();
            ICollection actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(FindMaxTestSource))]
        public void FindMaxTest(ICollection list, int expectedMaxElement)
        {
            int actualMaxElement = list.FindMax();
            Assert.AreEqual(expectedMaxElement, actualMaxElement);
        }

        [TestCaseSource(typeof(FindMaxTest_WhenEmpyList_ShouldReturnExeptionSource))]
        public void FindMaxTest_WhenEmpyList_ShouldReturnExeption(ICollection list)
        {
            Assert.Throws<Exception>(() => list.FindMax());
        }

        [TestCaseSource(typeof(FindMinTestSource))]
        public void FindMinTest(ICollection list, int expectedMinElement)
        {
            int actualMinElement = list.FindMin();
            Assert.AreEqual(expectedMinElement, actualMinElement);
        }

        [TestCaseSource(typeof(FindMinTest_WhenEmpyList_ShouldReturnExeptionSource))]
        public void FindMinTest_WhenEmpyList_ShouldReturnExeption(ICollection list)
        {
            Assert.Throws<Exception>(() => list.FindMin());
        }

        [TestCaseSource(typeof(FindIndexOfMaxTestSource))]
        public void FindIndexOfMaxTest(ICollection list, int expectedIndexOfMaxElement)
        {
            int actualIndexOfMaxElement = list.FindIndexOfMax();
            Assert.AreEqual(expectedIndexOfMaxElement, actualIndexOfMaxElement);
        }

        [TestCaseSource(typeof(FindIndexOfMaxTest_WhenEmpyList_ShouldReturnExeptionSource))]
        public void FindIndexOfMaxTest_WhenEmpyList_ShouldReturnExeption(ICollection list)
        {
            Assert.Throws<Exception>(() => list.FindIndexOfMax());
        }

        [TestCaseSource(typeof(FindIndexOfMinTestSource))]
        public void FindIndexOfMinTest(ICollection list, int expectedIndexOfMinElement)
        {
            int actualIndexOfMinElement = list.FindIndexOfMin();
            Assert.AreEqual(expectedIndexOfMinElement, actualIndexOfMinElement);
        }

        [TestCaseSource(typeof(FindIndexOfMinTest_WhenEmpyList_ShouldReturnExeptionSource))]
        public void FindIndexOfMinTest_WhenEmpyList_ShouldReturnExeption(ICollection list)
        {
            Assert.Throws<Exception>(() => list.FindIndexOfMin());
        }

        [TestCaseSource(typeof(SortAscendingTestSource))]
        public void SortAscendingTest(ICollection list, ICollection expectedList)
        {
            list.SortAscending();
            ICollection actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(SortDescendingTestSource))]
        public void SortDescendingTest(ICollection list, ICollection expectedList)
        {
            list.SortDescending();
            ICollection actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteFirstByValueTestSource))]
        public void DeleteFirstByValueTest(int value, ICollection list, int expectedIndexOfElement, ICollection expectedList)
        {
            int actualIndexOfElement = list.DeleteFirstByValue(value);
            ICollection actualList = list;
            Assert.AreEqual(expectedIndexOfElement, actualIndexOfElement);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteAllByValueTestSource))]
        public void DeleteAllByValueTest(int value, ICollection list, int expectedCountOfElements, ICollection expectedList)
        {
            int actualCountOfElements = list.DeleteAllByValue(value);
            ICollection actualList = list;
            Assert.AreEqual(expectedCountOfElements, actualCountOfElements);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteAllByValueTest_WhenEmpyList_ShouldReturnExeptionSource))]
        public void DeleteAllByValueTest_WhenEmpyList_ShouldReturnExeption(int value, ICollection list)
        {
            Assert.Throws<Exception>(() => list.DeleteAllByValue(value));
        }

        [TestCaseSource(typeof(AddListTestSource))]
        public void AddListTest(ICollection list, ICollection originalList, ICollection expectedList)
        {
            originalList.AddList(list);
            ICollection actualList = originalList;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AddListTest_WhenListIsNull_ShouldReturnArgumentNullExceptionSource))]
        public void AddListTest_WhenListIsNull_ShouldReturnArgumentNullException(ICollection list, ICollection originalList)
        {
            Assert.Throws<ArgumentNullException>(() => originalList.AddList(list));
        }

        [TestCaseSource(typeof(AddListToBeginTestSource))]
        public void AddListToBeginTest(ICollection list, ICollection originalList, ICollection expectedList)
        {
            originalList.AddListToBegin(list);
            ICollection actualList = originalList;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AddListToBeginTest_WhenListIsNull_ShouldReturnArgumentNullExceptionSource))]
        public void AddListToBeginTest_WhenListIsNull_ShouldReturnArgumentNullException(ICollection list, ICollection originalList)
        {
            Assert.Throws<ArgumentNullException>(() => originalList.AddListToBegin(list));
        }

        [TestCaseSource(typeof(AddListByIndexTestSource))]
        public void AddListByIndexTest(ICollection list, int index, ICollection originalList, ICollection expectedList)
        {
            originalList.AddListByIndex(list, index);
            ICollection actualList = originalList;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AddListByIndexTest_WhenIndexOutOfRange_ShouldReturnArgumentOutOfRangeExceptionSource))]
        public void AddListByIndexTest_WhenIndexOutOfRange_ShouldReturnArgumentOutOfRangeException(
            ICollection list, int index, ICollection originalList
            )
        {
            Assert.Throws<IndexOutOfRangeException>(() => originalList.AddListByIndex(list, index));
        }

        [TestCaseSource(typeof(AddListByIndexTest_WhenListIsNull_ShouldReturnArgumentNullExceptionSource))]
        public void AddListByIndexTest_WhenListIsNull_ShouldReturnArgumentNullException(
            ICollection list, int index, ICollection originalList
            )
        {
            Assert.Throws<ArgumentNullException>(() => originalList.AddListByIndex(list, index));
        }
    }
}