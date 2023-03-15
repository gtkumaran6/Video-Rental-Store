namespace VideoRentalStore.Models
{
    public class VideoStoreLauncher
    {
        static void Main(string[] args)
        {
             VideoStore vstore= new VideoStore();
            vstore.addVideo("The Matrix");
            vstore.addVideo("Godfather II");
            vstore.addVideo("Star Wars Episode IV: A New Hope");

            vstore.ReceiveRating("The Matrix",4);
            vstore.ReceiveRating("The Matrix", 5);
            vstore.ReceiveRating("The Matrix", 5);
                
            vstore.ReceiveRating("Godfather II", 5);
            vstore.ReceiveRating("Godfather II", 3);
            vstore.ReceiveRating("Godfather II", 2);

            vstore.ReceiveRating("Star Wars Episode IV: A New Hope", 4);
            vstore.ReceiveRating("Star Wars Episode IV: A New Hope", 3);
            vstore.ReceiveRating("Star Wars Episode IV: A New Hope", 4);

            vstore.CheckOut("The Matrix");
            vstore.ReturnVideo("The Matrix");

            vstore.CheckOut("Godfather II");
            vstore.ReturnVideo("Godfather II");

            vstore.CheckOut("Godfather II");
            vstore.ReturnVideo("Godfather II");


            vstore.Inventorylist();

        }

    }
}
