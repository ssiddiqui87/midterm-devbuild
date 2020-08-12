using System;
using System.Collections.Generic;
using System.Text;

namespace Midterm
{
    public class Movie
    {
        private string movieName;
        private string mainActor;
        private string genre;
        private string directorName;
        private int criticScore;
        private int runtime;
        private List<Movie> movies = new List<Movie>();

        public string MovieName { get => movieName; set => movieName = value; }
        public string MainActor { get => mainActor; set => mainActor = value; }
        public string Genre { get => genre; set => genre = value; }
        public string DirectorName { get => directorName; set => directorName = value; }
        public int CriticScore { get => criticScore; set => criticScore = value; }
        public int Runtime { get => runtime; set => runtime = value; }
        public List<Movie> Movies { get => movies; set => movies = value; }

        public Movie(string movieName, string mainActor, string genre, string directorName, int criticScore, int runtime)
        {
            this.movieName = movieName;
            this.mainActor = mainActor;
            this.genre = genre;
            this.directorName = directorName;
            this.criticScore = criticScore;
            this.runtime = runtime;
        }

        public Movie()
        {
        }

        //******************* Display Movies *******************//
        public void ListMovies()
        {
            foreach (Movie movie in movies)
            {
                Console.WriteLine(movie);
            }
        }
        public void ListMovies(List<Movie> movieList)
        {
            if (movieList.Count < 1)
            {
                Console.WriteLine("No results found!");
            }
            else
            {
                foreach (Movie movie in movieList)
                {
                    Console.WriteLine(movie);
                }
            }
        }
        public void ListMovies(int index)
        {
            Console.WriteLine(movies[index]);
        }

        public static bool RunAgain(string message)
        {
            Console.Write(message);
            char key = Console.ReadKey().KeyChar;

            while (key != 'y' && key != 'Y')
            {
                if (key == 'n' || key == 'N')
                {
                    Console.WriteLine();
                    return false;
                }
                else
                {
                    Console.Write("\nThat is an invalid entry. Please enter y or n: ");
                    key = Console.ReadKey().KeyChar;
                }
            }

            return true;
        }

        //******************* Add Movie *******************//
        public List<Movie> AddMovie(string movie, string actor, string genre, string director, int criticScore, int runtime)
        {

            movies.Add(new Movie(movie, actor, genre, director, criticScore, runtime));
            return movies;
        }

        //******************* Searching *******************//
        public List<Movie> SearchActor(string actor)
        {
            List<Movie> searchResults = new List<Movie>();
            foreach (Movie m in movies)
            {
                if (m.mainActor.ToLower().Contains(actor.ToLower()))
                {
                    searchResults.Add(m);
                }
            }
            return searchResults;
        }
        public List<Movie> SearchDirector(string director)
        {
            List<Movie> searchResults = new List<Movie>();
            foreach (Movie m in movies)
            {
                if (m.directorName.ToLower().Contains(director.ToLower()))
                {
                    searchResults.Add(m);
                }
            }
            return searchResults;
        }
        public List<Movie> SearchGenre(string genre)
        {
            List<Movie> searchResults = new List<Movie>();
            foreach (Movie m in movies)
            {
                if (m.genre.ToLower().Contains(genre.ToLower()))
                {
                    searchResults.Add(m);
                }
            }
            return searchResults;
        }
        public List<Movie> SearchTitle(string title)
        {
            List<Movie> searchResults = new List<Movie>();
            foreach (Movie m in movies)
            {
                if (m.movieName.ToLower().Contains(title.ToLower()))
                {
                    searchResults.Add(m);
                }

            }
            return searchResults;
        }
        public List<Movie> SearchScore(int score)
        {
            List<Movie> searchResults = new List<Movie>();
            foreach (Movie m in movies)
            {
                if (m.criticScore >= score)
                {
                    searchResults.Add(m);
                }

            }
            return searchResults;
        }
        public List<Movie> SearchRuntimeGreater(int runtime)
        {
            List<Movie> searchResults = new List<Movie>();
            foreach (Movie m in movies)
            {
                if (m.runtime >= runtime)
                {
                    searchResults.Add(m);
                }

            }
            return searchResults;
        }
        public List<Movie> SearchRuntimeLess(int runtime)
        {
            List<Movie> searchResults = new List<Movie>();
            foreach (Movie m in movies)
            {
                if (m.runtime <= runtime)
                {
                    searchResults.Add(m);
                }

            }
            return searchResults;
        }

        //******************* Modifying *******************//

        public List<Movie> ModifyMovieName(List<Movie> movieList, int movieIndex, string newName)
        {
            movieList[movieIndex].movieName = newName;
            return movieList;
        }
        public List<Movie> ModifyMovieGenre(List<Movie> movieList, int movieIndex, string newGenre)
        {
            movieList[movieIndex].genre = newGenre;
            return movieList;
        }
        public List<Movie> ModifyMovieActor(List<Movie> movieList, int movieIndex, string newActor)
        {
            movieList[movieIndex].mainActor = newActor;
            return movieList;
        }
        public List<Movie> ModifyMovieDirector(List<Movie> movieList, int movieIndex, string newName)
        {
            movieList[movieIndex].directorName = newName;
            return movieList;
        }
        public List<Movie> ModifyMovieScore(List<Movie> movieList, int movieIndex, int newScore)
        {
            movieList[movieIndex].CriticScore = newScore;
            return movieList;
        }
        public List<Movie> ModifyMovieRuntime(List<Movie> movieList, int movieIndex, int newRuntime)
        {
            movieList[movieIndex].runtime = newRuntime;
            return movieList;
        }
        public void ModifyMovie(string input)
        {
            for (int i = 0; i < movies.Count; i++)
            {
                if (movies[i].movieName == input)
                {
                    Console.Write("Do you want to modify the 1) Movie name, 2) Main actor, 3) Genre, or 4) Director? ");
                    int num = int.Parse(Console.ReadLine());

                    string newUpdate;
                    if (num == 1)
                    {
                        Console.Write($"The movie name is currently {movies[i].movieName}. What would you like to change it to? ");
                        newUpdate = Console.ReadLine();
                        movies[i].movieName = newUpdate;

                    }
                    else if (num == 2)
                    {
                        Console.WriteLine($"The main actor is currently {movies[i].mainActor}. What would you like to change it to? ");
                        newUpdate = Console.ReadLine();
                        movies[i].mainActor = newUpdate;
                    }
                    else if (num == 3)
                    {
                        Console.WriteLine($"The genre is currently {movies[i].genre}. What would you like to change it to? ");
                        newUpdate = Console.ReadLine();
                        movies[i].genre = newUpdate;
                    }
                    else if (num == 4)
                    {
                        Console.WriteLine($"The director is currently {movies[i].directorName}. What would you like to change it to? ");
                        newUpdate = Console.ReadLine();
                        movies[i].directorName = newUpdate;
                    }
                    else
                    {
                        Console.WriteLine("That is not a valid entry.");
                    }
                }
            }
        }

        //******************* Removing *******************//
        public List<Movie> RemoveMovie(int input)
        {
            movies.RemoveAt(input);
            return movies;
        }

        //******************* Sorting *******************//
        public void SortByActor(List<Movie> movies)
        {
            movies.Sort((movie1, movie2) => movie1.MainActor.CompareTo(movie2.MainActor));
        }
        public void SortByTitle(List<Movie> movies)
        {
            movies.Sort((movie1, movie2) => movie1.MovieName.CompareTo(movie2.MovieName));
        }
        public void SortByDirector(List<Movie> movies)
        {
            movies.Sort((movie1, movie2) => movie1.DirectorName.CompareTo(movie2.DirectorName));
        }
        public void SortByGenre(List<Movie> movies)
        {
            movies.Sort((movie1, movie2) => movie1.Genre.CompareTo(movie2.Genre));
        }
        public void SortByScore(List<Movie> movies)
        {
            movies.Sort((movie1, movie2) => movie1.CriticScore.CompareTo(movie2.CriticScore));
        }
        public void SortByRuntime(List<Movie> movies)
        {
            movies.Sort((movie1, movie2) => movie1.Runtime.CompareTo(movie2.Runtime));
        }
        //Descending sort
        public void SortByActorDescending(List<Movie> movies)
        {
            movies.Sort((movie1, movie2) => movie2.MainActor.CompareTo(movie1.MainActor));
        }
        public void SortByTitleDescending(List<Movie> movies)
        {
            movies.Sort((movie1, movie2) => movie2.MovieName.CompareTo(movie1.MovieName));
        }
        public void SortByDirectorDescending(List<Movie> movies)
        {
            movies.Sort((movie1, movie2) => movie2.DirectorName.CompareTo(movie1.DirectorName));
        }
        public void SortByGenreDescending(List<Movie> movies)
        {
            movies.Sort((movie1, movie2) => movie2.Genre.CompareTo(movie1.Genre));
        }
        public void SortByScoreDescending(List<Movie> movies)
        {
            movies.Sort((movie1, movie2) => movie2.CriticScore.CompareTo(movie1.CriticScore));
        }
        public void SortByRuntimeDescending(List<Movie> movies)
        {
            movies.Sort((movie1, movie2) => movie2.Runtime.CompareTo(movie1.Runtime));
        }

        //******************* Convert to hours *******************//
        public TimeSpan ConvertToHours(int runtime)
        {
            TimeSpan hours = TimeSpan.FromMinutes(runtime);
            return hours;
        }

        //******************* Overrides *******************//
        public override string ToString()
        {
            return $"Movie name: {movieName.PadRight(40)}Main actor: {mainActor}" +
                $"\nGenre: {genre.PadRight(45)}Director name: {directorName}" +
                $"\nCritic score: {criticScore}%{"".PadRight(35)}" +
                $"Runtime: {$"{ConvertToHours(runtime).Hours}h {ConvertToHours(runtime).Minutes}m\n---------------------------------------------------------------------------------------------------"}";
        }
    }
}