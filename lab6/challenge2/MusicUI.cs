using System;

namespace challenge2

{
    public class MusicUI
    {
        public static void DisplayPlaylist(Playlist p)
        {
            Console.WriteLine($"\nPlaylist: {p.name}");
            foreach (var s in p.songs)
                Console.WriteLine($"- {s.title} by {s.artist}");
        }
    }
}