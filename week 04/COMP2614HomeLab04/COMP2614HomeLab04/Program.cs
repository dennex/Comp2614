using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP2614HomeLab04
{
    class Program
    {
        static void Main(string[] args)
        {
            SongCollection mySongs = new SongCollection();

            mySongs.Add(new Song("Eric Clapton", "After Midnight", 338));
            mySongs.Add(new Song("Sister Hazel", "All for You", 392));
            mySongs.Add(new Song("Josh Groban", "America (Live Album Version)", 249));
            mySongs.Add(new Song("The Surfaris", "Apache", 171));
            mySongs.Add(new Song("Sister Hazel", "Beautiful Thing", 280));
            mySongs.Add(new Song("Jesse McCartney", "Because You Live", 223));
            mySongs.Add(new Song("The Ramones", "Blitzkreig Bop", 97));
            mySongs.Add(new Song("Eric Clapton", "Blues Power", 440));
            mySongs.Add(new Song("The Police", "Bring On the Night", 316));
            mySongs.Add(new Song("Sister Hazel", "Champagne High", 306));
            mySongs.Add(new Song("Sister Hazel", "Change Your Mind", 312));
            mySongs.Add(new Song("Black Sabbath", "Children of the Grave", 326));
            mySongs.Add(new Song("Black Sabbath", "Children of the Sea", 369));
            mySongs.Add(new Song("Eric Clapton", "Cocaine", 459));
            mySongs.Add(new Song("Zero 7", "Destiny", 224));
            mySongs.Add(new Song("Eric Clapton", "Double Trouble", 492));
            mySongs.Add(new Song("Neil Finn & Johnny Marr", "Down on the Corner", 271));
            mySongs.Add(new Song("Dokken", "Dream Warriors", 254));
            mySongs.Add(new Song("Eric Clapton", "Early In the Morning", 431));
            mySongs.Add(new Song("Santana", "Esperando", 357));
            mySongs.Add(new Song("Coldplay", "Fix You", 277));
            mySongs.Add(new Song("Black Sabbath", "Fluff", 60));
            mySongs.Add(new Song("Foghat", "Fool for the City", 331));
            mySongs.Add(new Song("Eisley", "Golly Sandra (Live Version)", 218));
            mySongs.Add(new Song("The Veronicas", "Heavily Broken (Live Version)", 259));
            mySongs.Add(new Song("Zero 7", "Home", 383));
            mySongs.Add(new Song("Neil Finn & Eddie Vedder", "I See Red", 211));
            mySongs.Add(new Song("John Denver", "I Want to Live", 226));
            mySongs.Add(new Song("Black Sabbath", "Iron Man", 450));
            mySongs.Add(new Song("The Police", "King of Pain", 353));
            mySongs.Add(new Song("Eric Clapton", "Lay Down Sally", 335));
            mySongs.Add(new Song("Kenny Wayne Shepherd", "Live On", 275));
            mySongs.Add(new Song("Michael W. Smith", "Live the Life", 275));
            mySongs.Add(new Song("Big & Rich", "Live This Life (Music Only)", 262));
            mySongs.Add(new Song("Kenny Chesney", "Live Those Songs", 248));
            mySongs.Add(new Song("Belle and Sebastian", "Mayfly (Live Version)", 228));
            mySongs.Add(new Song("The Police", "Message in a Bottle", 276));
            mySongs.Add(new Song("Zero 7", "Morning Song", 426));
            mySongs.Add(new Song("Dokken", "Mr. Scary", 503));
            mySongs.Add(new Song("Madonna", "Music", 151));
            mySongs.Add(new Song("Black Sabbath", "N.I.B.", 309));
            mySongs.Add(new Song("Black Sabbath", "Neon Knights", 276));
            mySongs.Add(new Song("Goldfrapp", "Number 1", 244));
            mySongs.Add(new Song("Josh Groban", "Oceano (Live Album Version)", 232));
            mySongs.Add(new Song("The Ramones", "Pet Sematary", 220));
            mySongs.Add(new Song("The Surfaris", "Pipeline", 123));
            mySongs.Add(new Song("Sarah McLachlan", "Push", 244));


            displaySongs(mySongs);

            mySongs[0].Play();
            mySongs[0].Play();
            mySongs[10].Play();
            mySongs[0].Play();
            mySongs[0].Play();
            mySongs[12].Play();
            mySongs[0].Play();
            mySongs[5].Play();
            mySongs[0].Play();
            mySongs[19].Play();

            Console.WriteLine("\n\n{0} songs in your collection have been played\n"
                                , mySongs.PlayedCount);

            // SongCollection has total seconds.  Use a TimeSpan structure to 
            // easily convert to hours, minutes and seconds.  One of its constructors
            // lets you specify the time span in hours, minutes and seconds.  We have
            // the total time in seconds, so pass (0, 0, seconds) to the constructor.
            // Let it figure out how many hours, minutes and seconds that is by using
            // its Hours, Minutes and Seconds properties.
            //
            // Note this is different from the DateTime structure.
            TimeSpan ts = new TimeSpan(0, 0, mySongs.TotalLength);
            Console.WriteLine("Total playing time of your collection is {0}:{1}:{2}\n",
                        ts.Hours, ts.Minutes, ts.Seconds);

            string artist;
            do
            {
                Console.Write("Please enter an artist (blank to stop): ");
                artist = Console.ReadLine();

                if (artist != "")
                {
                    SongCollection songsByOneArtist = mySongs.GetAllByArtist(artist);

                    if (songsByOneArtist.Count > 0)
                    {
                        Console.WriteLine("\nSongs by {0} - Total Songs: {1}"
                                          , songsByOneArtist[0].Artist
                                          , songsByOneArtist.Count);

                        Console.WriteLine(new string('=', 75));
                        displaySongs(songsByOneArtist);
                    }
                    else
                    {
                        Console.WriteLine("Nothing found by artist: {0}\n\n", artist);
                    }
                }
            } while (artist != string.Empty);
        }

        // You might be tempted to put this method into the SongCollection class.  After all,
        // the logic pertains to the song collection as a whole.  However, it performs user 
        // interface code (outputs to the screen) and in general, we try to separate UI code
        // from business code.  We'll get into this more later in the course.
        private static void displaySongs(SongCollection songs)
        {
            if (songs.Count > 0)
            {
                Console.WriteLine("{0, -35} {1, -30} {2, 8}", "Title", "Artist", "Length");
                Console.WriteLine(new string('=', 75));
                foreach (Song song in songs)
                {
                    Console.WriteLine("{0, -35} {1, -30} {2, 8}"
                                      , song.Title
                                      , song.Artist
                                      , song.Length);
                }
                Console.WriteLine(new string('-', 75));
            }
            else
            {
                Console.WriteLine("Nothing to Display\n\n");
            }
        }
    }
}
