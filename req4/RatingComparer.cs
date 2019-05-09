using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace req4
{
    class RatingComparer:IComparer<Song>
    {
        int IComparer<Song>.Compare(Song x, Song y)
        {
            Song c1 = x;
            Song c2 = y;

            if (c1.Rating > c2.Rating)
                return 1;

            if (c1.Rating < c2.Rating)
                return -1;

            else
                return 0;

        }

        public static IComparer<Song> Ratings()
        {
            return (IComparer<Song>)new RatingComparer();
        }
    }
}
