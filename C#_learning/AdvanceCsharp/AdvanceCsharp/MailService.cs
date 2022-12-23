using System;
namespace AdvanceCsharp
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("MailService: Sending an email...");
            Console.WriteLine(e.Video.Title);
        }
    }
}

