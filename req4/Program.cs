using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace req4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Song> songList = new List<Song>();
            Console.WriteLine("Enter the number of the songs:");
            int count = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<count;i++)
            {
                songList.Add(Song.CreateSong(Console.ReadLine()));
            }
            //fill code here.
            Console.WriteLine("Enter a type to sort:\n1.Sort by name\n2.Sort by Rating\n3.Sort by Popularity");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    songList.Sort();
                    break;
                case 2:
                    songList.Sort(Song.Ratings());
                    break;
                case 3:
                    break;
            }
            //fill code here.
            Console.WriteLine("{0} {1,15} {2,15} {3,15} {4,15} {5,15}", "Name", "Artist", "Song Type", "Date of Download", "Rating", "No of Downloads");
            foreach(Song s in songList)
                Console.WriteLine(s);
            //fill code here.
        }
    }
}

