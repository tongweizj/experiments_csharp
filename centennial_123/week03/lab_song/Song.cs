using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_song
{

    internal class Song
    {
        public string Artist { get; }
        public string Title { get; }
        public double Length { get; }
        public SongGenre Genre { get; }

        // constructor
        public Song(string title,string artist, double length, SongGenre genre)
        {
            Title = title;
            Artist = artist;
            Length = length;
            Genre = genre;
        }
        public override string ToString()
        {
            return $"{Title} by {Artist} ({genreToStr(Genre)}) {Length}min";
        }

        private string genreToStr(SongGenre genre)
        {
            String genreStr = "";

            foreach (SongGenre item in Enum.GetValues(typeof(SongGenre)))
            {
                if (item != 0 && (genre & item) == item) 
                {
                    genreStr = (genreStr == "") ? $"{item}" : $"{genreStr}, {item}";
                }
            }
            return genreStr;
        }
    }
}
