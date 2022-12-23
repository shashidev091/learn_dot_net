using System;
namespace IntermediateCSharp
{

    public class Text : Inheritance
    {
        public int FontSize { set; get; }
        public string FontName { set
            {
                if (value == null)
                    this.FontName = "";
                else
                    this.FontName = value;
            }
            get
            {
                return this.FontName;
            }
        }

        public Text(int width): base(width)
        {

        }

        public void AddHyperLink(string url)
        {
            Console.WriteLine("We added a link to {0}", url);
        }
    }

    public class Point
    {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Move(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Move(Point newLoaction)
        {
            if (newLoaction == null)
                throw new ArgumentNullException("NewLocation");

            this.Move(newLoaction.x, newLoaction.y);
        }
    }

    public class Person
    {
        public string Name = "";

        public Person()
        {

        }
        public Person(string name)
        {
            this.Name = name;
        }
        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, this.Name);
        }

        public static Person Parse(String str)
        {
            Person person = new Person();
            person.Name = str;
            return person;
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("This is fun");

            //Person person = new Person();
            //person.Name = "Shashi";
            //person.Introduce("Jhon");

            //Person p = Person.Parse("Savita");
            //p.Introduce("Jhon");

            

            try
            {
                Point point = new Point(10, 20);
                point.Move(new Point(40, 60));

                Console.WriteLine("Point is ({0}, {1})", point.x, point.y);
                point.Move(22, 44);
                Console.WriteLine("Point is ({0}, {1})", point.x, point.y);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2, 3, 4, 5));

            Customer customer = new Customer(1, "Shashi");
            customer.orders.Add(new Order(22));
            customer.orders.Add(new Order(334));
            customer.orders.Add(new Order(343));
            customer.orders.Add(new Order(52));

            Console.WriteLine(customer.orders.Count);
            foreach(Order order in customer.orders)
            {
                Console.WriteLine(order.SomeData);
            }

            Practice practice = new Practice();
            practice.SetDob(new DateTime(1964, 10, 11));
            practice.SetName("Papa");
            Console.WriteLine(practice.Age);

            Console.WriteLine();

            Indexers indexers = new Indexers();
            indexers["name"] = "Shashi Bhushan";
            Console.WriteLine(indexers["name"]);

            Text text = new Text(100);
            text.Width = 100;
            text.Height = 200;

            text.Copy();

            Migrator migrator = new Migrator(new Composition());
            migrator.Migrate();
            migrator._composition.Log("This is awsome");

        }
    }
}