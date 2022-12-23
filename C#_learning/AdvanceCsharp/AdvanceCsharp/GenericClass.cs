using System;
namespace AdvanceCsharp
{
	public class GenericClass<T>
	{
		private List<T> Items = new List<T>();
		public void Add(T value)
		{
			this.Items.Add(value);
		}

		public T this[int index]
		{
			get { return this.Items[index]; }
		}
	}

	public class Book
	{

	}
}

