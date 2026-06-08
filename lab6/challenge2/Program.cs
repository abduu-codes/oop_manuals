using System;

namespace challenge2

{
    class Program
    {
        static void Main(string[] args)
        {
            Playlist myPlaylist = new Playlist("Favorites");

            Song s1 = new Song("Bohemian Rhapsody", "Queen");
            Song s2 = new Song("Imagine", "John Lennon");

            myPlaylist.AddSong(s1);
            myPlaylist.AddSong(s2);

            
            MusicDL.playlists.Add(myPlaylist);
            foreach (var p in MusicDL.playlists)
            {
                MusicUI.DisplayPlaylist(p);
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}