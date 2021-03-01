using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Night_Part_2
{
    class Movie
    {
        #region Properties

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private int year;

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        private string showtime;

        public string Showtime
        {
            get { return showtime; }
            set { showtime = value; }
        }

        private string genre;

        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }
        #endregion

        #region Constructors

        public Movie()
        {

        }
        public Movie(string _title, int _year, string _showTime, string _genre)
        {
            this.Title = _title;
            this.Year = _year;
            this.Showtime = _showTime;
            this.Genre = _genre;
        }

        public Movie(int _id, string _title, int _year, string _showTime, string _genre) : this(_title, _year, _showTime, _genre)
        {
            this.id = _id;
        }
        //Delete Movie with a id
        public Movie(int _id)
        {
            this.Id = _id;
        }
        #endregion
    }
}
