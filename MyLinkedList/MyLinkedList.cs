using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList
{
    public class MyLinkedList
    {
        public int Length
        {
            get
            {
                int countElements = 0;
                Node crnt = _head;

                while(crnt != null)
                {
                    countElements++;
                    crnt = crnt.Next;
                }

                return countElements;
            }
            private set
            {
            }
        }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= Length)
                {
                    throw new ArgumentOutOfRangeException("index");
                }

                Node crnt = _head;

                for (int i = 1; i <= index; i++)
                {
                    crnt = crnt.Next;
                }

                return crnt.Value;
            }

            set
            {
                if (index < 0 || index >= Length)
                {
                    throw new ArgumentOutOfRangeException();
                }

                Node crnt = _head;

                for (int i = 1; i <= index; i++)
                {
                    crnt = crnt.Next;
                }

                crnt.Value = value;
            }
        }

        private Node _head;

        private Node _tail;

        public MyLinkedList()
        {
            _head = null;
            _tail = null;
        }

        public MyLinkedList(int value)
        {
            _head = new Node(value);
            _tail = _head;
        }

        public MyLinkedList (int[] array)
        {
            if (array.Length == 0)
            {
                Length = 0;
                _head = null;
                _tail = null;
            }
            else
            {
                _head = new Node(array[0]);
                _tail = _head;

                for (int i = 1; i < array.Length; i++)
                {
                    _tail.Next = new Node(array[i]);
                    _tail = _tail.Next;
                }
            }
        }

        public void AddLast(int value)
        {
            if (_head == null)
            {
                _head = new Node(value);
                _tail = _head;
            }
            else
            {
                _tail.Next = new Node(value);
                _tail = _tail.Next;
            }
        }

        public void AddFirst(int value)
        {
            if (_head == null)
            {
                _head = new Node(value);
                _tail = _head;
            }
            else
            {
                Node crnt = new Node(value);
                crnt.Next = _head;
                _head = crnt;
            }
        }

        public void AddByIndex(int index, int value)
        {
            if (index < 0 || index >= Length)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (_head == null)
            {
                _head = new Node(value);
                _tail = _head;
            }
            else
            {
                if (index == 0)
                {
                    AddFirst(value);
                }
                else
                {
                    Node crnt = GetNode(index - 1);
                    Node newElement = new Node(value);

                    newElement.Next = crnt.Next;
                    crnt.Next = newElement;
                    _tail = GetTail();
                }
            }

        }

        public void DeleteLast()
        {
            if (_head is null)
            {
                throw new Exception("Empty list");
            }

            if (Length == 1)
            {
                _head = null;
                _tail = null;
            }
            else
            {
                Node crnt = GetNode(Length - 2);

                _tail = crnt;
                _tail.Next = null;
            }
        }

        public void DeleteFirst()
        {
            if (_head is null)
            {
                throw new Exception("Empty list");
            }

            _head = _head.Next;
        }

        public void DeleteByIndex(int index)
        {
            if (index < 0 || index >= Length)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (Length == 1)
            {
                _tail = null;
                _head = null;
            }

            else
            {
                Node crnt1 = GetNode(index - 1);
                Node crnt2 = crnt1.Next;
                crnt1.Next = crnt2.Next;
                _tail = GetTail();
            }
        }

        public void DeleteElementsFromEnd(int countElement)
        {
            if (countElement < 1)
            {
                throw new ArgumentException("Count shoule be positiv and greater than 0");
            }

            if (countElement >= Length)
            {
                _head = null;
                _tail = null;
            }
            else
            { 
                Node crnt = GetNode(Length - countElement - 1);
                crnt.Next = null;
                _tail = crnt;
            }
        }

        public void DeleteElementsFromBegin(int countElement)
        {
            if (countElement < 1)
            {
                throw new ArgumentException("Count shoule be positiv and greater than 0");
            }

            if (countElement >= Length)
            {
                _head = null;
                _tail = null;
            }
            else
            {
                Node crnt = GetNode(countElement);
                _head = crnt;
            }
        }

        public void DeleteElementsByIndex(int index, int countElement)
        {
            if (countElement < 1)
            {
                throw new ArgumentException("Count shoule be positiv and greater than 0");
            }

            if (index < 0 || index >= Length)
            {
                throw new IndexOutOfRangeException();
            }

            if (index == 0)
            {
                DeleteElementsFromBegin(countElement);
            }
            else if (Length - index <= countElement)
            {
                Node crnt = GetNode(index - 1);
                crnt.Next = null;
            }
            else
            {
                Node crntLeft = GetNode(index - 1);
                Node crntRight = GetNode(index + countElement);
                crntLeft.Next = crntRight;
            }

            _tail = GetTail();
        }

        public int FindIndexFirstElementByValue(int value)
        {
            Node crnt = _head;
            int index = -1;
            int i = 0;

            while (crnt != null)
            {
                if (crnt.Value == value)
                {
                    index = i;
                    break;
                }
                crnt = crnt.Next;
                i++;
            }

            return index;
        }

        public void Reverse()
        {
            Node crnt = _head;
            Node next;
            Node prev = null;

            while(crnt != null)
            {
                next = crnt.Next;
                crnt.Next = prev;
                prev = crnt;
                crnt = next;
            }
            _tail = _head;
            _head = prev;
        }

        public int FindMax()
        {
            if (Length == 0)
            {
                throw new Exception("Empty list");
            }

            int maxElement = this[0];
            Node crnt = _head;

            while (crnt != null)
            {
                if (crnt.Value > maxElement)
                {
                    maxElement = crnt.Value;
                }
                crnt = crnt.Next;
            }

            return maxElement;
        }

        public int FindMin()
        {
            if (Length == 0)
            {
                throw new Exception("Empty list");
            }

            int minElement = this[0];
            Node crnt = _head;

            while (crnt != null)
            {
                if (crnt.Value < minElement)
                {
                    minElement = crnt.Value;
                }
                crnt = crnt.Next;
            }

            return minElement;
        }

        public int FindIndexOfMaxElement()
        {
            if (Length == 0)
            {
                throw new Exception("Empty list");
            }

            int indexOfMaxElement = 0;
            int maxElement = _head.Value;
            Node crnt = _head;

            for (int i = 0; i < Length; i++)
            {
                if (maxElement < crnt.Value)
                {
                    indexOfMaxElement = i;
                    maxElement = crnt.Value;
                }
                crnt = crnt.Next;
            }

            return indexOfMaxElement;
        }

        public int FindIndexOfMinElement()
        {
            if (Length == 0)
            {
                throw new Exception("Empty list");
            }

            int indexOfMinElement = 0;
            int minElement = _head.Value;
            Node crnt = _head;

            for (int i = 0; i < Length; i++)
            {
                if (minElement > crnt.Value)
                {
                    indexOfMinElement = i;
                    minElement = crnt.Value;
                }
                crnt = crnt.Next;
            }

            return indexOfMinElement;
        }

        /*public void SortAscending()
        {
            int[] array = new int[Length];
            Node crnt = _head;

            for (int i = 0; i < Length; i++)
            {
                array[i] = crnt.Value;
                crnt = crnt.Next;
            }


        }*/

        /*public void SortDescending()
        {

        }*/

        public int DeleteFirstElementByValue(int value)
        {
            int indexOfElement = FindIndexFirstElementByValue(value);

            if (indexOfElement != -1)
            {
                DeleteByIndex(indexOfElement);
            }

            return indexOfElement;
        }

        public int DeleteAllElementByValue(int value)
        {
            if (Length == 0)
            {
                throw new Exception("Empty list");
            }
            int countOfElements = 0;
            Node crnt = _head;
            Node prev = null;
            int index = 0;

            while (crnt != null)
            {
                if (crnt.Value == value)
                {
                    if (index == 0)
                    {
                        _head = _head.Next;
                        countOfElements++;
                        index--;
                    }
                    else
                    {
                        prev.Next = crnt.Next;
                        countOfElements++;
                        index--;
                    }
                }

                prev = crnt;
                crnt = crnt.Next;
                index++;
            }

            _tail = GetTail();
            return countOfElements;
        }

        public void AddListToEnd(MyLinkedList list)
        {
            if (_head == null)
            {
                this._head = list._head;
            }
            else
            {
                this._tail.Next = list._head;
                this._tail = GetTail();
            }
        }

        public void AddListToBegin(MyLinkedList list)
        {
            if (list._head != null)
            {
                list._tail.Next = this._head;
                this._head = list._head;
            }
        }

        public void AddListByIndex(MyLinkedList list, int index)
        {
            if (index < 0 || index > Length)
            {
                throw new IndexOutOfRangeException();
            }

            if (list._head != null)
            {
                if (index == 0)
                {
                    AddListToBegin(list);
                }
                else
                {
                    Node crnt = _head;

                    for (int i = 1; i < index; i++)
                    {
                        crnt = crnt.Next;
                    }

                    list._tail.Next = crnt.Next;
                    crnt.Next = list._head;
                    _tail = GetTail();
                }
            }
        }

        public override string ToString()
        {
            string strList = "";
            Node crnt = _head;

            while (crnt != null)
            {
                strList += $"{crnt.Value} ";
                crnt = crnt.Next;
            }

            return strList;
        }

        public override bool Equals(object? obj)
        {
            bool isEqual = true;

            if (obj == null || !(obj is MyLinkedList))
            {
                isEqual = false;
            }
            else
            {
                MyLinkedList list = (MyLinkedList)obj;

                if (list.Length != this.Length)
                {
                    isEqual = false;
                }
                else
                {
                    Node crnt1 = this._head;
                    Node crnt2 = list._head;

                    while (crnt1 != null)
                    {
                        if (crnt1.Value != crnt2.Value)
                        {
                            isEqual = false;
                            break;
                        }

                        crnt1 = crnt1.Next;
                        crnt2 = crnt2.Next;
                    }
                }
            }
            return isEqual;
        }

        private Node GetTail()
        {
            Node crnt = _head;

            for(int i = 1; i < Length; i++)
            {
                crnt = crnt.Next;
            }

            return crnt;
        }

        private Node GetNode(int index)
        {
            Node crnt = _head;

            for(int i = 1; i <= index; i++)
            {
                crnt = crnt.Next;
            }

            return crnt;
        }

      /*  private void MergeSort (int[] array, int left, int rigth)
        {
            if (left == rigth)
            {
                return;
            }

            int midell = array.Length / 2;

            MergeSort(array, left, midell);
            MergeSort(array, midell + 1, rigth);

            
        }*/
    }
}
