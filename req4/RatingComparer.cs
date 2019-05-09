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
           if (x.Rating > y.Rating)
                return 1;

            if (x.Rating < y.Rating)
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
