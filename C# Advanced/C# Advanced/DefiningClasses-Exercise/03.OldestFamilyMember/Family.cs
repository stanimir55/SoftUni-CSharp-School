using System;
namespace DefiningClasses
{
	public class Family
	{
		public Family()
		{
			People = new List<Person>();
		}

		public List<Person> People { get; set; }

		public void AddMember(Person person)
		{
			People.Add(person);
		}

		public Person GetOldestMember()
		{
			return this.People.OrderByDescending(x => x.Age).FirstOrDefault();
		}
	}
}

