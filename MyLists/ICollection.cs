using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyArrayList
{
    public interface ICollection
    {
        public void Add(int value);
        public void AddFirst(int value);
        public void AddByIndex(int index, int value);
        public void DeleteLast();
        public void DeleteFirst();
        public void DeleteByIndex(int index);
        public void DeleteElementsFromEnd(int countElement);
        public void DeleteElementsFromBegin(int countElement);
        public void DeleteElementsByIndex(int index, int countElement);
        public int FindIndexByValue(int value);
        public void Reverse();
        public int FindMax();
        public int FindMin();
        public int FindIndexOfMax();
        public int FindIndexOfMin();
        public void SortAscending();
        public void SortDescending();
        public int DeleteFirstByValue(int value);
        public int DeleteAllByValue(int value);
        public void AddList(ICollection list);
        public void AddListToBegin(ICollection list);
        public void AddListByIndex(ICollection list, int index);

    }
}
