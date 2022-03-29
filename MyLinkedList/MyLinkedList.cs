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
            else if (index == 0)
            {
                AddFirst(value);
            }
            else
            {
                Node crnt1 = _head;
                Node crnt2;
                Node newNode = new Node(value);

                for (int i = 1; i < index; i++)
                {
                    crnt1 = crnt1.Next;
                }

                crnt2 = crnt1.Next;
                crnt1.Next = newNode;
                newNode.Next = crnt2;
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
                Node crnt = _head;

                for (int i = 1; i < Length - 1; i++)
                {
                    crnt = crnt.Next;
                }

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
                Node crnt1 = _head;
                Node crnt2;

                for (int i = 1; i < index; i++)
                {
                    crnt1 = crnt1.Next;
                }

                crnt2 = crnt1.Next;
                crnt1.Next = crnt2.Next;
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
                Node crnt = _head;
                int tmp = Length - countElement;

                for (int i = 1; i < tmp; i++)
                {
                    crnt = crnt.Next;
                }

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
                Node crnt = _head;

                for (int i = 1; i <= countElement; i++)
                {
                    crnt = crnt.Next;
                }

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

            Node crnt1 = _head;
            Node crnt2;

            if (index == 0)
            {
                DeleteElementsFromBegin(countElement);
            }

            if (countElement >= Length - index - 1)
            {

                for (int i = 1; i < index; i++)
                {
                    crnt1 = crnt1.Next;
                }

                crnt1.Next = null;
                _tail = crnt1;
            }

            else
            {
                for (int i = 1; i < index; i++)
                {
                    crnt1 = crnt1.Next;
                }

                crnt2 = crnt1;

                for (int i = 1; i <= countElement; i++)
                {
                    crnt1 = crnt1.Next;
                }

                crnt2.Next = crnt1.Next;
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


    }
}
