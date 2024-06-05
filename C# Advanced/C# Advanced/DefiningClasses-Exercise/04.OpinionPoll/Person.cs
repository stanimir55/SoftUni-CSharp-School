using System;
namespace DefiningClasses
{
	public class Person
	{
		private string name;
		int age;

		public string Name { get; set; }

		public int Age { get; set; }

		public Person()
		{
			name = "No name";
			age = 1;
		}

        public Person(int age)
        {
            
            Age = age;
			name = "No name";
        }

        public Person(string name, int age) : this(age)
        {

			Name = name;
        }
    }
}

