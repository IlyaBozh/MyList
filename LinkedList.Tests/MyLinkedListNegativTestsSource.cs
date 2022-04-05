using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList.Tests
{
    public class AddByIndexTest_WhenIndexOutOfRange_ShouldReturnOutOfRangeExeptionSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { -1, 0, new MyLinkedList(new int[] { 1, 2, 3 }) };
            yield return new object[] { 3, -2, new MyLinkedList(new int[] { -1, -2, -3 }) };
            yield return new object[] { 27, 5, new MyLinkedList(new int[] { 1, 1, 1, 1, 1, 1 }) };
        }
    }

    public class DeleteLastTest_WhenListIsEmpty_ShouldReturnExeptionSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new MyLinkedList() };
        }
    }
    
    public class DeleteFirstTest_WhenListIsEmpty_ShouldReturnExeptionSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new MyLinkedList() };
        }
    }
    
    public class DeleteByIndexTest_WhenIndexOutOfRange_ShouldReturnOutOfRangeExeptionSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 5, new MyLinkedList(new int[] { 1, 2, 3 }) };
            yield return new object[] { -1, new MyLinkedList(new int[] { -1, -2, -3 }) };
            yield return new object[] { 0, new MyLinkedList() };
        }
    }
    
    public class DeleteElementsFromEndTest_WhenCountLessThanOne_ShouldReturnArgumentExeptionSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { -5, new MyLinkedList(new int[] { 1, 2, 3 }) };
            yield return new object[] { -1, new MyLinkedList(new int[] { -1, -2, -3 }) };
            yield return new object[] { 0, new MyLinkedList(new int[] { -1, -2, -3 }) };
        }
    }
    
    public class DeleteElementsFromBeginTest_WhenCountLessThanOne_ShouldReturnArgumentExeptionSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { -5, new MyLinkedList(new int[] { 1, 2, 3 }) };
            yield return new object[] { -1, new MyLinkedList(new int[] { -1, -2, -3 }) };
            yield return new object[] { 0, new MyLinkedList(new int[] { -1, -2, -3 }) };
        }
    }
    
    public class DeleteElementsByIndexTest_WhenCountLessThanOne_ShouldReturnArgumentExeptionSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 2, -5, new MyLinkedList(new int[] { 1, 2, 3 }) };
            yield return new object[] { 1, -1, new MyLinkedList(new int[] { -1, -2, -3 }) };
            yield return new object[] { 0, 0, new MyLinkedList(new int[] { -1, -2, -3 }) };
        }
    }

    public class DeleteElementsByIndexTest_WhenIndexOutOfRange_ShouldReturnOutOfRangeExeption : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { -1, 2, new MyLinkedList(new int[] { 1, 2, 3 }) };
            yield return new object[] { -24, 1, new MyLinkedList(new int[] { -1, -2, -3 }) };
            yield return new object[] { 5, 2, new MyLinkedList(new int[] { -1, -2, -3 }) };
        }
    }
    
    public class FindMaxTest_WhenEmpyList_ShouldReturnExeptionSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new MyLinkedList() };
        }
    }
    
    public class FindMinTest_WhenEmpyList_ShouldReturnExeptionSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new MyLinkedList() };
        }
    }
    
    public class FindIndexOfMaxTest_WhenEmpyList_ShouldReturnExeptionSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new MyLinkedList() };
        }
    }
    
    public class FindIndexOfMinTest_WhenEmpyList_ShouldReturnExeptionSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new MyLinkedList() };
        }
    }

    public class DeleteAllByValueTest_WhenEmpyList_ShouldReturnExeptionSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 2, new MyLinkedList() };
        }
    }

    public class AddListByIndexTest_WhenIndexOutOfRange_ShouldReturnArgumentOutOfRangeExceptionSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new MyLinkedList(12), -1, new MyLinkedList(12) };
            yield return new object[] { new MyLinkedList(12), -27, new MyLinkedList(12) };
            yield return new object[] { new MyLinkedList(12), 4, new MyLinkedList(12) };
        }
    }
}
