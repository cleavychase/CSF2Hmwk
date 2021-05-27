using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Song
    {
        //fields
        private string _artist;
        private string _title;
        private string _genre;


        public string Artist
        {
            get { return _artist; }
            set { _artist = value; }
        }
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        public string Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }

        public Song(string artist, string title, string genre)
        {
            //Prop = param;
            Artist = artist;
            Title = title;
            Genre = genre;

        }//end of Fully Qualified CTOR (FQCTOR) - we used every property in the creation of the object
        public Song()
        {

        }
        //methods
        public override string ToString()
        {
            //return base.ToString();
            return string.Format("Artist: {0}\n" +
                "Title: {1}\n" +
                "Genre: {2}\n",
                Artist,
                Title,
                Genre
                );
        }

    }
}
