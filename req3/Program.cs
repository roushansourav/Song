using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace req3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Song> list = new List<Song>();
            SongBO sb = new SongBO();
            Console.WriteLine("Enter the number of Songs:");
            int n = Convert.ToInt32(Console.ReadLine());
            //fill code here.
            for (int i = 0; i < n; i++)
                list.Add(Song.CreateSong(Console.ReadLine()));
            Console.WriteLine("Enter a search type:\n1.Song Type\n2.Date of Download\n3.Rating");
            int choice = Convert.ToInt32(Console.ReadLine());
            //fill code here.
            switch(choice)
            {
                case 1:
                    Console.WriteLine("Enter the type:");
                    string type = Console.ReadLine();
                    List<Song> resultList = sb.FindSong(list, type);
                    Console.WriteLine("{0} {1,15} {2,15} {3,15} {4,15} {5,15}", "Name", "Artist", "Song Type", "Rating", "No of Download", "Date of Download");
                    foreach (Song s in resultList)
                        Console.WriteLine("{0} {1,15} {2,15} {3,15} {4,15} {5,15}",s.Name,s.Artist,s.SongType,s.Rating,s.NumberOfDownloads,s.DateDownloaded);
                    break;
                case 2:
                    Console.WriteLine("Enter the date:");
                    DateTime dt = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);
                    List<Song> resultList1 = sb.FindSong(list, dt);
                    Console.WriteLine("{0} {1,15} {2,15} {3,15} {4,15} {5,15}", "Name", "Artist", "Song Type", "Rating", "No of Download", "Date of Download");
                    foreach (Song s in resultList1)
                        Console.WriteLine("{0} {1,15} {2,15} {3,15} {4,15} {5,15}", s.Name, s.Artist, s.SongType, s.Rating, s.NumberOfDownloads, s.DateDownloaded);
                    break;
                case 3:
                    Console.WriteLine("Enter the rating:");
                    double rating = double.Parse(Console.ReadLine());
                    List<Song> resultList2 = sb.FindSong(list, rating);
                    Console.WriteLine("{0} {1,15} {2,15} {3,15} {4,15} {5,15}", "Name", "Artist", "Song Type", "Rating", "No of Download", "Date of Download");
                    foreach (Song s in resultList2)
                        Console.WriteLine("{0} {1,15} {2,15} {3,15} {4,15} {5,15}", s.Name, s.Artist, s.SongType, s.Rating, s.NumberOfDownloads, s.DateDownloaded);
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }
}
