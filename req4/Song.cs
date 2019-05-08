using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace req4
{
    public class Song:IComparable
    {
        private class RatingComparer : IComparer
        {
            int IComparer.Compare(object x, object y)
            {
                Song c1 = (Song)x;
                Song c2 = (Song)y;

                if (c1.Rating > c2.Rating)
                    return 1;

                if (c1.Rating < c2.Rating)
                    return -1;

                else
                    return 0;

            }
        }

        private class PopularityComparer : IComparer
        {
            int IComparer.Compare(object x, object y)
            {
                Song c1 = (Song)x;
                Song c2 = (Song)y;

                if (c1.NumberOfDownloads > c2.NumberOfDownloads)
                    return 1;

                if (c1.NumberOfDownloads < c2.NumberOfDownloads)
                    return -1;

                else
                    return 0;

            }
        }

        public static IComparer Ratings()
        {
            return (IComparer) new RatingComparer();
        }

        public static IComparer Popularity()
        {
            return (IComparer)new PopularityComparer();
        }
        string _name;
        string _artist;
        string _songType;
        DateTime _dateDownloaded;
        double _rating;
        int _numberOfDownloads;

        public Song(string name, string artist, string songType, DateTime dateDownloaded, double rating, int numberOfDownloads)
        {
            _name = name;
            _artist = artist;
            _songType = songType;
            _dateDownloaded = dateDownloaded;
            _rating = rating;
            _numberOfDownloads = numberOfDownloads;
        }

        public string Name { get => _name; set => _name = value; }
        public string Artist { get => _artist; set => _artist = value; }
        public string SongType { get => _songType; set => _songType = value; }
        public DateTime DateDownloaded { get => _dateDownloaded; set => _dateDownloaded = value; }
        public double Rating { get => _rating; set => _rating = value; }
        public int NumberOfDownloads { get => _numberOfDownloads; set => _numberOfDownloads = value; }

        public static Song CreateSong(string details)
        {
            string[] input = details.Split(',');
            return new Song(input[0], input[1], input[2], DateTime.ParseExact(input[3], "dd-MM-yyyy", null), double.Parse(input[4]), int.Parse(input[5]));
        }

        public override string ToString()
        {
            string rate = string.Format("{0:0.0}", Rating);

            return string.Format("{0} {1,15} {2,15} {3,15} {4,15} {5,15}",Name,Artist,SongType,DateDownloaded.ToShortDateString(),rate,NumberOfDownloads);
        }
        public int CompareTo(object obj)
        {   
            Song s=(Song)obj;
            return this.Name.CompareTo(s.Name);
        }

        
    }
}
