using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini_Assesment
{
    public class Movie
    {
        public static string name;

        public int ticketId;
        public string seatNumber;

        public Movie ReturnMovieDetails( string name, int ticketId,string seatNumber)
        {
            Movie movie = new Movie();
            Movie.name = name;
            movie.ticketId = ticketId;
            movie.seatNumber = seatNumber;
            return movie;
        }

    }
    public class MovieProgram
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter the movie name");
            string name = Console.ReadLine();
            Console.WriteLine("enter the ticket id");
            int ticketId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the seat number");
            string seatNumber = Console.ReadLine();

            Movie movie = new Movie();
            movie = movie.ReturnMovieDetails(name, ticketId, seatNumber);

            Console.WriteLine("Movie name : " + Movie.name);
            Console.WriteLine("Ticket id : " + movie.ticketId);
            Console.WriteLine("seat number : " + movie.seatNumber);

        }
    }
}
