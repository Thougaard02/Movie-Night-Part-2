using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Night_Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Objects

            Actor actor = new Actor("Bob", "Marley");
            Actor updateActor = new Actor(2, "JOE", "Mamma");
            //Parameter takes the actor SID you want to delete
            Actor deleteActor = new Actor(13);

            Movie movie = new Movie("Harry Potter", 2005, "04:00", "Eventyr");
            Movie UpdateMovie = new Movie(1, "Harry Potter", 2005, "11:00", "Eventyr");
            //Parameter takes the movie FID you want to delete
            Movie deleteMovie = new Movie(19);

            // FID = Which movie the actors is in
            //SID = Actors ID
            //                                          FID     SID
            Contributing contributing = new Contributing(5,      5);
            //Set FID to a value
            //SID Must be a valid id.
            //                                                FID     SID
            Contributing updateContributing = new Contributing(19,      6 );
            #endregion

            #region Insert data to table in database
            //Console.WriteLine("Insert new actor to database");
            //MovieManager.InsertActor(actor);
            //Console.WriteLine($"{actor.FirstName} {actor.LastName}");

            //Console.WriteLine("\nInsert new movie to database");
            //MovieManager.InsertMovie(movie);
            //Console.WriteLine($"{movie.Title} {movie.Year} {movie.Showtime} {movie.Genre}");

            //Console.WriteLine("Insert IDs to contributing table");
            //MovieManager.InsertContributing(contributing);
            //Console.WriteLine($"FID: {contributing.FID}\nSID: {contributing.SID}");
            #endregion

            #region Update data in table to database
            //Console.WriteLine("\nUpdate Actor in database");
            //MovieManager.UpdateActor(updateActor);
            //Console.WriteLine($"{updateActor.FirstName} {updateActor.LastName}");

            //Console.WriteLine("\nUpdate movie in database");
            //MovieManager.UpdateMovie(UpdateMovie);
            //Console.WriteLine($"{UpdateMovie.Title} {UpdateMovie.Year} {UpdateMovie.Showtime} {UpdateMovie.Genre}");

            //Console.WriteLine("\nUpdate contributing in table");
            //MovieManager.UpdateContributing(updateContributing);
            //Console.WriteLine($"Updates FID: {updateContributing.FID}\nWHERE SID: {updateContributing.SID}");
            #endregion

            #region Delete row in table database
            //Deletes also in contributing if id is valid

            //Console.WriteLine("\nDelete Actor in database");
            //MovieManager.DeleteActor(deleteActor);
            //Console.WriteLine($"SID: {deleteActor.Id}");

            //Deletes in contributing if id is valid
            //Console.WriteLine("\nDelete movie in database");
            //MovieManager.DeleteMovie(deleteMovie);
            //Console.WriteLine($"FID: {deleteMovie.Id}");
            #endregion
        }
    }
}
