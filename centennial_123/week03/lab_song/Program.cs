using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_song
{
    [Flags]
    enum SongGenre
    {
        Unclassified = 0,
        Pop = 0b1,
        Rock = 0b10,
        Blues = 0b100,
        Country = 0b1_000,
        Metal = 0b10_000,
        Soul = 0b1000_000
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Test();
        }
        
        public static void Test()
        {
            //To test the constructor and the ToString method
            Console.WriteLine(new Song("Baby", "Justin Bebier", 3.35, SongGenre.Pop));
            
            //This is first time that you are using the bitwise or. It is used to specify a combination of genres
            Console.WriteLine(new Song("The Promise", "Chris Cornell", 4.26,
            SongGenre.Country | SongGenre.Rock));

            // All Songs
            Console.WriteLine("\n\nAll songs");
            Library.LoadSongs("Week_03_lab_09_songs4.txt"); //Class methods are invoke with the class name
            Library.DisplaySongs();

            SongGenre genre = SongGenre.Rock;
            Console.WriteLine($"\n\n{genre} songs");
            Library.DisplaySongs(genre);

            string artist = "Bob Dylan";
            Console.WriteLine($"\n\nSongs by {artist}");
            Library.DisplaySongs(artist);

            double length = 5.0;
            Console.WriteLine($"\n\nSongs more than {length}mins");
            Library.DisplaySongs(length);
        }
    }
}
