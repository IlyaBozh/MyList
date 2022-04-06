namespace MyArrayList
{
    public class MyArrayList : ICollection
    {
        public int Length { get; private set; }
        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= Length)
                {
                    throw new IndexOutOfRangeException();
                }

                return _array[index];
            }

            set
            {
                if (index < 0 || index >= Length)
                {
                    throw new IndexOutOfRangeException();
                }

                _array[index] = value;
            }
        }

        private int[] _array;

        public MyArrayList()
        {
            _array = new int[10];
            Length = 0;
        }

        public MyArrayList(int value)
        {
            _array = new int[10];
            _array[0] = value;
            Length = 1;
        }

        public MyArrayList(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                _array = new int[10];
                Length = 0;
            }
            else
            {
                _array = array;
                UpSize();
                Length = array.Length;
            }
        }

        public void Add(int value)
        {
            if (Length >= _array.Length)
            {
                UpSize();
            }
            _array[Length] = value;
            Length++;
        }

        public void AddFirst(int value)
        {
            if (Length >= _array.Length)
            {
                UpSize();
            }

            ShiftRight();

            _array[0] = value;
            Length++;
        }

        public void AddByIndex(int index, int value)
        {
            if (index < 0 || index >= Length)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (Length >= _array.Length)
            {
                UpSize();
            }

            ShiftRight(index);

            _array[index] = value;
            Length++;
        }

        public void DeleteLast()
        {
            if (Length < 1)
            {
                throw new Exception("Empty list");
            }

            if (Length <= _array.Length / 2)
            {
                DownSize();
            }

            Length--;
        }

        public void DeleteFirst()
        {
            if (Length < 1)
            {
                throw new Exception("Empty list");
            }

            ShiftLeft();

            Length--;
        }

        public void DeleteByIndex(int index)
        {
            if (index < 0 || index >= Length)
            {
                throw new ArgumentOutOfRangeException();
            }

            ShiftLeft(index);

            Length--;
        }

        public void DeleteElementsFromEnd(int countElement)
        {
            if (countElement < 1)
            {
                throw new ArgumentException("Count shoule be positiv and greater than 0");
            }

            if (countElement >= Length)
            {
                Length = 0;
            }
            else
            {
                Length -= countElement;
            }

            if (Length <= _array.Length / 2)
            {
                DownSize();
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
                Length = 0;
            }
            else
            {
                for (int i = 0; i < Length - countElement; i++)
                {
                    _array[i] = _array[i + countElement];
                }

                Length -= countElement;
            }

            if (Length <= _array.Length / 2)
            {
                DownSize();
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

            if (countElement > Length - index)
            {
                Length = index;
            }
            else
            {
                for (int i = index; i < Length - countElement; i++)
                {
                    _array[i] = _array[i + countElement];
                }

                Length -= countElement;
            }

            if (Length <= _array.Length / 2)
            {
                DownSize();
            }
        }

        public int FindIndexByValue(int value)
        {
            int index = -1;
            for (int i = 0; i < Length; i++)
            {
                if (value == _array[i])
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

        public void Reverse()
        {
            int tmp;

            for (int i = 0; i < Length / 2; i++)
            {
                tmp = _array[i];
                _array[i] = _array[Length - i - 1];
                _array[Length - i - 1] = tmp;
            }
        }

        public int FindMax()
        {
            if (Length == 0)
            {
                throw new Exception("Empty list");
            }

            int maxElement = _array[0];

            for (int i = 0; i < Length; i++)
            {
                if (maxElement < _array[i])
                {
                    maxElement = _array[i];
                }
            }

            return maxElement;
        }

        public int FindMin()
        {
            if (Length == 0)
            {
                throw new Exception("Empty list");
            }

            int minElement = _array[0];

            for (int i = 0; i < Length; i++)
            {
                if (minElement > _array[i])
                {
                    minElement = _array[i];
                }
            }

            return minElement;
        }

        public int FindIndexOfMax()
        {
            if (Length == 0)
            {
                throw new Exception("Empty list");
            }

            int indexOfMaxElement = 0;

            for (int i = 1; i < Length; i++)
            {
                if (_array[indexOfMaxElement] < _array[i])
                {
                    indexOfMaxElement = i;
                }
            }

            return indexOfMaxElement;
        }

        public int FindIndexOfMin()
        {
            if (Length == 0)
            {
                throw new Exception("Empty list");
            }

            int indexOfMinElement = 0;

            for (int i = 1; i < Length; i++)
            {
                if (_array[indexOfMinElement] > _array[i])
                {
                    indexOfMinElement = i;
                }
            }

            return indexOfMinElement;
        }

        public void SortAscending()
        {
            int tmp;
            int indexOfMinElement;

            for (int i = 0; i < Length; i++)
            {
                indexOfMinElement = i;

                for (int j = i; j < Length; j++)
                {
                    if (_array[j] < _array[indexOfMinElement])
                    {
                        indexOfMinElement = j;
                    }
                }

                tmp = _array[i];
                _array[i] = _array[indexOfMinElement];
                _array[indexOfMinElement] = tmp;
            }
        }

        public void SortDescending()
        {
            int tmp;
            int j;

            for (int i = 0; i < Length; i++)
            {
                tmp = _array[i];
                j = i;

                while (j > 0 && _array[j - 1] < tmp)
                {
                    tmp = _array[j];
                    _array[j] = _array[j - 1];
                    _array[j - 1] = tmp;
                    j--;
                }

                _array[j] = tmp;
            }
        }

        public int DeleteFirstByValue(int value)
        {
            int indexOfElement = FindIndexByValue(value);

            if (indexOfElement != -1)
            {
                ShiftLeft(indexOfElement);
                Length--;
            }

            return indexOfElement;
        }

        public int DeleteAllByValue(int value)
        {
            int countOfElements = 0;

            for (int i = 0; i < Length; i++)
            {
                if (_array[i] == value)
                {
                    countOfElements++;
                }
                else
                {
                    _array[i - countOfElements] = _array[i];
                }
            }

            Length -= countOfElements;
            return countOfElements;
        }

        public void AddList(ICollection list)
        {
            if (list == null || list is not MyArrayList)
            {
                throw new ArgumentNullException();
            }

            MyArrayList arrayList = (MyArrayList)list;

            for (int i = 0; i < arrayList.Length; i++)
            {
                Add(arrayList[i]);
            }
        }

        public void AddListToBegin(ICollection list)
        {
            if (list == null || list is not MyArrayList)
            {
                throw new ArgumentNullException();
            }

            MyArrayList arrayList = (MyArrayList)list;

            int[] newArray = new int[this.Length + arrayList.Length];

            for (int i = 0; i < arrayList.Length; i++)
            {
                newArray[i] = arrayList[i];
            }

            for (int i = arrayList.Length; i < newArray.Length; i++)
            {
                newArray[i] = _array[i - arrayList.Length];
            }

            Length = newArray.Length;
            _array = newArray;
            UpSize();
        }

        public void AddListByIndex(ICollection list, int index)
        {
            if (list == null || list is not MyArrayList)
            {
                throw new ArgumentNullException();
            }
            MyArrayList arrayList = (MyArrayList)list;

            int newLegth = this.Length + arrayList.Length;

            if (index < 0 || index >= newLegth)
            {
                throw new IndexOutOfRangeException();
            }

            int[] newArray = new int[newLegth];

            for (int i = 0; i < index; i++)
            {
                newArray[i] = _array[i];
            }

            for (int i = index; i < index + arrayList.Length; i++)
            {
                newArray[i] = arrayList[i - index];
            }

            for (int i = index + arrayList.Length; i < newArray.Length; i++)
            {
                newArray[i] = _array[i - arrayList.Length];
            }

            Length = newArray.Length;
            _array = newArray;
            UpSize();
        }

        public void Write()
        {
            for (int i = 0; i < Length; i++)
            {
                Console.Write($"{_array[i]} ");
            }
            Console.WriteLine();
        }

        public override string ToString()
        {
            string strArray = "";

            for (int i = 0; i < Length; i++)
            {
                strArray += $"{_array[i]} ";
            }

            return strArray;
        }

        public override bool Equals(object? obj)
        {
            bool isEqual = true;

            if (obj == null || !(obj is MyArrayList))
            {
                isEqual = false;
            }
            else
            {
                MyArrayList list = (MyArrayList)obj;

                if (list.Length != this.Length)
                {
                    isEqual = false;
                }
                else
                {
                    for (int i = 0; i < this.Length; i++)
                    {
                        if (list[i] != this[i])
                        {
                            isEqual = false;
                            break;
                        }
                    }
                }
            }
            return isEqual;
        }

        private void ShiftRight(int index = 0)
        {
            for (int i = Length; i > index; i--)
            {
                _array[i] = _array[i - 1];
            }
        }

        private void ShiftLeft(int index = 0)
        {
            if (Length <= _array.Length / 2)
            {
                DownSize();
            }

            for (int i = index; i < Length; i++)
            {
                _array[i] = _array[i + 1];
            }
        }

        private void UpSize()
        {
            int newLength = (int)(_array.Length * 1.5d + 1);
            int[] newArray = new int[newLength];

            for (int i = 0; i < _array.Length; i++)
            {
                newArray[i] = _array[i];
            }

            _array = newArray;
        }

        private void DownSize()
        {
            int newLength = _array.Length - _array.Length / 3;
            int[] newArray = new int[newLength];

            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = _array[i];
            }

            _array = newArray;
        }

    }
}