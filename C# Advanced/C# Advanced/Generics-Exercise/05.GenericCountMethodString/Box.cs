using System;
using System.Collections;

namespace _05.GenericCountMethodString
{
	public class Box<T> where T : IComparable
	{
        public Box()
        {
            Items = new List<T>();
        }

        public List<T> Items { get; set; }

        public void Swap(int firstIndex, int secondIndex)
        {
            (Items[secondIndex], Items[firstIndex]) =
                (Items[firstIndex], Items[secondIndex]);
        }

        public int CountOfLargerElements(T value)
            => Items.Count(item => item.CompareTo(value) > 0);
    }
}

