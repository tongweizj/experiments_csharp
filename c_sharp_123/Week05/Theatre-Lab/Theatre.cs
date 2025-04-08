using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theatre_Lab
{
    internal class Theatre
    {
        public List<Show> Shows;
        public string Name {  get; }
        public Theatre(string name)
        {

            Name = name;
            Shows = new List<Show> {  };
        }
        public void AddShow(Show show) 
        {
            Shows.Add(show); 
        }
        public string showstoString() {
            String showsStr = "";
            int index = 1;
            foreach (Show item in Shows)
            {
                showsStr += ($"\n{index}: {item}");
                index ++;
            }
            return showsStr;
        }
        public void PrintShows() 
        {
            //Cineplex
            //All shows
            //=============
            // 1: Mon 11:35 Terminator 2: Judgement Day (1991) 105min (Action, Horror) Arnold Schwarzenegger, Linda Hamilton $5.95
            Console.WriteLine($"\n{Name}\nAll shows\n============={showstoString()}");
        }
        public void PrintShows(GenreEnum genre)
        {
            String showsStr = "";
            int index = 1;
            foreach (Show item in Shows)
            {
                if (item.Movie.Genre.HasFlag(genre))
                {
                    showsStr += ($"\n{index}: {item}");
                    index++;
                }
            }
            Console.WriteLine($"\n{Name}\n{genre} shows\n============={showsStr}");
        }
        public void PrintShows(DayEnum day)
        {
            String showsStr = "";
            int index = 1;
            foreach (Show item in Shows)
            {
                if(item.Day == day)
                {
                    showsStr += ($"\n{index}: {item}");
                    index++;
                }
            }
            Console.WriteLine($"\n{Name}\nAll shows\n============={showsStr}");

        }
        public void PrintShows(Time time)
        {
            String showsStr = "";
            int index = 1;
            foreach (Show item in Shows)
            {
                if (item.Time == time)
                {
                    showsStr += ($"\n{index}: {item}");
                    index++;
                }
            }
            Console.WriteLine($"\n{Name}\nMovies @{time}\n============={showsStr}");

        }
        public void PrintShows(DayEnum day, Time time)
        {
            String showsStr = "";
            int index = 1;
            foreach (Show item in Shows)
            {
                if (item.Time == time && item.Day == day)
                {
                    showsStr += ($"\n{index}: {item}");
                    index++;
                }
            }
            Console.WriteLine($"\n{Name}\n{day} Movies @{time}\n============={showsStr}");
        }

        public void PrintShows(string actor)
        {
            String showsStr = "";
            int index = 1;
            foreach (Show item in Shows)
            {
                if (item.Movie.Cast.Exists(t =>t==actor))
                {
                    showsStr += ($"\n{index}: {item}");
                    index++;
                }
            }
            Console.WriteLine($"\n{Name}\n{actor} shows\n============={showsStr}");

        }


    }
}
