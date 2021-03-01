using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Night_Part_2
{
    static class MovieManager
    {
        #region Insert data to table
        public static Actor InsertActor(Actor actor)
        {
            return Dalmanager.InsertActor(actor);
        }
        public static Movie InsertMovie(Movie movie)
        {
            return Dalmanager.InsertMovie(movie);
        }
        public static Contributing InsertContributing(Contributing contributing)
        {
            return Dalmanager.InsertContributing(contributing);
        }
        #endregion
        #region Update data in table

        public static Actor UpdateActor(Actor actor)
        {
            return Dalmanager.UpdateActor(actor);
        }
        public static Movie UpdateMovie(Movie movie)
        {
            return Dalmanager.UpdateMovie(movie);
        }
        public static Contributing UpdateContributing(Contributing contributing)
        {
            return Dalmanager.UpdateContributing(contributing);
        }
        #endregion

        #region Delete row in table

        public static Actor DeleteActor(Actor actor)
        {
            return Dalmanager.DeleteActor(actor);
        }

        public static Movie DeleteMovie(Movie movie)
        {
            return Dalmanager.DeleteMovie(movie);
        }
        #endregion
    }
}
