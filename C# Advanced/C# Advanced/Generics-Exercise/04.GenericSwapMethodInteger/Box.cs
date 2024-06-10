using System;
using System.Collections;

namespace _04.GenericSwapMethodInteger
{
	public class Box<T>
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
        
        public override string ToString()
        {
            return string.Join(Environment.NewLine,
                Items.Select(item => $"{typeof(T)}: {item}"));
        }

    }
}

