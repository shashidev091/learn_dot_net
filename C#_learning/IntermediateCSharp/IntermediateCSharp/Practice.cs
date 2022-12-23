using System;
namespace IntermediateCSharp
{
	public class Practice
	{

		private string _name;
		private DateTime _dob;
		public int Age
		{
			get
			{
				TimeSpan timeSpan = DateTime.Today - this._dob;
				int years = timeSpan.Days / 365;
				return years;
			}
		}

		public void SetName(string name)
		{
			this._name = name;
		}

		public string GetName()
		{
			return this._name;
		}

		public DateTime GetDob()
		{
			return this._dob;
		}

		public void SetDob(DateTime dob)
		{
			this._dob = dob;
		}

	}

	public class Animal
	{
		private string _name;
		private string _species;
		public int Legs { get; set; }
        public string color { get; set; }


        public string Name
		{
			get { return this._name; }
			set { this._name = value; }
		}
	}
}

