using System;
namespace HackerRank_Playground.Inheritane
{
    public class Person
    {
		protected string firstName;
		protected string lastName;
		protected int id;

		public Person() { }
		public Person(string firstName, string lastName, int identification)
		{
            this.firstName = firstName;
			this.lastName = lastName;
			id = identification;
		}
		public void printPerson()
		{
			Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
		}
	}
}
