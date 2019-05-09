using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace req4
{
    class PopularityComparer:IComparer<Song>
    {
        int IComparer<Song>.Compare(Song x, Song y)
        {
            Song c1 = x;
            Song c2 = y;

            if (c1.NumberOfDownloads > c2.NumberOfDownloads)
                return 1;

            if (c1.NumberOfDownloads < c2.NumberOfDownloads)
                return -1;

            else
                return 0;

        }

        public static IComparer<Song> Popularity()
        {
            return (IComparer<Song>)new PopularityComparer();
        }
    }
}
