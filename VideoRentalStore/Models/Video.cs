using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace VideoRentalStore.Models
{
    public class Video
    {
        public string Title { get; set; }
        public double AverageRating { get; set; }

        private List<int> Ratings = new List<int>();

        public void ReceiveRating(int rating)
        {
            Ratings.Add(rating);
            AverageRating = Ratings.Average();
        }
    }
    public interface IRentable
    {
        void CheckOut();
        void Return();
    }

    public class VideoRent : IRentable
    {
        public Video Video { get; set; }

        public VideoRent videoRent { get; set; }
        public bool CheckedOut { get; set; } = false;

        public void CheckOut()
        {
            CheckedOut = true;
        }

        public void Return()
        {
            CheckedOut = false;
        }
    }
}
