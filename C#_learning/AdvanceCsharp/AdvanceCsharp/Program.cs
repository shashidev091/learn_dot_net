using AdvanceCsharp;


GenericClass<int> genericClass = new GenericClass<int>();
genericClass.Add(1);
genericClass.Add(3);

Console.WriteLine(genericClass[1]);

Product p = new Product
{
    number = 10,
    price = 200.2
};

Console.WriteLine("Price: {0}, Number: {1}", p.price, p.number);

Deligates deligates = new Deligates();
PhotoFilters filters = new PhotoFilters();

Action<Photo> filterHandler = filters.ApplyBrightness;
filterHandler += filters.ApplyConstrast;
deligates.Process(@"c:/photo.jpeg", filterHandler);

Product product = new Product();
Product.MyDelegate myDelegate = (a, b) => a * b;
Console.WriteLine(myDelegate(2, 5));


Func<int, int> square = number => number * number;

Func<int, int, int> multiply = (num1, num2) => num1 * num2 + p.number;
Console.WriteLine(square(5));
Console.WriteLine(multiply(14, 55));

var video = new Video() { Title = "Title 1" };
var videoEncoder = new VideoEncoder();  // Publisher
var mailService = new MailService(); // Subscriber

videoEncoder.VideoEncoded += mailService.OnVideoEncoded;

videoEncoder.Encode(video);

