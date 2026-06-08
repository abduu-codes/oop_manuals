using System.Collections.Generic;

namespace challenge2
{
    public class Playlist
    {
        public string name;
        public List<Song> songs = new List<Song>();

        public Playlist(string name) {
            this.name = name; }
        public void AddSong(Song s) 
        {
            songs.Add(s);
        }
    }
}