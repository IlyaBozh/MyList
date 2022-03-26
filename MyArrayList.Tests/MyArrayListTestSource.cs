using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyArrayList.Tests
{
    public class AddLastTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 0, new MyArrayList(new int[] { 1, 2, 3 }), new MyArrayList(new int[] { 1, 2, 3, 0 }) };
            yield return new object[] { -2, new MyArrayList(new int[] { -1, -2, -3 }), new MyArrayList(new int[] { -1, -2, -3, -2 }) };
            yield return new object[] { 12, new MyArrayList(), new MyArrayList(12) };
            yield return new object[] { 2, new MyArrayList(), new MyArrayList(new int[] { 2 }) };
        }
    }

    public class AddFirstTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 0, new MyArrayList(new int[] { 1, 2, 3 }), new MyArrayList(new int[] { 0, 1, 2, 3 }) };
            yield return new object[] { -2, new MyArrayList(new int[] { -1, -2, -3 }), new MyArrayList(new int[] { -2, -1, -2, -3 }) };
            yield return new object[] { 12, new MyArrayList(), new MyArrayList(12) };
            yield return new object[] { 2, new MyArrayList(), new MyArrayList(new int[] { 2 }) };
        }
    }

    public class AddByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 0, 0, new MyArrayList(new int[] { 1, 2, 3 }), new MyArrayList(new int[] { 0, 1, 2, 3 }) };
            yield return new object[] { 2, -2, new MyArrayList(new int[] { -1, -2, -3 }), new MyArrayList(new int[] { -1, -2, -2, -3 }) };
            yield return new object[] { 3, 5, new MyArrayList(new int[] { 1, 1, 1, 1, 1, 1 }), new MyArrayList(new int[] { 1, 1, 1, 5, 1, 1, 1 }) };
        }
    }

    public class AddByIndexTest_WhenIndexOutOfRange_ShouldReturnOutOfRangeExeptionSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { -1, 0, new MyArrayList(new int[] { 1, 2, 3 }) };
            yield return new object[] { 3, -2, new MyArrayList(new int[] { -1, -2, -3 }) };
            yield return new object[] { 27, 5, new MyArrayList(new int[] { 1, 1, 1, 1, 1, 1 }) };
        }
    }

    public class DeleteLastTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new MyArrayList(new int[] { 1, 2, 3 }), new MyArrayList(new int[] { 1, 2 }) };
            yield return new object[] { new MyArrayList(new int[] { -1, -2, -3 }), new MyArrayList(new int[] { -1, -2 }) };
            yield return new object[] { new MyArrayList(4), new MyArrayList() };
        }
    }

    public class DeleteLastTest_WhenListIsEmpty_ShouldReturnExeptionSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new MyArrayList() };
        }
    }

    public class DeleteFirstTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new MyArrayList(new int[] { 1, 2, 3 }), new MyArrayList(new int[] { 2, 3 }) };
            yield return new object[] { new MyArrayList(new int[] { -1, -2, -3 }), new MyArrayList(new int[] { -2, -3 }) };
            yield return new object[] { new MyArrayList(4), new MyArrayList() };
        }
    }

    public class DeleteFirstTest_WhenListIsEmpty_ShouldReturnExeptionSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new MyArrayList() };
        }
    }

    public class DeleteByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 1, new MyArrayList(new int[] { 1, 2, 3 }), new MyArrayList(new int[] { 1, 3 }) };
            yield return new object[] { 2, new MyArrayList(new int[] { -1, -2, -3, -4, -5 }), new MyArrayList(new int[] { -1, -2, -4, -5 }) };
            yield return new object[] { 0, new MyArrayList(4), new MyArrayList() };
        }
    }

    public class DeleteByIndexTest_WhenIndexOutOfRange_ShouldReturnOutOfRangeExeptionSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 5, new MyArrayList(new int[] { 1, 2, 3 }) };
            yield return new object[] { -1, new MyArrayList(new int[] { -1, -2, -3 }) };
        }
    }
}
