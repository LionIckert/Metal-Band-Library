

namespace Metal_Band_Library.Library_Data
{
    public static class Data
    {
        public static Band[] Bands =
        {
            new Band()
            {
                name ="World of Sickness",
                artists = new []{Artists[0], Artists[1], Artists[2], Artists[3]},
                        bookingContact ="lion.ickert@gmail.com",
                        genre = new []{Genres[1]}
            },

            new Band()
            {
                name="Reavers"
            },

            new Band()
            {
                name = "Blind Guardian",
                artists = new []{Artists[6], Artists[7], Artists[8], Artists[9]},
                genre = new []{Genres[4], Genres[8]}
            }
        };

        public static Artist[] Artists =
        {
            new Artist() {FirstName="Lion", LastName="Ickert", ArtistName="Lion Ickert"},
            new Artist() {FirstName="Jonas", LastName="Johannsen", ArtistName="Jonas Johannsen"},
            new Artist() {FirstName="Tobias", LastName="Brombach", ArtistName="Tobias Brombach"},
            new Artist() {FirstName="Kai", LastName="Wolff", ArtistName="Kai Wolff"},

            new Artist() {FirstName="Katharina", LastName="Großbongardt", ArtistName="Katharina Großbongardt"},
            new Artist() {FirstName="", LastName="", ArtistName="" },

            new Artist() {FirstName="Hans Jürgen", LastName="Kürsch", ArtistName="Hansi Kürsch"},
            new Artist() {FirstName="André", LastName="Olbrich", ArtistName="André Olbrich"},
            new Artist() {FirstName="Marcus", LastName="Siepen", ArtistName="Masrcus Siepen"},
            new Artist() {FirstName="Frederik", LastName="Ehmke", ArtistName="Frederik Ehmke"}
            
        };

        public static Album[] Albums =
        {
            new Album()
            {
                title="Beyond the red Mirror",
                Band = Bands[2],
                bandName=Bands[2].name,
                Artists = Bands[2].artists
            }
        };

        public static Genre[] Genres =
        {
            new Genre() {genreType="Black Metal"},
            new Genre() {genreType="Melodic Death Metal"},
            new Genre() {genreType="Death Metal"},
            new Genre() {genreType="Thrash Metal"},
            new Genre() {genreType="Power Metal"},
            new Genre() {genreType="Heavy Metal"},
            new Genre() {genreType="Industrial Metal"},
            new Genre() {genreType="Folk Metal"},
            new Genre() {genreType="Speed Metal"}
        };

        public static Label[] Labels =
        {
            new Label() {name="AFM - All for Metal"},
            new Label() {name="Metal Blade Records"}
        };

    }

    public class Genre
    {
        public string genreType;
    }

    public class Label
    {
        public string name;
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
        public string name;
        public string country;
        public string city;
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
        public Genre[] genre;
        public string bookingContact;
    }
}
