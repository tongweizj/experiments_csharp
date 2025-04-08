using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_song
{
    internal class Library
    {
        private static List<Song> songs = new List<Song>();
        public static void LoadSongs(string filename)
        {
            songs.Clear();
            TextReader textReader = new StreamReader(filename);
            string line="";
            string title = "";
            string artist = "";
            double length = 0.0;
            SongGenre genre = SongGenre.Unclassified;
            while ((title = textReader.ReadLine())!=null)
            {
                artist = textReader.ReadLine();
                length = Convert.ToDouble(textReader.ReadLine());
                Enum.TryParse(textReader.ReadLine(), out genre);
                songs.Add(new Song(title, artist, length, genre));
            }
            textReader.Close();
        }
        public static void DisplaySongs()
        {
            foreach (Song song in songs)
            {
                Console.WriteLine(song); 
            }

        }

        public static void DisplaySongs(double longerThan) 
        {
            foreach (Song song in songs)
            {
                if(song.Length > longerThan)
                {
                    Console.WriteLine(song);
                }
            }
        }

        public static void DisplaySongs(SongGenre genre)
        {
            foreach (Song song in songs)
            {
                if (song.Genre == genre)
                {
                    Console.WriteLine(song);
                }
            }
        }
        public static void DisplaySongs(string artist)
        {
            foreach (Song song in songs)
            {
                if (song.Artist == artist)
                {
                    Console.WriteLine(song);
                }
            }
        }
    }
}
