using NuGet.Packaging.Signing;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace VideoRentalStore.Models
{
    // Single Responsibility Principle (SRP)
    public class Video
    {
        private string title;
        private bool isCheckedOut;
        private double averageRating;
        public Video(string title)
        {
            this.title = title;
            isCheckedOut = false;
            averageRating = 0.0;
        }

        public void CheckOut()
        {
            isCheckedOut = true;
        }

        public void Return()
        {
            isCheckedOut = false;
        }

        public void ReceiveRating(double rating)
        {
            averageRating = (averageRating + rating) / 2.0;
        }

        public string GetTitle()
        {
            return title;
        }

        public bool IsCheckedOut()
        {
            return isCheckedOut;
        }

        public double GetAverageRating()
        {
            return averageRating;
        }

    }



    public interface IVideo
    {
        string Title { get; }
        bool IsCheckedOut { get; }
        void CheckOut();
        void Return();
    }
    public class VideoRating : IRating
    {
        private int _ratingCount;
        private int _totalRating;

        public void AddRating(int rating)
        {
            _totalRating += rating;
            _ratingCount++;
        }

        public double GetAverageRating()
        {
            return _ratingCount > 0 ? (double)_totalRating / _ratingCount : 0;
        }
    }

    public interface IRating
    {
        void AddRating(int rating);
        double GetAverageRating();
    }
}