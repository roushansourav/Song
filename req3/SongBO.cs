using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace req3
{
    class SongBO
    {
        public List<Song> FindSong(List<Song> SongList, string type)
        {
            //fill code here.
            var searchResult = from p in SongList
                               where p.SongType.ToLower() == type.ToLower()
                               select p;
            return searchResult.ToList<Song>();
            
        }
        public List<Song> FindSong(List<Song> SongList, DateTime dateCreated)
        {
            //fill code here.
            var searchResult = from p in SongList
                               where p.DateDownloaded == dateCreated
                               select p;
            return searchResult.ToList<Song>();
        }
        public List<Song> FindSong(List<Song> SongList, double rating)
        {
            //fill code here.
            var searchResult = from p in SongList
                               where p.Rating == rating
                               select p;
            return searchResult.ToList<Song>();
        }
    }
}
