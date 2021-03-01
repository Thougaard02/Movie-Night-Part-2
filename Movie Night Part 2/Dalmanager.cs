using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Night_Part_2
{
    static class Dalmanager
    {
        //Connection string to database
        private static string cs = @"Server=THOUGAARD;Database=MCU;Trusted_Connection=True;";


        #region Insert data to table

        /// <summary>
        /// Insert a actor to Actors table
        /// </summary>
        /// <param name="actor"></param>
        /// <returns></returns>
        public static Actor InsertActor(Actor actor)
        {
            //Insert Query to actors
            string insertActor = "INSERT INTO Actors(FirstName, LastName) VALUES (@fn, @ln)";
            using (SqlConnection connection = new SqlConnection(cs))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(insertActor, connection);
                //Adds actor values to table
                cmd.Parameters.Add(new SqlParameter("@fn", actor.FirstName));
                cmd.Parameters.Add(new SqlParameter("@ln", actor.LastName));

                cmd.ExecuteNonQuery();
            }
            return actor;
        }
        /// <summary>
        /// Insert a movie to movies table
        /// </summary>
        /// <param name="movie"></param>
        /// <returns></returns>
        public static Movie InsertMovie(Movie movie)
        {
            string insertMovie = "INSERT INTO Movies (Title, Year, Show_time, Genre) VALUES (@Title, @Year, @Show_time, @Genre)";
            using (SqlConnection connection = new SqlConnection(cs))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(insertMovie, connection);
                //Adds movie values to table
                cmd.Parameters.Add(new SqlParameter("@Title", movie.Title));
                cmd.Parameters.Add(new SqlParameter("@Year", movie.Year));
                cmd.Parameters.Add(new SqlParameter("@Show_time", movie.Showtime));
                cmd.Parameters.Add(new SqlParameter("@Genre", movie.Genre));

                //Execute variable cmd
                cmd.ExecuteNonQuery();
            }
            return movie;
        }
        /// <summary>
        /// Insert a FID and SID to contributing table
        /// </summary>
        /// <param name="movie"></param>
        /// <returns></returns>
        public static Contributing InsertContributing(Contributing contributing)
        {
            string insertContributing = "INSERT INTO Contributing(FID, SID) VALUES (@FID, @SID)";
            using (SqlConnection connection = new SqlConnection(cs))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(insertContributing, connection);
                //Adds contributing values to table
                cmd.Parameters.Add(new SqlParameter("@FID", contributing.FID));
                cmd.Parameters.Add(new SqlParameter("@SID", contributing.SID));

                //Execute variable cmd
                cmd.ExecuteNonQuery();
            }
            return contributing;
        }
        #endregion

        #region Update data in table


        /// <summary>
        /// Updates actors columm in actors table
        /// </summary>
        /// <param name="actor"></param>
        /// <returns></returns>
        public static Actor UpdateActor(Actor actor)
        {

            string insertActor = "UPDATE Actors SET FirstName = @FirstName, LastName = @LastName WHERE SID = @SID";
            using (SqlConnection connection = new SqlConnection(cs))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(insertActor, connection);
                cmd.Parameters.AddWithValue("@SID", actor.Id);
                cmd.Parameters.AddWithValue("@FirstName", actor.FirstName);
                cmd.Parameters.AddWithValue("@LastName", actor.LastName);
                cmd.ExecuteNonQuery();
            }
            return actor;
        }
        /// <summary>
        /// Updates movie columms in movies table
        /// </summary>
        /// <param name="movie"></param>
        /// <returns></returns>
        public static Movie UpdateMovie(Movie movie)
        {
            string updateMovie = "UPDATE Movies SET Title = @Title, Year = @Year, Show_time = @Show_time, Genre = @Genre WHERE FID = @FID";
            using (SqlConnection connection = new SqlConnection(cs))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(updateMovie, connection);
                cmd.Parameters.AddWithValue("@FID", movie.Id);
                cmd.Parameters.AddWithValue("@Title", movie.Title);
                cmd.Parameters.AddWithValue("@Year", movie.Year);
                cmd.Parameters.AddWithValue("@Show_time", movie.Showtime);
                cmd.Parameters.AddWithValue("@Genre", movie.Genre);

                cmd.ExecuteNonQuery();
            }
            return movie;
        }

        /// <summary>
        /// Updates contributing columm in contributing table.
        /// </summary>
        /// <param name="actor"></param>
        /// <returns></returns>
        public static Contributing UpdateContributing(Contributing contributing)
        {

            string updateContributing = "UPDATE Contributing SET FID = @FID WHERE SID = @SID";
            using (SqlConnection connection = new SqlConnection(cs))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(updateContributing, connection);
                cmd.Parameters.AddWithValue("@FID", contributing.FID);
                cmd.Parameters.AddWithValue("@SID", contributing.SID);
                cmd.ExecuteNonQuery();
            }
            return contributing;
        }
        #endregion

        #region Delete row in table

        /// <summary>
        /// Delete actor from actors table
        /// </summary>
        /// <param name="SID"></param>
        /// <returns></returns>
        public static Actor DeleteActor(Actor SID)
        {
            //Query to delete foriegn key from Contributing
            string deleteContributingQuery = "DELETE FROM Contributing WHERE SID = @SID";
            //Query to delete actor with the equal SID in Actors
            string deleteActorQuery = "DELETE FROM Actors WHERE SID = @SID";
            using (SqlConnection connection = new SqlConnection(cs))
            {
                //Opens database connection
                connection.Open();
                //Takes query and connection
                SqlCommand cmdFK = new SqlCommand(deleteContributingQuery, connection);
                SqlCommand cmdPK = new SqlCommand(deleteActorQuery, connection);

                cmdFK.Parameters.Add(new SqlParameter("@SID", SID.Id));
                //Execute the cmdFK
                cmdFK.ExecuteNonQuery();

                cmdPK.Parameters.Add(new SqlParameter("@SID", SID.Id));
                //Execute the cmdPK
                cmdPK.ExecuteNonQuery();
            }
            return SID;
        }

        /// <summary>
        /// Delete actor from actors table
        /// </summary>
        /// <param name="actor"></param>
        /// <returns></returns>
        public static Movie DeleteMovie(Movie FID)
        {
            //Query to delete foriegn key from Contributing
            string deleteContributingQuery = "DELETE FROM Contributing WHERE FID = @FID";
            //Query to delete actor with the equal SID in Actors
            string deleteMovieQuery = "DELETE FROM Movies WHERE FID = @FID";
            using (SqlConnection connection = new SqlConnection(cs))
            {
                //Opens database connection
                connection.Open();
                //Takes query and connection
                SqlCommand cmdFK = new SqlCommand(deleteContributingQuery, connection);
                SqlCommand cmdPK = new SqlCommand(deleteMovieQuery, connection);

                //Execute the cmdFK
                cmdFK.Parameters.Add(new SqlParameter("@FID", FID.Id));
                cmdFK.ExecuteNonQuery();

                cmdPK.Parameters.Add(new SqlParameter("@FID", FID.Id));
                //Execute the cmdPK
                cmdPK.ExecuteNonQuery();
            }
            return FID;
        }
        #endregion
    }
}
