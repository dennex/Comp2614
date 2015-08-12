using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP2614HomeLab04
{
    class SongCollection : List<Song>
    {
        /// <summary>
        /// Gets the number of songs that have been played in this collection.
        /// </summary>
        public int PlayedCount
        {
            get
            {
                int total = 0;
                foreach (Song song in this)
                {
                    if (song.TimesPlayed > 0)
                    {
                        total++;
                    }
                }
                return total;
            }
        }

        /// <summary>
        /// Gets the total seconds of all songs in this collection.
        /// </summary>
        public int TotalLength
        {
            get
            {
                int total = 0;

                foreach (Song song in this)
                {
                    total += song.Length;
                }
                return total;
            }
        }

        /// <summary>
        /// Returns a new List object containing the songs from this collection that
        /// are sung by the given artist.
        /// </summary>
        /// <param name="artist">Name of the artist to use as a filter.</param>
        /// <returns>A new List object containing the songs from this collection that
        /// are sung by the given artist.</returns>
        public SongCollection GetAllByArtist(string artist)
        {
            SongCollection result = new SongCollection();

            foreach (Song song in this)
            {
                if (song.Artist.ToLower() == artist.ToLower())
                {
                    result.Add(song);
                }
            }
            return result;
        }
    }
}
