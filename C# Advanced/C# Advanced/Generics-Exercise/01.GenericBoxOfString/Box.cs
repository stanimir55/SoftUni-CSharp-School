using System;
namespace _01.GenericBoxOfString
{
	public class Box<T>
	{
		public Box(T input)
		{
            Input = input;
		}

        public T Input { get; set; }

        public override string ToString()
        {
            return $"{Input.GetType()}: {Input}";
        }
    }
}

