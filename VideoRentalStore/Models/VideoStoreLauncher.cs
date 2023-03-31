namespace VideoRentalStore.Models
{
    public class VideoStoreLauncher
    {
        static void Main(string[] args)
        {
            VideoStore store= new VideoStore();
            Video matrixVideo = new Video("The Matrix");
            Video godfatherVideo = new Video("Godfather II");
            Video starWarsVideo = new Video("Star Wars Episode IV: A New Hope");

            store.AddVideo(matrixVideo);
            store.AddVideo(godfatherVideo);
            store.AddVideo(starWarsVideo);

            // Give several ratings to each video
            matrixVideo.ReceiveRating(4.0);
            matrixVideo.ReceiveRating(4.5);
            matrixVideo.ReceiveRating(3.5);

            godfatherVideo.ReceiveRating(5.0);
            godfatherVideo.ReceiveRating(4.0);
            godfatherVideo.ReceiveRating(4.5);

            starWarsVideo.ReceiveRating(4.0);
            starWarsVideo.ReceiveRating(3.5);
            starWarsVideo.ReceiveRating(4.5);

            // Rent each video out once and return it
            store.CheckoutVideo(matrixVideo);
            store.ReturnVideo(matrixVideo);

            store.CheckoutVideo(godfatherVideo);
            store.ReturnVideo(godfatherVideo);

            store.CheckoutVideo(starWarsVideo);
            store.ReturnVideo(starWarsVideo);

            // List the inventory after "Godfather II" has been rented out
            store.CheckoutVideo(godfatherVideo);
            Console.WriteLine("Inventory:");
            foreach (Video video in store.GetAvailableVideos())
            {
                Console.WriteLine("Title: " + video.GetTitle());
                Console.WriteLine("Average rating: " + video.GetAverageRating());
                Console.WriteLine("Checked out: " + video.IsCheckedOut());
                Console.WriteLine();
            }
        }

    }
}
