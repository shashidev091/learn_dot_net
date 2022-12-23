using System;
namespace IntermediateCSharp
{
	public class Inheritance
	{
		public int Width { set; get; }
		public int Height { set; get; }

		public Inheritance(int width)
		{
			this.Width = width;
		}

		public void Copy()
		{
			Console.WriteLine("Object copied to clipboard.");
		}


		public void Duplicate()
		{
			Console.WriteLine("Object was duplicated.");
		}

	}

	public class Inherit : Inheritance
	{
		public Inherit(int width) : base(width) // Initialize super class constructor
		{
		}
	}

	public class Composition
	{
		public void Log(string message)
		{
			Console.WriteLine(message);
		}
	}

	public class Migrator
	{
		public readonly Composition _composition;

		public Migrator(Composition composition)
		{
			this._composition = composition;
		}

		public void Migrate()
		{
			_composition.Log("We are migrating blaa blahh");
		}
	}
}

