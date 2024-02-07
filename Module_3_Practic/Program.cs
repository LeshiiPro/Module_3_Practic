using System;

namespace Module_3_Practic
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string name = "Alex";
			byte age = 34;
			bool pet = true;
			double size = 37.5;

			Console.WriteLine("What is your name?");
			Console.WriteLine("My name is {0}", name);

			Console.WriteLine("How old are you?");
			Console.WriteLine("My age is {0}", age);

			Console.WriteLine("Do you have a pet?");
			Console.WriteLine(pet);

			Console.WriteLine("What is your shoe size?");
			Console.WriteLine("My shoe size is {0}", size);

			Console.ReadKey();
		}
	}
}
