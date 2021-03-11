using System;
using System.Collections.Generic;

namespace FinalErgasia3.Classes
{
    class ArraySort : IComparer<int>
    {
        string[,] _sortArray;
        int[] _tagArray;
        int _sortIndex;

        protected string[,] SortArray { get { return _sortArray; } }

        public ArraySort(string[,] theArray, int sortIndex)
        {
            _sortArray = theArray;
            _tagArray = new int[_sortArray.GetLength(0)];
            for (int i = 0; i < _sortArray.GetLength(0); ++i) _tagArray[i] = i;
            _sortIndex = sortIndex;
        }

        public string[,] ToSortedArray()
        {
            Array.Sort(_tagArray, this);
            string[,] result = new string[
                _sortArray.GetLength(0), _sortArray.GetLength(1)];
            for (int i = 0; i < _sortArray.GetLength(0); i++)
            {
                for (int j = 0; j < _sortArray.GetLength(1); j++)
                {
                    result[i, j] = _sortArray[_tagArray[i], j];
                }
            }
            return result;
        }

        public virtual int Compare(int x, int y)
        {
            if (_sortIndex < 0) return 0;
            return CompareStrings(x, y, _sortIndex);
        }

        protected int CompareStrings(int x, int y, int col)
        {
            return _sortArray[y, col].CompareTo(_sortArray[x, col]);
        }
    }
}
