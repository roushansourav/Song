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
            if (x.NumberOfDownloads > y.NumberOfDownloads)
                return 1;

            if (x.NumberOfDownloads < y.NumberOfDownloads)
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
