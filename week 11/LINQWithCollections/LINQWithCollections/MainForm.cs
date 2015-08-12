﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LINQWithCollections
{
    public partial class MainForm : Form
    {
        private SongCollection mySongs;
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void loadSongs()
        {
            mySongs = new SongCollection();

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
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            loadSongs();
            showAll();
            textBoxArtistName.Select();
            textBoxArtistName.SelectAll();
        }
        
        private void showAll()
        {
            var query = from song in mySongs
                        orderby song.Artist, song.Length
                        select song;

            dataGridViewResults.DataSource = query.ToList();

            textBoxArtistName.Text = string.Empty;
        }

        private void showByArtist(string artistName)
        {
            var query = from song in mySongs
                        where song.Artist.ToLower() == artistName.ToLower()
                        orderby song.Length
                        select song;

            dataGridViewResults.DataSource = query.ToList();
        }

      
        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            showAll();
            textBoxArtistName.Select();
            textBoxArtistName.SelectAll();
        }

        private void buttonShowByArtist_Click(object sender, EventArgs e)
        {
            if (textBoxArtistName.Text != string.Empty)
            {
                showByArtist(textBoxArtistName.Text);
                errorProvider.SetError(textBoxArtistName, string.Empty);
            }
            else
            {
                errorProvider.SetError(textBoxArtistName, "Enter an Artist Name");
            }

            textBoxArtistName.Select();
            textBoxArtistName.SelectAll();
        }
    }
}
