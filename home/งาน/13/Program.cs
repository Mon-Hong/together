using System;

namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {
            MovieInfo myMovie;
            myMovie = ReadInfo();
         

            Console.WriteLine("Movie name : {0}" ,myMovie.Name);
            Console.WriteLine("Movie genre : {0}", myMovie.Genre);
            Console.WriteLine("Movie minute : {0}", myMovie.Minute);

            Console.ReadLine();
        }

        struct MovieInfo
        {
            public string Name, Genre;
            public int Minute;
        }

        static MovieInfo ReadInfo()
        {
            MovieInfo input;
            input.Name = Console.ReadLine();
            input.Genre = Console.ReadLine();
            input.Minute = int.Parse(Console.ReadLine());
            return input;

        }

    }
}
