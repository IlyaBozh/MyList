﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyArrayList.Tests
{
    public class AddTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 0, new MyArrayList(new int[] { 1, 2, 3 }), new MyArrayList(new int[] { 1, 2, 3, 0 }) };
            yield return new object[] { -2, new MyArrayList(new int[] { -1, -2, -3 }), new MyArrayList(new int[] { -1, -2, -3, -2 }) };
            yield return new object[] { 12, new MyArrayList(), new MyArrayList(12) };
            yield return new object[] { 2, new MyArrayList(), new MyArrayList(new int[] { 2 }) };

            yield return new object[] { 0, new MyLinkedList(new int[] { 1, 2, 3 }), new MyLinkedList(new int[] { 1, 2, 3, 0 }) };
            yield return new object[] { -2, new MyLinkedList(new int[] { -1, -2, -3 }), new MyLinkedList(new int[] { -1, -2, -3, -2 }) };
            yield return new object[] { 12, new MyLinkedList(), new MyLinkedList(12) };
            yield return new object[] { 2, new MyLinkedList(), new MyLinkedList(2) };
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

            yield return new object[] { 0, new MyLinkedList(new int[] { 1, 2, 3 }), new MyLinkedList(new int[] { 0, 1, 2, 3 }) };
            yield return new object[] { -2, new MyLinkedList(new int[] { -1, -2, -3 }), new MyLinkedList(new int[] { -2, -1, -2, -3 }) };
            yield return new object[] { 12, new MyLinkedList(), new MyLinkedList(12) };
            yield return new object[] { 2, new MyLinkedList(), new MyLinkedList(2) };
        }
    }

    public class AddByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 0, 0, new MyArrayList(new int[] { 1, 2, 3 }), new MyArrayList(new int[] { 0, 1, 2, 3 }) };
            yield return new object[] { 2, -2, new MyArrayList(new int[] { -1, -2, -3 }), new MyArrayList(new int[] { -1, -2, -2, -3 }) };
            yield return new object[] { 3, 5, new MyArrayList(new int[] { 1, 1, 1, 1, 1, 1 }), new MyArrayList(new int[] { 1, 1, 1, 5, 1, 1, 1 }) };

            yield return new object[] { 0, 0, new MyLinkedList(new int[] { 1, 2, 3 }), new MyLinkedList(new int[] { 0, 1, 2, 3 }) };
            yield return new object[] { 2, -2, new MyLinkedList(new int[] { -1, -2, -3 }), new MyLinkedList(new int[] { -1, -2, -2, -3 }) };
            yield return new object[] { 3, 5, new MyLinkedList(new int[] { 1, 1, 1, 1, 1, 1 }), new MyLinkedList(new int[] { 1, 1, 1, 5, 1, 1, 1 }) };
        }
    }

    public class DeleteLastTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new MyArrayList(new int[] { 1, 2, 3 }), new MyArrayList(new int[] { 1, 2 }) };
            yield return new object[] { new MyArrayList(new int[] { -1, -2, -3 }), new MyArrayList(new int[] { -1, -2 }) };
            yield return new object[] { new MyArrayList(4), new MyArrayList() };

            yield return new object[] { new MyLinkedList(new int[] { 1, 2, 3 }), new MyLinkedList(new int[] { 1, 2 }) };
            yield return new object[] { new MyLinkedList(new int[] { -1, -2, -3 }), new MyLinkedList(new int[] { -1, -2 }) };
            yield return new object[] { new MyLinkedList(4), new MyLinkedList() };
            yield return new object[] { new MyLinkedList(new int[] { -1, -2 }), new MyLinkedList(-1) };
        }
    }

    public class DeleteFirstTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new MyArrayList(new int[] { 1, 2, 3 }), new MyArrayList(new int[] { 2, 3 }) };
            yield return new object[] { new MyArrayList(new int[] { -1, -2, -3 }), new MyArrayList(new int[] { -2, -3 }) };
            yield return new object[] { new MyArrayList(4), new MyArrayList() };

            yield return new object[] { new MyLinkedList(new int[] { 1, 2, 3 }), new MyLinkedList(new int[] { 2, 3 }) };
            yield return new object[] { new MyLinkedList(new int[] { -1, -2 }), new MyLinkedList(new int[] { -2 }) };
            yield return new object[] { new MyLinkedList(4), new MyLinkedList() };
        }
    }

    public class DeleteByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 1, new MyArrayList(new int[] { 1, 2, 3 }), new MyArrayList(new int[] { 1, 3 }) };
            yield return new object[] { 2, new MyArrayList(new int[] { -1, -2, -3, -4, -5 }), new MyArrayList(new int[] { -1, -2, -4, -5 }) };
            yield return new object[] { 0, new MyArrayList(4), new MyArrayList() };

            yield return new object[] { 1, new MyLinkedList(new int[] { 1, 2, 3 }), new MyLinkedList(new int[] { 1, 3 }) };
            yield return new object[] { 2, new MyLinkedList(new int[] { -1, -2, -3, -4, -5 }), new MyLinkedList(new int[] { -1, -2, -4, -5 }) };
            yield return new object[] { 0, new MyLinkedList(4), new MyLinkedList() };
        }
    }

    public class DeleteElementsFromEndTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 2, new MyArrayList(new int[] { 1, 2, 3 }), new MyArrayList(new int[] { 1 }) };
            yield return new object[] { 5, new MyArrayList(new int[] { -1, -2, -3, 4, 5, 6, 3 }), new MyArrayList(new int[] { -1, -2 }) };
            yield return new object[] { 12, new MyArrayList(new int[] { -1, -2, -3, 4, 5, 6, 3 }), new MyArrayList() };
            yield return new object[] { 1, new MyArrayList(1), new MyArrayList() };

            yield return new object[] { 2, new MyLinkedList(new int[] { 1, 2, 3 }), new MyLinkedList(new int[] { 1 }) };
            yield return new object[] { 5, new MyLinkedList(new int[] { -1, -2, -3, 4, 5, 6, 3 }), new MyLinkedList(new int[] { -1, -2 }) };
            yield return new object[] { 12, new MyLinkedList(new int[] { -1, -2, -3, 4, 5, 6, 3 }), new MyLinkedList() };
            yield return new object[] { 1, new MyLinkedList(1), new MyLinkedList() };
        }
    }

    public class DeleteElementsFromBeginTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 2, new MyArrayList(new int[] { 1, 2, 3 }), new MyArrayList(new int[] { 3 }) };
            yield return new object[] { 5, new MyArrayList(new int[] { -1, -2, -3, 4, 5, 6, 3 }), new MyArrayList(new int[] { 6, 3 }) };
            yield return new object[] { 12, new MyArrayList(new int[] { -1, -2, -3, 4, 5, 6, 3 }), new MyArrayList() };
            yield return new object[] { 1, new MyArrayList(1), new MyArrayList() };

            yield return new object[] { 1, new MyLinkedList(new int[] { 1, 2 }), new MyLinkedList(new int[] { 2 }) };
            yield return new object[] { 5, new MyLinkedList(new int[] { -1, -2, -3, 4, 5, 6, 3 }), new MyLinkedList(new int[] { 6, 3 }) };
            yield return new object[] { 12, new MyLinkedList(new int[] { -1, -2, -3, 4, 5, 6, 3 }), new MyLinkedList() };
            yield return new object[] { 1, new MyLinkedList(1), new MyLinkedList() };
        }
    }

    public class DeleteElementsByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 1, 2, new MyArrayList(new int[] { 1, 2, 3, 4, 5 }), new MyArrayList(new int[] { 1, 4, 5 }) };
            yield return new object[] { 3, 5, new MyArrayList(new int[] { -1, -2, -3, 4, 5, 6, 3 }), new MyArrayList(new int[] { -1, -2, -3 }) };
            yield return new object[] { 0, 12, new MyArrayList(new int[] { -1, -2, -3, 4, 5, 6, 3 }), new MyArrayList() };
            yield return new object[] { 6, 12, new MyArrayList(new int[] { -1, -2, -3, 4, 5, 6, 3 }), new MyArrayList(new int[] { -1, -2, -3, 4, 5, 6 }) };
            yield return new object[] { 0, 1, new MyArrayList(1), new MyArrayList() };

            yield return new object[] { 1, 2, new MyLinkedList(new int[] { 1, 2, 3, 4, 5 }), new MyLinkedList(new int[] { 1, 4, 5 }) };
            yield return new object[] { 3, 5, new MyLinkedList(new int[] { -1, -2, -3, 4, 5, 6, 3 }), new MyLinkedList(new int[] { -1, -2, -3 }) };
            yield return new object[] { 0, 12, new MyLinkedList(new int[] { -1, -2, -3, 4, 5, 6, 3 }), new MyLinkedList() };
            yield return new object[] { 6, 12, new MyLinkedList(new int[] { -1, -2, -3, 4, 5, 6, 3 }), new MyLinkedList(new int[] { -1, -2, -3, 4, 5, 6 }) };
            yield return new object[] { 0, 1, new MyLinkedList(1), new MyLinkedList() };
        }
    }

    public class FindIndexByValueTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 2, new MyArrayList(new int[] { 1, 2, 3, 4, 5 }), 1 };
            yield return new object[] { 5, new MyArrayList(new int[] { -1, -2, -3, 4, 5, 6, 3 }), 4 };
            yield return new object[] { 12, new MyArrayList(new int[] { -1, -2, -3, 4, 5, 6, 3 }), -1 };
            yield return new object[] { 12, new MyArrayList(), -1 };

            yield return new object[] { 2, new MyLinkedList(new int[] { 1, 2, 3, 4, 5 }), 1 };
            yield return new object[] { 5, new MyLinkedList(new int[] { -1, -2, -3, 4, 5, 6, 3 }), 4 };
            yield return new object[] { 12, new MyLinkedList(new int[] { -1, -2, -3, 4, 5, 6, 3 }), -1 };
            yield return new object[] { 1, new MyLinkedList(1), 0 };
            yield return new object[] { 12, new MyLinkedList(), -1 };
        }
    }

    public class ReverseTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new MyArrayList(new int[] { 1, 2, 3, 4, 5 }), new MyArrayList(new int[] { 5, 4, 3, 2, 1 }) };
            yield return new object[] { new MyArrayList(new int[] { -1, -2, -3, 4, 5, 6, 3 }), new MyArrayList(new int[] { 3, 6, 5, 4, -3, -2, -1 }) };
            yield return new object[] { new MyArrayList(234), new MyArrayList(234) };
            yield return new object[] { new MyArrayList(), new MyArrayList() };

            yield return new object[] { new MyLinkedList(new int[] { 1, 2, 3, 4, 5 }), new MyLinkedList(new int[] { 5, 4, 3, 2, 1 }) };
            yield return new object[] { new MyLinkedList(new int[] { -1, -2, -3, 4, 5, 6, 3 }), new MyLinkedList(new int[] { 3, 6, 5, 4, -3, -2, -1 }) };
            yield return new object[] { new MyLinkedList(234), new MyLinkedList(234) };
            yield return new object[] { new MyLinkedList(), new MyLinkedList() };
        }
    }

    public class FindMaxTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new MyArrayList(new int[] { 1, 2, 3, 4, 5 }), 5 };
            yield return new object[] { new MyArrayList(new int[] { -1, -2, -3, 4, 5, 6, 3 }), 6 };
            yield return new object[] { new MyArrayList(new int[] { -1, -2, -3, 56, 3, 6, 3 }), 56 };
            yield return new object[] { new MyArrayList(new int[] { 5, 5, 5, 3, 6, 6, 2 }), 6 };

            yield return new object[] { new MyLinkedList(new int[] { 1, 2, 3, 4, 5 }), 5 };
            yield return new object[] { new MyLinkedList(new int[] { -1, -2, -3, 4, 5, 6, 3 }), 6 };
            yield return new object[] { new MyLinkedList(new int[] { -1, -2, -3, 56, 3, 6, 3 }), 56 };
            yield return new object[] { new MyLinkedList(new int[] { 5, 5, 5, 3, 6, 6, 2 }), 6 };
        }
    }

    public class FindMinTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new MyArrayList(new int[] { 1, 2, 3, 4, 5 }), 1 };
            yield return new object[] { new MyArrayList(new int[] { -1, -2, -3, 4, 5, 6, 3 }), -3 };
            yield return new object[] { new MyArrayList(new int[] { -123, -2, -3, 56, 3, 6, 3 }), -123 };
            yield return new object[] { new MyArrayList(new int[] { 5, 5, 5, 2, 3, 6, 6, 2 }), 2 };

            yield return new object[] { new MyLinkedList(new int[] { 1, 2, 3, 4, 5 }), 1 };
            yield return new object[] { new MyLinkedList(new int[] { -1, -2, -3, 4, 5, 6, 3 }), -3 };
            yield return new object[] { new MyLinkedList(new int[] { -123, -2, -3, 56, 3, 6, 3 }), -123 };
            yield return new object[] { new MyLinkedList(new int[] { 5, 5, 5, 2, 3, 6, 6, 2 }), 2 };
        }
    }

    public class FindIndexOfMaxTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new MyArrayList(new int[] { 1, 2, 3, 4, 5 }), 4 };
            yield return new object[] { new MyArrayList(new int[] { -1, -2, -3, 4, 5, 6, 3 }), 5 };
            yield return new object[] { new MyArrayList(new int[] { -1, -2, -3, 56, 3, 6, 3 }), 3 };
            yield return new object[] { new MyArrayList(new int[] { 5, 5, 5, 3, 6, 6, 2 }), 4 };

            yield return new object[] { new MyLinkedList(new int[] { 1, 2, 3, 4, 5 }), 4 };
            yield return new object[] { new MyLinkedList(new int[] { -1, -2, -3, 4, 5, 6, 3 }), 5 };
            yield return new object[] { new MyLinkedList(new int[] { -1, -2, -3, 56, 3, 6, 3 }), 3 };
            yield return new object[] { new MyLinkedList(new int[] { 5, 5, 5, 3, 6, 6, 2 }), 4 };
        }
    }

    public class FindIndexOfMinTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new MyArrayList(new int[] { 1, 2, 3, 4, 5 }), 0 };
            yield return new object[] { new MyArrayList(new int[] { -1, -2, -3, 4, 5, 6, 3 }), 2 };
            yield return new object[] { new MyArrayList(new int[] { -123, -2, -3, 56, 3, 6, 3 }), 0 };
            yield return new object[] { new MyArrayList(new int[] { 5, 5, 5, 2, 3, 6, 6, 2 }), 3 };

            yield return new object[] { new MyLinkedList(new int[] { 1, 2, 3, 4, 5 }), 0 };
            yield return new object[] { new MyLinkedList(new int[] { -1, -2, -3, 4, 5, 6, 3 }), 2 };
            yield return new object[] { new MyLinkedList(new int[] { -123, -2, -3, 56, 3, 6, 3 }), 0 };
            yield return new object[] { new MyLinkedList(new int[] { 5, 5, 5, 2, 3, 6, 6, 2 }), 3 };
        }
    }

    public class SortAscendingTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new MyArrayList(new int[] { 4, -2, 5, 11 }), new MyArrayList(new int[] { -2, 4, 5, 11 }) };
            yield return new object[] { new MyArrayList(new int[] { -1, -2, -3, 23, 5, 2, 3 }), new MyArrayList(new int[] { -3, -2, -1, 2, 3, 5, 23 }) };
            yield return new object[] { new MyArrayList(234), new MyArrayList(234) };
            yield return new object[] { new MyArrayList(), new MyArrayList() };

            yield return new object[] { new MyLinkedList(new int[] { 4, -2, 5, 11 }), new MyLinkedList(new int[] { -2, 4, 5, 11 }) };
            yield return new object[] { new MyLinkedList(new int[] { -1, -2, -3, 23, 5, 2, 3 }), new MyLinkedList(new int[] { -3, -2, -1, 2, 3, 5, 23 }) };
            yield return new object[] { new MyLinkedList(234), new MyLinkedList(234) };
            yield return new object[] { new MyLinkedList(), new MyLinkedList() };
        }
    }

    public class SortDescendingTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new MyArrayList(new int[] { 4, -2, 5, 11 }), new MyArrayList(new int[] { 11, 5, 4, -2 }) };
            yield return new object[] { new MyArrayList(new int[] { -1, -2, -3, 23, 5, 2, 3 }), new MyArrayList(new int[] { 23, 5, 3, 2, -1, -2, -3 }) };
            yield return new object[] { new MyArrayList(234), new MyArrayList(234) };
            yield return new object[] { new MyArrayList(), new MyArrayList() };

            yield return new object[] { new MyLinkedList(new int[] { 4, -2, 5, 11 }), new MyLinkedList(new int[] { 11, 5, 4, -2 }) };
            yield return new object[] { new MyLinkedList(new int[] { -1, -2, -3, 23, 5, 2, 3 }), new MyLinkedList(new int[] { 23, 5, 3, 2, -1, -2, -3 }) };
            yield return new object[] { new MyLinkedList(234), new MyLinkedList(234) };
            yield return new object[] { new MyLinkedList(), new MyLinkedList() };
        }
    }

    public class DeleteFirstByValueTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 2, new MyArrayList(new int[] { 1, 2, 3, 4, 5 }), 1, new MyArrayList(new int[] { 1, 3, 4, 5 }) };
            yield return new object[] { 5, new MyArrayList(new int[] { -1, -2, -3, 4, 5, 5, 3 }), 4, new MyArrayList(new int[] { -1, -2, -3, 4, 5, 3 }) };
            yield return new object[] { 12, new MyArrayList(new int[] { -1, -2, -3, 4, 5, 6, 3 }), -1, new MyArrayList(new int[] { -1, -2, -3, 4, 5, 6, 3 }) };
            yield return new object[] { 12, new MyArrayList(), -1, new MyArrayList() };
            yield return new object[] { 12, new MyArrayList(12), 0, new MyArrayList() };

            yield return new object[] { 2, new MyLinkedList(new int[] { 1, 2, 3, 4, 5 }), 1, new MyLinkedList(new int[] { 1, 3, 4, 5 }) };
            yield return new object[] { 5, new MyLinkedList(new int[] { -1, -2, -3, 4, 5, 5, 3 }), 4, new MyLinkedList(new int[] { -1, -2, -3, 4, 5, 3 }) };
            yield return new object[] { 12, new MyLinkedList(new int[] { -1, -2, -3, 4, 5, 6, 3 }), -1, new MyLinkedList(new int[] { -1, -2, -3, 4, 5, 6, 3 }) };
            yield return new object[] { 12, new MyLinkedList(), -1, new MyLinkedList() };
            yield return new object[] { 12, new MyLinkedList(12), 0, new MyLinkedList() };
        }
    }

    public class DeleteAllByValueTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 2, new MyArrayList(new int[] { 1, 2, 3, 4, 5 }), 1, new MyArrayList(new int[] { 1, 3, 4, 5 }) };
            yield return new object[] { 5, new MyArrayList(new int[] { -1, 5, -3, 4, 5, 6, 3 }), 2, new MyArrayList(new int[] { -1, -3, 4, 6, 3 }) };
            yield return new object[] { 12, new MyArrayList(new int[] { -1, -2, -3, 4, 5, 6, 3 }), 0, new MyArrayList(new int[] { -1, -2, -3, 4, 5, 6, 3 }) };
            yield return new object[] { 12, new MyArrayList(), 0, new MyArrayList() };
            yield return new object[] { 12, new MyArrayList(12), 1, new MyArrayList() };

            yield return new object[] { 2, new MyLinkedList(new int[] { 1, 2, 3, 4, 5 }), 1, new MyLinkedList(new int[] { 1, 3, 4, 5 }) };
            yield return new object[] { 5, new MyLinkedList(new int[] { -1, 5, -3, 4, 5, 6, 5 }), 3, new MyLinkedList(new int[] { -1, -3, 4, 6 }) };
            yield return new object[] { 12, new MyLinkedList(new int[] { -1, -2, -3, 4, 5, 6, 3 }), 0, new MyLinkedList(new int[] { -1, -2, -3, 4, 5, 6, 3 }) };
            yield return new object[] { 12, new MyLinkedList(12), 1, new MyLinkedList() };
        }
    }

    public class AddListTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new MyArrayList(new int[] { 1, 2, 3, 4, 5 }), new MyArrayList(new int[] { 1 }), new MyArrayList(new int[] { 1, 1, 2, 3, 4, 5 }) };
            yield return new object[] { new MyArrayList(new int[] { -1, 5 }), new MyArrayList(new int[] { -1, -3, 4, 6, 3 }), new MyArrayList(new int[] { -1, -3, 4, 6, 3, -1, 5 }) };
            yield return new object[] { new MyArrayList(new int[] { }), new MyArrayList(new int[] { -1, -2, -3, 4, 5, 6, 3 }), new MyArrayList(new int[] { -1, -2, -3, 4, 5, 6, 3 }) };
            yield return new object[] { new MyArrayList(), new MyArrayList(), new MyArrayList() };
            yield return new object[] { new MyArrayList(12), new MyArrayList(), new MyArrayList(12) };

            yield return new object[] { new MyLinkedList(new int[] { 1, 2, 3, 4, 5 }), new MyLinkedList(new int[] { 1 }), new MyLinkedList(new int[] { 1, 1, 2, 3, 4, 5 }) };
            yield return new object[] { new MyLinkedList(new int[] { -1, 5 }), new MyLinkedList(new int[] { -1, -3, 4, 6, 3 }), new MyLinkedList(new int[] { -1, -3, 4, 6, 3, -1, 5 }) };
            yield return new object[] { new MyLinkedList(new int[] { }), new MyLinkedList(new int[] { -1, -2, -3, 4, 5, 6, 3 }), new MyLinkedList(new int[] { -1, -2, -3, 4, 5, 6, 3 }) };
            yield return new object[] { new MyLinkedList(), new MyLinkedList(), new MyLinkedList() };
            yield return new object[] { new MyLinkedList(12), new MyLinkedList(), new MyLinkedList(12) };
        }
    }

    public class AddListToBeginTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new MyArrayList(new int[] { 1, 2, 3, 4, 5 }), new MyArrayList(new int[] { 1 }), new MyArrayList(new int[] { 1, 2, 3, 4, 5, 1 }) };
            yield return new object[] { new MyArrayList(new int[] { -1, 5 }), new MyArrayList(new int[] { -1, -3, 4, 6, 3 }), new MyArrayList(new int[] { -1, 5, -1, -3, 4, 6, 3 }) };
            yield return new object[] { new MyArrayList(new int[] { }), new MyArrayList(new int[] { -1, -2, -3, 4, 5, 6, 3 }), new MyArrayList(new int[] { -1, -2, -3, 4, 5, 6, 3 }) };
            yield return new object[] { new MyArrayList(), new MyArrayList(), new MyArrayList() };
            yield return new object[] { new MyArrayList(12), new MyArrayList(), new MyArrayList(12) };

            yield return new object[] { new MyLinkedList(new int[] { 1, 2, 3, 4, 5 }), new MyLinkedList(new int[] { 1 }), new MyLinkedList(new int[] { 1, 2, 3, 4, 5, 1 }) };
            yield return new object[] { new MyLinkedList(new int[] { -1, 5 }), new MyLinkedList(new int[] { -1, -3, 4, 6, 3 }), new MyLinkedList(new int[] { -1, 5, -1, -3, 4, 6, 3 }) };
            yield return new object[] { new MyLinkedList(new int[] { }), new MyLinkedList(new int[] { -1, -2, -3, 4, 5, 6, 3 }), new MyLinkedList(new int[] { -1, -2, -3, 4, 5, 6, 3 }) };
            yield return new object[] { new MyLinkedList(), new MyLinkedList(), new MyLinkedList() };
            yield return new object[] { new MyLinkedList(12), new MyLinkedList(), new MyLinkedList(12) };
        }
    }

    public class AddListByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new MyArrayList(new int[] { 1, 2, 5 }), 1, new MyArrayList(new int[] { 1, 2, 5 }), new MyArrayList(new int[] { 1, 1, 2, 5, 2, 5 }) };
            yield return new object[] { new MyArrayList(new int[] { -1, 5 }), 3, new MyArrayList(new int[] { -1, -3, 4, 6, 3 }), new MyArrayList(new int[] { -1, -3, 4, -1, 5, 6, 3 }) };
            yield return new object[] { new MyArrayList(new int[] { }), 2, new MyArrayList(new int[] { -1, -2, -3, 4, 5, 6, 3 }), new MyArrayList(new int[] { -1, -2, -3, 4, 5, 6, 3 }) };
            yield return new object[] { new MyArrayList(12), 0, new MyArrayList(), new MyArrayList(12) };

            yield return new object[] { new MyLinkedList(new int[] { 1, 2, 5 }), 1, new MyLinkedList(new int[] { 1, 2, 5 }), new MyLinkedList(new int[] { 1, 1, 2, 5, 2, 5 }) };
            yield return new object[] { new MyLinkedList(new int[] { -1, 5 }), 3, new MyLinkedList(new int[] { -1, -3, 4, 6, 3 }), new MyLinkedList(new int[] { -1, -3, 4, -1, 5, 6, 3 }) };
            yield return new object[] { new MyLinkedList(new int[] { }), 2, new MyLinkedList(new int[] { -1, -2, -3, 4, 5, 6, 3 }), new MyLinkedList(new int[] { -1, -2, -3, 4, 5, 6, 3 }) };
            yield return new object[] { new MyLinkedList(12), 0, new MyLinkedList(), new MyLinkedList(12) };
            yield return new object[] { new MyLinkedList(new int[] { -1, 5 }), 5, new MyLinkedList(new int[] { -1, -3, 4, 6, 3 }), new MyLinkedList(new int[] { -1, -3, 4, 6, 3, -1, 5 }) };
        }
    }
}
