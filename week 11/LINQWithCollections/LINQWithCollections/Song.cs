using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQWithCollections
{
    /// <summary>
    /// Represents a piece of music.
    /// </summary>
    public class Song
    {
        private string artist;
        private string title;
        private int lengthSeconds;
        private int timesPlayed;

        /// <summary>
        /// Initializes an new instance of the Song class.
        /// </summary>
        /// <param name="artist">Name of the person or band who sings the song.</param>
        /// <param name="title">Name of the song.</param>
        /// <param name="lengthSeconds">Playing length of the song, in seconds.</param>
        public Song(string artist, string title, int lengthSeconds)
        {
            this.artist = artist;
            this.title = title;
            this.lengthSeconds = lengthSeconds;
        }

        /// <summary>
        /// Gets the name of the artist who sings this song.
        /// </summary>
        public string Artist { get { return artist; } }

        /// <summary>
        /// Gets the name of the song.
        /// </summary>
        public string Title { get { return title; } }

        /// <summary>
        /// Gets the playing length of the song, in seconds.
        /// </summary>
        public int Length { get { return lengthSeconds; } }

        /// <summary>
        /// Gets the number of times this piece of music has been played.
        /// </summary>
        public int TimesPlayed { get { return timesPlayed; } }

        /// <summary>
        /// Plays this piece of music--well, not really, but it lets
        /// this object keep track of the number of times it has been
        /// "played".
        /// </summary>
        public void Play()
        {
            timesPlayed++;
        }

        public override string ToString()
        {
            return string.Format("{0} by {1}", title, artist);
        }
    }
}
