using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Artist
    {
        //fields
        //na

        //properties
        
        public Song[]Track { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        //ctors
        //fqctor
        /// <summary>
        /// Makes a fully qualified Course object
        /// </summary>
        
        /// <param name="Track">list of songs</param>
        /// <param name="Title">song name</param>
        /// <param name="Genre">song genre</param>
        public Artist(Song[] track, string title, string genre)
        {
            Track = track;
            Title = title;
            Genre = genre;
        }
        public Artist()
        {

        }
        //method
        public override string ToString()
        {
            //when dealing with writing collections out in a ToString(), it's best to build a string that will display the info.
            //for each collection (curriculum and roster), we will build a string variable to hold the desited info for each book or student
            string songsBy = "";


            foreach (Song song in Track)
            {
                songsBy += song + "\n";
            }

            //above we loop through each collection and assign the variable an added value for each book/student from the List being passed through in the property. we do this so that we ca actually see the bookTitles or studentName in their respective place in the return below.

            //below we replace directly calling the property value for curriculum and roster with their respective strings.

            return string.Format("\nSongs: {0}\t\tTitle: {1}\n" +
                "Genre: {2}\n",

                Track, Title, Genre);
        }
        }
}
