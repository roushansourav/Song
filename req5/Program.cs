using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace req5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Song> list = new List<Song>();
            Console.WriteLine("Enter the number of songs");
            int n1 = Convert.ToInt32(Console.ReadLine());
            //fill code here.
            for (int i = 0; i < n1; i++)
                list.Add(Song.CreateSong(Console.ReadLine()));
            Console.WriteLine("{0} {1,15}", "Song type", "Count");
            foreach(var ch in Song.CalculateTypeCount(list))
                Console.WriteLine("{0} {1,15}",ch.Key,ch.Value);
            //fill code here.
        }
    }
}
