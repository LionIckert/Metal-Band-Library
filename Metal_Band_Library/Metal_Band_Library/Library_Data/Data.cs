

namespace Metal_Band_Library.Library_Data
{
    public static class Data
    {
        public static Band[] Bands =
        {

        };

        public static Artist[] Artists =
        {
            
        };

        public static Album[] Albums =
        {

        };

        public static Genre[] Genres =
        {

        };
    }

    public class Genre
    {
        public string genreType;
    }

    public class Album
    {
        public string title;
        public string bandName;
        public Artist[] Artists;
        public decimal Price { get; set; }
        public int Year { get; set; }
        public Studio Studio { get; set; }
        public Band Band { get; set; }
        public string Ean { get; set; }
    }

    public class Studio
    {
    }

    public class Artist
    {
        public string FirstName;
        public string LastName;
        public string ArtistName;
    }

    public class Band
    {
        public string name;
        public Artist[] artists;
        public string bookingContact;
    }
}
