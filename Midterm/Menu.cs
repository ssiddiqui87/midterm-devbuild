using System;
using System.Collections.Generic;
using System.Text;

namespace Midterm
{
    class Menu
    {
        //******************* Main Menu *******************//
        public static void MainMenu(Movie movie)
        {
            bool flag = true;
            while (flag == true)
            {
                Console.Clear();
                Console.WriteLine("░██████╗░█████╗░███╗░░░███╗███████╗███████╗██████╗░██╗░██████╗  ███╗░░░███╗░█████╗░██╗░░░██╗██╗███████╗");
                Console.WriteLine("██╔════╝██╔══██╗████╗░████║██╔════╝██╔════╝██╔══██╗╚█║██╔════╝  ████╗░████║██╔══██╗██║░░░██║██║██╔════╝");
                Console.WriteLine("╚█████╗░███████║██╔████╔██║█████╗░░█████╗░░██████╔╝░╚╝╚█████╗░  ██╔████╔██║██║░░██║╚██╗░██╔╝██║█████╗░░");
                Console.WriteLine("░╚═══██╗██╔══██║██║╚██╔╝██║██╔══╝░░██╔══╝░░██╔══██╗░░░░╚═══██╗  ██║╚██╔╝██║██║░░██║░╚████╔╝░██║██╔══╝░░");
                Console.WriteLine("██████╔╝██║░░██║██║░╚═╝░██║███████╗███████╗██║░░██║░░░██████╔╝  ██║░╚═╝░██║╚█████╔╝░░╚██╔╝░░██║███████╗");
                Console.WriteLine("╚═════╝░╚═╝░░╚═╝╚═╝░░░░░╚═╝╚══════╝╚══════╝╚═╝░░╚═╝░░░╚═════╝░  ╚═╝░░░░░╚═╝░╚════╝░░░░╚═╝░░░╚═╝╚══════╝");
                Console.WriteLine("");
                Console.WriteLine("██████╗░░█████╗░████████╗░█████╗░██████╗░░█████╗░░██████╗███████╗██╗");
                Console.WriteLine("██╔══██╗██╔══██╗╚══██╔══╝██╔══██╗██╔══██╗██╔══██╗██╔════╝██╔════╝██║");
                Console.WriteLine("██║░░██║███████║░░░██║░░░███████║██████╦╝███████║╚█████╗░█████╗░░██║");
                Console.WriteLine("██║░░██║██╔══██║░░░██║░░░██╔══██║██╔══██╗██╔══██║░╚═══██╗██╔══╝░░╚═╝");
                Console.WriteLine("██████╔╝██║░░██║░░░██║░░░██║░░██║██████╦╝██║░░██║██████╔╝███████╗██╗");
                Console.WriteLine("╚═════╝░╚═╝░░╚═╝░░░╚═╝░░░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░╚══════╝╚═╝");
                Console.WriteLine("\nPlease select from the following." +
                    "\n1. List all movies" +
                    "\n2. Add a movie" +
                    "\n3. Search" +
                    "\n4. Modify" +
                    "\n5. Sort" +
                    "\n6. Remove a movie" +
                    "\n7. Exit");
                int switchCase = GetInt("Enter choice here: ");
                while (switchCase < 1 || switchCase > 8)
                {
                    Console.WriteLine("That is not a valid entry.");
                    Console.WriteLine("Welcome to Sameer's Movie Database! Please select from the following." +
                        "\n1. List all movies" +
                        "\n2. Add a movie" +
                        "\n3. Search" +
                        "\n4. Modify" +
                        "\n5. Sort" +
                        "\n6. Remove a movie" +
                        "\n7. Exit");
                    switchCase = GetInt("Enter choice here: ");
                    Console.Clear();
                }
                switch (switchCase)
                {

                    case 1:
                        Console.Clear();
                        Console.WriteLine("---------------------------------------------------------------------------------------------------");
                        Console.WriteLine("------------------------------------   LIST OF MOVIES   -------------------------------------------");
                        Console.WriteLine("---------------------------------------------------------------------------------------------------");

                        movie.ListMovies();
                        break;
                    case 2:
                        string movieName = GetString("Movie name: ");
                        string actor = GetString("Main actor: ");
                        string genre = GetString("Genre: ");
                        string director = GetString("Director: ");
                        int score = GetInt("Critic score: ");
                        int runtime = GetInt("Runtime (in minutes): ");
                        movie.AddMovie(movieName, actor, genre, director, score, runtime);
                        break;
                    case 3:
                        SearchMenu(movie);
                        break;
                    case 4:
                        ModifyMenu(movie);
                        break;
                    case 5:
                        SortMenu(movie);
                        break;
                    case 6:
                        ListMovies(movie);
                        int movieIndex = GetInt("What movie would you like to remove?: ");
                        movieIndex -= 1;
                        movie.RemoveMovie(movieIndex);
                        break;
                    default:
                        return;

                }
                if (flag == true)
                {
                    flag = Movie.RunAgain("Do you want to continue? y/n: ");
                }
            }

        }

        //******************* Search Menu *******************//
        public static void SearchMenu(Movie movie)
        {
            Console.Clear();
            Console.WriteLine("What would you like to search?" +
                "\n1. Search by movie name" +
                "\n2. Search by main actor" +
                "\n3. Search by genre" +
                "\n4. Search by director" +
                "\n5. Search by critic score" +
                "\n6. Search by movies less than entered runtime" +
                "\n7. Search by movies greater than entered runtime" +
                "\n8. Go back");
            int switchCase = GetInt("Enter choice here: ");
            while (switchCase < 1 || switchCase > 8)
            {
                Console.WriteLine("That is not a valid entry.");
                Console.WriteLine("What would you like to search?" +
                 "\n1. Search by movie name" +
                 "\n2. Search by main actor" +
                 "\n3. Search by genre" +
                 "\n4. Search by director" +
                 "\n5. Search by critic score" +
                 "\n6. Search by movies less than entered runtime" +
                 "\n7. Search by movies greater than entered runtime" +
                 "\n8. Go back");
                switchCase = GetInt("Enter choice here: ");
                Console.Clear();
            }
            switch (switchCase)
            {

                case 1:
                    string movieSearch = GetString("What title do you want to search? ");
                    List<Movie> searchMovie = movie.SearchTitle(movieSearch);
                    movie.ListMovies(searchMovie);

                    break;
                case 2:
                    string actorSearch = GetString("What actor do you want to search? ");
                    List<Movie> searchActor = movie.SearchActor(actorSearch);
                    movie.ListMovies(searchActor);
                    break;
                case 3:
                    string genreSearch = GetString("What genre do you want to search? ");
                    List<Movie> searchGenre = movie.SearchGenre(genreSearch);
                    movie.ListMovies(searchGenre);
                    break;
                case 4:
                    string directorSearch = GetString("What director do you want to search? ");
                    List<Movie> searchDirector = movie.SearchDirector(directorSearch);
                    movie.ListMovies(searchDirector);
                    break;
                case 5:
                    int scoreSearch = GetInt("Enter minimum critic score: ");
                    List<Movie> searchScore = movie.SearchScore(scoreSearch);
                    movie.ListMovies(searchScore);
                    break;
                case 6:
                    int timeSearch = GetInt("Enter maximum runtime in minutes (ex: 151): ");
                    Console.WriteLine($"Search results for movies {movie.ConvertToHours(timeSearch).Hours}h {movie.ConvertToHours(timeSearch).Minutes}m or less");
                    List<Movie> searchTime = movie.SearchRuntimeLess(timeSearch);
                    movie.ListMovies(searchTime);
                    break;
                case 7:
                    int timeSearchGreater = GetInt("Enter minimum runtime in minutes (ex: 151): ");
                    Console.WriteLine($"Search results for movies {movie.ConvertToHours(timeSearchGreater).Hours}h {movie.ConvertToHours(timeSearchGreater).Minutes}m or more");
                    List<Movie> searchTimeGreater = movie.SearchRuntimeGreater(timeSearchGreater);
                    movie.ListMovies(searchTimeGreater);
                    break;
                default:
                    MainMenu(movie);
                    break;
            }
        }

        //******************* Modify Menu *******************//
        public static void ModifyMenu(Movie movie)
        {
            List<Movie> movieList = movie.Movies;
            ListMovies(movie);
            int movieIndex = GetInt("What movie would you like to update? ");
            movieIndex -= 1;
            Console.WriteLine("What would you like to modify?" +
                "\n1. Movie title" +
                "\n2. Director" +
                "\n3. Main Actor" +
                "\n4. Genre" +
                "\n5. Critic Score" +
                "\n6. Runtime" +
                "\n7. Go back");
            int switchCase = GetInt("Enter choice here: ");
            while (switchCase < 1 || switchCase > 7)
            {
                Console.WriteLine("That is not a valid entry.");
                Console.WriteLine("What would you like to modify?" +
                    "\n1. Movie title" +
                    "\n2. Director" +
                    "\n3. Main Actor" +
                    "\n4. Genre" +
                    "\n5. Critic Score" +
                    "\n6. Runtime" +
                    "\n7. Go back");
                switchCase = GetInt("Enter choice here: ");
                Console.Clear();
            }
            switch (switchCase)
            {
                case 1:
                    string newName = GetString("What do you want to update the movie name to? ");
                    movie.ModifyMovieName(movieList, movieIndex, newName);
                    movie.ListMovies(movieIndex);
                    break;
                case 2:
                    string newDirector = GetString("What do you want to update the director's name to? ");
                    movie.ModifyMovieDirector(movieList, movieIndex, newDirector);
                    movie.ListMovies(movieIndex);
                    break;
                case 3:
                    string newActor = GetString("What do you want to update the main actor's name to? ");
                    movie.ModifyMovieActor(movieList, movieIndex, newActor);
                    movie.ListMovies(movieIndex);
                    break;
                case 4:
                    string newGenre = GetString("What do you want to update the genre to? ");
                    movie.ModifyMovieGenre(movieList, movieIndex, newGenre);
                    movie.ListMovies(movieIndex);
                    break;
                case 5:
                    int newScore = GetInt("What do you want to update the score to? ");
                    movie.ModifyMovieScore(movieList, movieIndex, newScore);
                    movie.ListMovies(movieIndex);
                    break;
                case 6:
                    int newRuntime = GetInt("What do you want to update the runtime to in minutes (ex: 151)? ");
                    movie.ModifyMovieScore(movieList, movieIndex, newRuntime);
                    movie.ListMovies(movieIndex);
                    break;
                default:
                    break;
            }

        }

        //******************* Sort Menu *******************//
        public static void SortMenu(Movie movie)
        {
            int sortMethod = GetInt("How do you want to sort?\n1. Ascending\n2. Descending\nEnter choice here: ");
            while (sortMethod < 1 && sortMethod > 2)
            {
                Console.WriteLine("That is not a valid choice.");
                sortMethod = GetInt("How do you want to sort?\n1. Ascending\n2. Descending\nEnter choice here: ");
            }

            if (sortMethod == 1)
            {
                SortMenuAscending(movie);
            }
            else
            {
                SortMenuDescending(movie);
            }
        }
        public static void SortMenuAscending(Movie movie)
        {
            List<Movie> movieList = movie.Movies;
            Console.Clear();
            Console.WriteLine("What would you like to sort in ascending order?" +
                "\n1. Movie title" +
                "\n2. Director" +
                "\n3. Main Actor" +
                "\n4. Genre" +
                "\n5. Critic Score" +
                "\n6. Runtime" +
                "\n7. Go back");
            int switchCase = GetInt("Enter choice here: ");
            while (switchCase < 1 || switchCase > 7)
            {
                Console.WriteLine("That is not a valid entry.");
                Console.WriteLine("What would you like to sort in ascending order?" +
                    "\n1. Movie title" +
                    "\n2. Director" +
                    "\n3. Main Actor" +
                    "\n4. Genre" +
                    "\n5. Critic Score" +
                    "\n6. Runtime" +
                    "\n7. Go back");
                switchCase = GetInt("Enter choice here: ");
                Console.Clear();
            }
            switch (switchCase)
            {
                case 1:
                    movie.SortByTitle(movieList);
                    movie.ListMovies();
                    break;
                case 2:
                    movie.SortByDirector(movieList);
                    movie.ListMovies();
                    break;
                case 3:
                    movie.SortByActor(movieList);
                    movie.ListMovies();
                    break;
                case 4:
                    movie.SortByGenre(movieList);
                    movie.ListMovies();
                    break;
                case 5:
                    movie.SortByScore(movieList);
                    movie.ListMovies();
                    break;
                case 6:
                    movie.SortByRuntime(movieList);
                    movie.ListMovies();
                    break;
                default:
                    break;
            }
        }
        public static void SortMenuDescending(Movie movie)
        {
            List<Movie> movieList = movie.Movies;
            Console.Clear();
            Console.WriteLine("What would you like to sort in ascending order?" +
                "\n1. Movie title" +
                "\n2. Director" +
                "\n3. Main Actor" +
                "\n4. Genre" +
                "\n5. Critic Score" +
                "\n6. Runtime" +
                "\n7. Go back");
            int switchCase = GetInt("Enter choice here: ");
            while (switchCase < 1 || switchCase > 7)
            {
                Console.WriteLine("That is not a valid entry.");
                Console.WriteLine("What would you like to sort in ascending order?" +
                    "\n1. Movie title" +
                    "\n2. Director" +
                    "\n3. Main Actor" +
                    "\n4. Genre" +
                    "\n5. Critic Score" +
                    "\n6. Runtime" +
                    "\n7. Go back");
                switchCase = GetInt("Enter choice here: ");
                Console.Clear();
            }
            switch (switchCase)
            {
                case 1:
                    movie.SortByTitleDescending(movieList);
                    movie.ListMovies();
                    break;
                case 2:
                    movie.SortByDirectorDescending(movieList);
                    movie.ListMovies();
                    break;
                case 3:
                    movie.SortByActorDescending(movieList);
                    movie.ListMovies();
                    break;
                case 4:
                    movie.SortByGenreDescending(movieList);
                    movie.ListMovies();
                    break;
                case 5:
                    movie.SortByScoreDescending(movieList);
                    movie.ListMovies();
                    break;
                case 6:
                    movie.SortByRuntimeDescending(movieList);
                    movie.ListMovies();
                    break;
                default:
                    break;
            }
        }

        //******************* Display movie only *******************//
        public static void ListMovies(Movie movie)
        {
            Console.Clear();
            List<Movie> movieList = movie.Movies;
            for (int i = 0; i < movieList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {movieList[i].MovieName}");
            }
        }

        //******************* Input validation for int *******************//
        public static int GetInt(string input)
        {
            Console.Write(input);

            bool isValid = int.TryParse(Console.ReadLine(), out int userInput);

            while (!isValid)
            {
                Console.Write("That is an invalid entry. Enter an integer: ");
                isValid = int.TryParse(Console.ReadLine(), out userInput);
            }

            return userInput;
        }

        //******************* Get string method *******************//
        public static string GetString(string prompt)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();

            return input;
        }

    }
}
