using System;
namespace AdvanceCsharp
{
	public class VideoEncoder
	{ 
		// Define a Delegate
		// Define an event based on that delegate
		// Raise the event
		public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);

		public event EventHandler<VideoEventArgs> VideoEncoded;

		//public event VideoEncodedEventHandler VideoEncoded;


		public void Encode(Video video)
		{
			Console.WriteLine("Encoding Video...");
			Thread.Sleep(3000);

			OnVideoEncoded(video);
		}

		protected virtual void OnVideoEncoded(Video video)
		{
			if (VideoEncoded != null)
			{
				VideoEncoded(this, new VideoEventArgs() { Video = video });
			}
		}
	}
}

