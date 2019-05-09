using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace req3
{
    public class Song
    {
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

        public string Name { get { return _name; } set { _name = value; } }
        public string Artist { get { return _artist; } set { _artist = value; } }
        public string SongType { get { return _songType; } set { _songType = value; } }
        public DateTime DateDownloaded { get { return _dateDownloaded; } set { _dateDownloaded = value; } }
        public double Rating { get { return _rating; } set { _rating = value; } }
        public int NumberOfDownloads { get { return _numberOfDownloads; } set { _numberOfDownloads = value; } }

        public static Song CreateSong(string details)
        {
            string[] input = details.Split(',');
            return new Song(input[0], input[1], input[2], DateTime.ParseExact(input[5], "dd-MM-yyyy", null), double.Parse(input[3]), int.Parse(input[4]));
        }

        public override string ToString()
        {
            string rate = string.Format("{0:0.0}", Rating);

            return string.Format("{0} {1,15} {2,15} {3,15} {4,15} {5,15}", Name, Artist, SongType, DateDownloaded.ToShortDateString(), rate, NumberOfDownloads);
        }
        


    }
}
