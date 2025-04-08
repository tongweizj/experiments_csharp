using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theatre_Lab
{
    internal class Movie
    {
        public int Length { get; }
        public int Year { get; }
        public string Title { get; }
        public GenreEnum Genre { get; private set; } 
        public List<string> Cast { get; }

        public Movie(string title, int year, int length)
        {
            Length = length;
            Title = title;
            Year = year;
            Cast = new List<string> {  };
        }

        public void AddActor(string actor)
        {
            Cast.Add(actor);
        }
        public void SetGenre(GenreEnum genre) {
            this.Genre = this.Genre | genre;
        }

        public override string ToString()
        {
            return $"{Title}({Year}) {Length}min ({String.Join(", ", Genre)}) {String.Join(", ", Cast)}";
        }
    }
}
