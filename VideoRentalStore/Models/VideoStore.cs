using NuGet.Packaging;
using System;
using System.Text;

namespace VideoRentalStore.Models
{
    // Open/Closed Principle (OCP)
    public class VideoStore
    {
        private List<Video> videos;
        public VideoStore()
        {
            videos = new List<Video>();
        }

        public void AddVideo(Video video)
        {
            videos.Add(video);
        }

        public void RemoveVideo(Video video)
        {
            videos.Remove(video);
        }

        public List<Video> GetAvailableVideos()
        {
            return videos.Where(video => !video.IsCheckedOut()).ToList();
        }

        public List<Video> GetCheckedOutVideos()
        {
            return videos.Where(video => video.IsCheckedOut()).ToList();
        }

        public void RateVideo(Video video, double rating)
        {
            video.ReceiveRating(rating);
        }
        public void CheckoutVideo(Video video)
        {
            if (videos.Contains(video))
            {
                video.CheckOut();
            }
        }

        public void ReturnVideo(Video video)
        {
            if (videos.Contains(video))
            {
                video.Return();
            }
        }

    }
    // Interface for Ratingable objects that can receive ratings
    public interface IRatingable
    {
        void ReceiveRating(double rating);
    }

    // RatingService class that can rate any object that implements IRatingable
    public class RatingService
    {
        public void Rate(IRatingable ratingable, double rating)
        {
            ratingable.ReceiveRating(rating);
        }
    }   
}
