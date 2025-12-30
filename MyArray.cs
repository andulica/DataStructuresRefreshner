using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresRefresher
{
    public class MyArray
    {
        private static int _length;
        private static int[] _data;

        public int GetLength () { return _length; }
        public MyArray(int length) { 
            _length = length;
            _data = new int[length];
        }

        public int Get(int index)
        {
            return _data[index];
        }

        public int Push(int item)
        {
            if (_data.Length == _length)
            {
                int[] newData = new int[_length * 2];

                for (int i = 0;i < _data.Length; i++)
                {
                    newData[i] = _data[i];
                }
                _data = newData;
            }

            _data[_length] = item;
            _length ++;
            return _length;
        }

        public int Pop()
        {
            int itemToDelete = _data[_length - 1];
            _data[_length - 1] = 0;

            return itemToDelete;
        }

        public int Delete(int index)
        {
            int itemToDelete = _data[index];
            shitItems(index);

            return itemToDelete;
        }

        private static void shitItems(int index)
        {
            for (int i = index; i < _length; i++)
            {
                _data[i] = i++;
            }
            _data[_length - 1] = 0;
            _length --;
        }
    }
}
