using System;
namespace AdvanceCsharp
{
	public class Photo
	{
		public static Photo Load(string path)
		{
			return new Photo();
		}

		public void Save()
		{

		}
	}

	//public class Deligates
	//{
	//	public delegate void PhotoFilterHandler(Photo photo);

	//	public void Process(string path, PhotoFilterHandler filterHandler)
	//	{
	//		var photo = Photo.Load(path);

	//		filterHandler(photo);

	//		photo.Save();
	//	}

	//}

    public class Deligates
    {
        public delegate void PhotoFilterHandler(Photo photo);

        public void Process(string path, Action<Photo> filterHandler)
        {
            var photo = Photo.Load(path);

            filterHandler(photo);

            photo.Save();
        }

    }

    public class PhotoFilters
	{
		public void ApplyBrightness(Photo photo)
		{
			Console.WriteLine("Brightness Applied :D");
		}

		public void ApplyConstrast(Photo photo)
		{
			Console.WriteLine("Contrast Applied :<3");
		}
	}
}

