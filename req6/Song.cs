using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace req6
{
    class Song
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

        public string Name { get => _name; set => _name = value; }
        public string Artist { get => _artist; set => _artist = value; }
        public string SongType { get => _songType; set => _songType = value; }
        public DateTime DateDownloaded { get => _dateDownloaded; set => _dateDownloaded = value; }
        public double Rating { get => _rating; set => _rating = value; }
        public int NumberOfDownloads { get => _numberOfDownloads; set => _numberOfDownloads = value; }

        public static Song CreateSong(string details)
        {
            string[] input = details.Split(',');
            return new Song(input[0], input[1], input[2], DateTime.ParseExact(input[3], "dd-MM-yyyy", null),double.Parse(input[4]),int.Parse(input[5]));
        }

        //fill code here.

        public static Dictionary<string, int> CalculateTypeCount(List<Song> list)
        {
            //fill code here.
            var songTypeDict = from p in list
                               group p by p.SongType into b
                               select new { b.Key, value=b.Count() };
            return songTypeDict.ToDictionary(r=>r.Key,r=>r.value);
        }
        public static String PredictState(Dictionary<string, int> perTypeCount)
        {
            //fill code here.
            int count = 0;string mood = null;
            foreach(var ch in perTypeCount)
            {
                if (ch.Value > count)
                {
                    count = ch.Value;
                    mood = ch.Key;
                }
            }
            return mood;

        }
    }
}
