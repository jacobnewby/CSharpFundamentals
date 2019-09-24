using System;
using System.Collections.Generic;
using _07_StreamingContent_Repository;

namespace _07_StreamingContentRepository_Console
{
    internal class ProgramUI
    {
        StreamingContentRepository _streamingRepo = new StreamingContentRepository();
        public ProgramUI()
        {
        }

        public void Run()
        {
            _streamingRepo.SeedList();
            RunMenu();
        }

        private void RunMenu()
        {
            Console.WriteLine("Enter the number of the menu item you would like to see\n" +
                "1. Create Movie\n" +
                "2. Remove Movie\n" +
                "3. See All Movies\n" +
                "");

            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    AddNewMovie();
                    break;
                case "2":
                    RemoveMovie();
                    break;
                case "3":
                    SeeAllMovies();
                    break;
            }
        }

        public void RemoveMovie()
        {
            SeeAllMovies();

            Console.WriteLine("What movie would you like to remove? Please enter a name: ");
            string title = Console.ReadLine();

            _streamingRepo.RemoveStreamingContentFromList(title);

            SeeAllMovies();
        }

        public void SeeAllMovies()
        {
            List<StreamingContent> contentList = _streamingRepo.GetStreamingContentList();
           
            foreach(StreamingContent movie in contentList)
            {
                Console.WriteLine($"{movie.Title}, Run Time: {movie.RunTime}, Rating: {movie.MovieRating}, \n" +
                    $"Star Rating: {movie.StarRating}\n" +
                    $"Family Friendly: {movie.IsFamilyFriendly}\n" +
                    $"Genre: {movie.Genre}\n" +
                    $"Summary: {movie.Summary}\n");
            }
            Console.WriteLine("Please hit any key to continue... ");
            Console.ReadKey();
        }

        private void AddNewMovie() //Tile, SarRating, RunTime, Summary, IsFamilyFriendly
        {
            Console.WriteLine("Title of movie: ");
            string title = Console.ReadLine();

            Console.WriteLine("Runtime: ");
            string runTime = Console.ReadLine();
            float runTimeParsed = float.Parse(runTime);

            Console.WriteLine("What would you rate this movie?");
            string userRating = Console.ReadLine();
            int starRating = int.Parse(userRating);

            Console.WriteLine("Please describe the movie: ");
            string summary = Console.ReadLine();

            Console.WriteLine("Is the movie family friendly? true or false");
            string familyFriendlyAsString = Console.ReadLine();
            bool isFamilyFriendly = bool.Parse(familyFriendlyAsString);

            Console.WriteLine("What is the official movie rating? e.g. G, PG, PG-13, R");
            string movieRating = Console.ReadLine();

            Console.WriteLine("What is genre?\n" +
                "1. Drama\n" +
                "2. Action\n" +
                "3. Horror\n" +
                "4. Comedy\n" +
                "5. Documentary\n" +
                "6. RomCom\n" +
                "7. Indie\n" +
                "8. Science Fiction");
            string genreAsString = Console.ReadLine();
            int genreAsInt = int.Parse(genreAsString);

            GenreType genre = (GenreType)genreAsInt;

            StreamingContent movie = new StreamingContent(title, starRating, runTimeParsed, summary, isFamilyFriendly, movieRating, genre);

            _streamingRepo.AddToList(movie);
        }
    }
}