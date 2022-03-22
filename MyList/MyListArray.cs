namespace MyList
{
    public class MyListArray
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

        public MyListArray()
        {
            _array = new int[10];
            Length = 0;
        }

        public MyListArray(int value)
        {
            _array = new int[10];
            _array[0] = value;
            Length = 1;
        }

        public MyListArray(int[] values)
        {
            _array = new int[(int) (values.Length * 1.5d + 1)];

            for (int i = 0; i < values.Length; i++)
            {
                AddLast(values[i]);
            }
        }

        public void AddLast(int value)
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
            if(Length <= _array.Length / 2)
            {
                DownSize();
            }

            Length--;
        }

        public void DeleteFirst()
        {
            ShiftLeft();

            Length--;
        }

        public void DeleteByIndex(int index)
        {
            ShiftLeft(index);

            Length--;
        }

        public int FindFirstElementByValue (int value)
        {

            for (int i = 0; i < Length; i++)
            {
                if (value == _array[i])
                {
                    return i;
                }
            }

            return -1;
        }

        public void Reverse()
        {
            int tmp;

            for (int i = 0; i < Length / 2; i ++)
            {
                tmp = _array[i];
                _array[i] = _array[Length - i - 1];
                _array[Length - i - 1] = tmp;
            }
        }

        public int FindMaxElement()
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

        public int FindMinElement()
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

        public int FindIndexOfMaxElement()
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

        public int FindIndexOfMinElement()
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

        public int DeleteFirstElementByValue(int value)
        {
            int indexOfElement = FindFirstElementByValue(value);

            if (indexOfElement != -1)
            {
                ShiftLeft(indexOfElement);
                Length--;
            }

            return indexOfElement;
        }

        public int DeleteAllElementByValue(int value)
        {
            int indexOfElement;
            int CountOfElements = 0;
            for (int i = 0; i < Length; i++)
            {
                indexOfElement = FindFirstElementByValue(value);

                if (indexOfElement != -1)
                {
                    ShiftLeft(indexOfElement);
                    Length--;
                    CountOfElements++;
                }
            }

            return CountOfElements;
        }

        public void AddListToEnd(MyListArray list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                AddLast(list[i]);
            }
        }

        public void AddListToBegin(MyListArray list)
        {
            for (int i = list.Length - 1; i >= 0; i--)
            {
                AddFirst(list[i]);
            }
        }

        public void AddListByIndex(MyListArray list, int index)
        {
            for (int i = 0; i < list.Length; i++)
            {
                AddByIndex(index, list[i]);
                index++;
            }
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

        public void Write()
        {
            for (int i = 0; i < Length; i++)
            {
                Console.Write($"{_array[i]} ");
            }
            Console.WriteLine();
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