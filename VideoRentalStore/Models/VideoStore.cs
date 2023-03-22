namespace VideoRentalStore.Models
{
    public class VideoStore : Video
    {

        static int i = 0;

        Video[] Videos = new Video[10];
        VideoRent VideoRent=new VideoRent();

        public void addVideo(string title)
        {
            for (int i = 0; i < Videos.Length; i++)
            {
                if (Videos[i] == null)
                {
                    Videos[i] = new Video { Title = title };
                    break;
                }
            }
        }
        public void CheckOut(string title)
        {
            foreach (Video video in Videos)
            {
                if (video != null && video.Title == title)
                {
                    VideoRent.CheckOut();
                    break;
                }
            }
        }

        public void ReturnVideo(string title)
        {
            foreach (Video video in Videos)
            {
                if (video != null && video.Title == title)
                {
                    VideoRent.Return();
                    break;
                }
            }
        }
        public void ReceiveRating(string title, int rating)
        {
            foreach (Video video in Videos)
            {
                if (video != null && video.Title == title)
                {
                    video.ReceiveRating(rating);
                    break;
                }
            }
        }
        public void Inventorylist()
        {
            foreach (Video video in Videos)
            {
                if (video != null)
                {
                    Console.WriteLine("Title: {0}, Average Rating: {1}, Checked Out: {2}", video.Title, video.AverageRating, VideoRent.CheckedOut ? "Yes" : "No");
                }
            }
        }

    }
}
