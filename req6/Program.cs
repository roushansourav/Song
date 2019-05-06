using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace req6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Song> list = new List<Song>();
            Console.WriteLine("Enter the number of songs");
            int n1 = Convert.ToInt32(Console.ReadLine());
            //fill code here.
            for(int i=0;i<n1;i++)
            {
                list.Add(Song.CreateSong(Console.ReadLine()));
            }
            Dictionary<string, int> perTypeSong = new Dictionary<string, int>();
            perTypeSong = Song.CalculateTypeCount(list);
            //foreach(var ch in perTypeSong)
            //    Console.WriteLine(ch.Key+" "+ch.Value);
            string mood = Song.PredictState(perTypeSong);
            if(mood.Equals("Emotional"))
                Console.WriteLine("The user is feeling depressed");
            if (mood.Equals("Celebration"))
                Console.WriteLine("The user is feeling happy");
            if (mood.Equals("Motivational"))
                Console.WriteLine("The user is feeling energetic");
        }
    }

        
}
