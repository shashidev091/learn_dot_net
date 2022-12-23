
namespace IntermediateCsharp_part2
{
    public class Shapes
    {
        public int X { get; set; }
        public int Y { get; set; }

        override
        public string ToString()
        {
            return string.Format("X = {0}, Y = {1}", this.X, this.Y);
        }
    }

    public class Text : Shapes
    {
        public int Height { get; set; }
        public int Width { get; set; }


        public override string ToString()
        {
            return string.Format("X = {0}, Y = {1}, Height = {2}, Width = {3}", this.X, this.Y, this.Height, this.Width);
        }
    }

    public class Program
    {
        public static void Main(String[] args)
        {
            Shapes shape = new Text();
            shape.X = 200;
            shape.Y = 300;
            Console.WriteLine(shape.ToString());

            Text text = (Text)shape;
            text.Height = 199;
            text.Width = 222;
            text.X = 188;

            Console.WriteLine(text.ToString());
            Console.WriteLine(shape.ToString());

            int[] numbers = { 1, 44, 5, 6, 43 };
            var max = numbers[0];
            var min = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (max < numbers[i])
                    max = numbers[i];
                else if (numbers[i] < min)
                    min = numbers[i];
            }

            Console.WriteLine("max is : {0}, min number in the array is : {1}", max, min);

            var shapeList = new List<Shape>();
            shapeList.Add(new Circle());
            shapeList.Add(new Rectangle());
            shapeList.Add(new Triangle());

            var canvas = new Canvas();
            canvas.DrawShapes(shapeList);
        }
    }
}