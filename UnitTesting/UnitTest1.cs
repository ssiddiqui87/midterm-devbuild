using System;
using System.Collections.Generic;
using Xunit;
using Midterm;

namespace UnitTesting
{
    public class UnitTest1
    {
        [Fact]
        public void InstantiationTest()
        {
            Movie movie = new Movie();
        }

        [Fact]
        public void AddMovie_Constructor_Test()
        {
            Movie movie = new Movie("The Martian", "Matt Damon", "Sci-Fi", "Ridley Scott", 91, 151);

            string resultMovie = movie.MovieName;
            string resultActor = movie.MainActor;
            string resultGenre = movie.Genre;
            string resultDirector = movie.DirectorName;
            int resultScore = movie.CriticScore;
            int resultRuntime = movie.Runtime;

            Assert.Equal("The Martian", resultMovie);
            Assert.Equal("Matt Damon", resultActor);
            Assert.Equal("Sci-Fi", resultGenre);
            Assert.Equal("Ridley Scott", resultDirector);
            Assert.Equal(91, resultScore);
            Assert.Equal(151, resultRuntime);

        }

        [Fact]
        public void AddMovie_Method_Test()
        {
            Movie movie = new Movie();
            movie.AddMovie("The Martian", "Matt Damon", "Sci-Fi", "Ridley Scott", 91, 151);

            List<Movie> movieList = movie.Movies;
            string resultMovie = movieList[0].MovieName;
            string resultActor = movieList[0].MainActor;
            string resultGenre = movieList[0].Genre;
            string resultDirector = movieList[0].DirectorName;
            int resultScore = movieList[0].CriticScore;
            int resultRuntime = movieList[0].Runtime;

            Assert.Equal("The Martian", resultMovie);
            Assert.Equal("Matt Damon", resultActor);
            Assert.Equal("Sci-Fi", resultGenre);
            Assert.Equal("Ridley Scott", resultDirector);
            Assert.Equal(91, resultScore);
            Assert.Equal(151, resultRuntime);
        }

        [Fact]
        public void SearchMovie_ByActor_Test()
        {
            Movie movie = new Movie();
            movie.AddMovie("The Martian", "Matt Damon", "Sci-Fi", "Ridley Scott", 91, 151);
            movie.AddMovie("Bourne Identity", "Matt Damon", "Action", "Doug Liman", 83, 119);
            List<Movie> expected = movie.Movies;
            List<Movie> result = movie.SearchActor("Matt Damon");

            Assert.Equal(expected, result);
        }
        [Fact]
        public void SearchMovie_ByDirector_Test()
        {
            Movie movie = new Movie();
            movie.AddMovie("The Martian", "Matt Damon", "Sci-Fi", "Ridley Scott", 91, 151);
            movie.AddMovie("Gladiator", "Russell Crowe", "Action", "Ridley Scott", 76, 171);
            List<Movie> expected = movie.Movies;
            List<Movie> result = movie.SearchDirector("Ridley Scott");

            Assert.Equal(expected, result);
        }

        [Fact]
        public void SearchMovie_ByGenre_Test()
        {
            Movie movie = new Movie();
            movie.AddMovie("The Martian", "Matt Damon", "Sci-Fi", "Ridley Scott", 91, 151);
            movie.AddMovie("Interstellar", "Matthew McConaughey", "Sci-Fi", "Christopher Nolan", 72, 169);
            List<Movie> expected = movie.Movies;
            List<Movie> result = movie.SearchGenre("Sci-Fi");

            Assert.Equal(expected, result);
        }
        [Fact]
        public void SearchMovie_ByTitle_Test()
        {
            Movie movie = new Movie();
            movie.AddMovie("The Martian", "Matt Damon", "Sci-Fi", "Ridley Scott", 91, 151);
            List<Movie> expected = movie.Movies;
            List<Movie> result = movie.SearchTitle("The Martian");

            Assert.Equal(expected, result);
        }

        [Fact]
        public void SearchMovie_ByScore_Test()
        {
            Movie movie = new Movie();
            movie.AddMovie("The Martian", "Matt Damon", "Sci-Fi", "Ridley Scott", 91, 151);
            List<Movie> expected = movie.Movies;
            List<Movie> result = movie.SearchScore(90);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void SearchMovie_RunTime_Greater_Test()
        {
            Movie movie = new Movie();
            movie.AddMovie("The Martian", "Matt Damon", "Sci-Fi", "Ridley Scott", 91, 151);
            movie.AddMovie("Bourne Identity", "Matt Damon", "Action", "Doug Liman", 83, 119);
            int expected = 1;
            List<Movie> result = movie.SearchRuntimeGreater(120);

            Assert.Equal(expected, result.Count);
        }

        [Fact]
        public void SearchMovie_RunTime_Less_Test()
        {
            Movie movie = new Movie();
            movie.AddMovie("The Martian", "Matt Damon", "Sci-Fi", "Ridley Scott", 91, 151);
            movie.AddMovie("Bourne Identity", "Matt Damon", "Action", "Doug Liman", 83, 119);
            movie.AddMovie("Gladiator", "Russell Crowe", "Action", "Ridley Scott", 76, 171);
            int expected = 2;
            List<Movie> result = movie.SearchRuntimeLess(160);

            Assert.Equal(expected, result.Count);
        }

        [Fact]
        public void ModifyMovie_MovieName_Test()
        {
            Movie movieCorrectName = new Movie();
            movieCorrectName.AddMovie("The Martian", "Matt Damon", "Sci-Fi", "Ridley Scott", 91, 151);

            Movie movieWrongName = new Movie();
            movieWrongName.AddMovie("The Bartian", "Matt Damon", "Sci-Fi", "Ridley Scott", 91, 151);

            List<Movie> listWrongName = movieWrongName.Movies;
            listWrongName = movieWrongName.ModifyMovieName(listWrongName, 0, "The Martian");

            List<Movie> listCorrectName = movieCorrectName.Movies;

            var expected = listCorrectName[0].MovieName;
            var result = listWrongName[0].MovieName;

            Assert.Equal(expected, result);
        }
        [Fact]
        public void ModifyMovie_ActorName_Test()
        {
            Movie actorCorrectName = new Movie();
            actorCorrectName.AddMovie("The Martian", "Matt Damon", "Sci-Fi", "Ridley Scott", 91, 151);

            Movie actorWrongName = new Movie();
            actorWrongName.AddMovie("The Martian", "Matt Daymen", "Sci-Fi", "Ridley Scott", 91, 151);

            List<Movie> listWrongName = actorWrongName.Movies;
            listWrongName = actorWrongName.ModifyMovieActor(listWrongName, 0, "Matt Damon");

            List<Movie> listCorrectName = actorCorrectName.Movies;

            var expected = listCorrectName[0].MainActor;
            var result = listWrongName[0].MainActor;

            Assert.Equal(expected, result);
        }

        [Fact]
        public void ModifyMovie_Genre_Test()
        {
            Movie genreCorrect = new Movie();
            genreCorrect.AddMovie("The Martian", "Matt Damon", "Sci-Fi", "Ridley Scott", 91, 151);

            Movie genreWrong = new Movie();
            genreWrong.AddMovie("The Martian", "Matt Damon", "Comedy", "Ridley Scott", 91, 151);

            List<Movie> listWrongGenre = genreWrong.Movies;
            listWrongGenre = genreWrong.ModifyMovieGenre(listWrongGenre, 0, "Sci-Fi");

            List<Movie> listCorrectGenre = genreCorrect.Movies;

            var expected = listCorrectGenre[0].Genre;
            var result = listWrongGenre[0].Genre;

            Assert.Equal(expected, result);
        }

        [Fact]
        public void ModifyMovie_Director_Test()
        {
            Movie directorCorrect = new Movie();
            directorCorrect.AddMovie("The Martian", "Matt Damon", "Sci-Fi", "Ridley Scott", 91, 151);

            Movie directorWrong = new Movie();
            directorWrong.AddMovie("The Martian", "Matt Damon", "Sci-Fi", "Christopher Nolan", 91, 151);

            List<Movie> listWrongDirector = directorWrong.Movies;
            listWrongDirector = directorWrong.ModifyMovieDirector(listWrongDirector, 0, "Ridley Scott");

            List<Movie> listCorrectDirector = directorCorrect.Movies;

            var expected = listCorrectDirector[0].DirectorName;
            var result = listWrongDirector[0].DirectorName;

            Assert.Equal(expected, result);
        }

        [Fact]
        public void ModifyMovie_Score_Test()
        {
            Movie scoreCorrect = new Movie();
            scoreCorrect.AddMovie("The Martian", "Matt Damon", "Sci-Fi", "Ridley Scott", 91, 151);

            Movie scoreWrong = new Movie();
            scoreWrong.AddMovie("The Martian", "Matt Damon", "Sci-Fi", "Ridley Scott", 19, 151);

            List<Movie> listWrongScore = scoreWrong.Movies;
            listWrongScore = scoreWrong.ModifyMovieScore(listWrongScore, 0, 91);

            List<Movie> listCorrectScore = scoreCorrect.Movies;

            var expected = listCorrectScore[0].CriticScore;
            var result = listWrongScore[0].CriticScore;

            Assert.Equal(expected, result);
        }
        [Fact]
        public void ModifyMovie_Runtime_Test()
        {
            Movie timeCorrect = new Movie();
            timeCorrect.AddMovie("The Martian", "Matt Damon", "Sci-Fi", "Ridley Scott", 91, 151);

            Movie timeWrong = new Movie();
            timeWrong.AddMovie("The Martian", "Matt Damon", "Sci-Fi", "Ridley Scott", 91, 152);

            List<Movie> listWrongTime = timeWrong.Movies;
            listWrongTime = timeWrong.ModifyMovieRuntime(listWrongTime, 0, 151);

            List<Movie> listCorrectTime = timeCorrect.Movies;

            var expected = listCorrectTime[0].Runtime;
            var result = listWrongTime[0].Runtime;

            Assert.Equal(expected, result);
        }
        [Fact]
        public void RemoveMovieTest()
        {
            Movie movie = new Movie();
            movie.AddMovie("The Martian", "Matt Damon", "Sci-Fi", "Ridley Scott", 91, 151);
            movie.AddMovie("Interstellar", "Matthew McConaughey", "Sci-Fi", "Christopher Nolan", 72, 169);
            movie.AddMovie("Mission Impossible", "Tom Cruise", "Action", "Brian De Palma", 63, 110);

            List<Movie> result = movie.Movies;
            Assert.Equal(3, result.Count);

            result = movie.RemoveMovie(1);
            Assert.Equal(2, result.Count);
        }
        [Fact]
        public void SortActorTest()
        {

            Movie unsorted = new Movie();
            List<Movie> movieList = unsorted.Movies;
            unsorted.AddMovie("Mission Impossible", "Tom Cruise", "Action", "Brian De Palma", 63, 110);
            unsorted.AddMovie("The Martian", "Matt Damon", "Sci-Fi", "Ridley Scott", 91, 151);
            unsorted.AddMovie("Bourne Identity", "Matt Damon", "Action", "Doug Liman", 83, 119);
            unsorted.AddMovie("Interstellar", "Matthew McConaughey", "Sci-Fi", "Christopher Nolan", 72, 169);

            Assert.Equal("Tom Cruise", unsorted.Movies[0].MainActor);
            Assert.Equal("Matthew McConaughey", unsorted.Movies[3].MainActor);

            unsorted.SortByActor(movieList);

            Assert.Equal("Matt Damon", unsorted.Movies[0].MainActor);
            Assert.Equal("Tom Cruise", unsorted.Movies[3].MainActor);

        }
        [Fact]
        public void SortTitleTest()
        {
            Movie unsorted = new Movie();
            List<Movie> movieList = unsorted.Movies;
            unsorted.AddMovie("The Martian", "Matt Damon", "Sci-Fi", "Ridley Scott", 91, 151);
            unsorted.AddMovie("Bourne Identity", "Matt Damon", "Action", "Doug Liman", 83, 119);
            unsorted.AddMovie("Mission Impossible", "Tom Cruise", "Action", "Brian De Palma", 63, 110);
            unsorted.AddMovie("Interstellar", "Matthew McConaughey", "Sci-Fi", "Christopher Nolan", 72, 169);

            unsorted.SortByTitle(unsorted.Movies);

            Assert.Equal("Bourne Identity", unsorted.Movies[0].MovieName);
            Assert.Equal("The Martian", unsorted.Movies[3].MovieName);
        }
        [Fact]
        public void SortDirectorTest()
        {
            Movie unsorted = new Movie();

            unsorted.AddMovie("The Martian", "Matt Damon", "Sci-Fi", "Ridley Scott", 91, 151);
            unsorted.AddMovie("Bourne Identity", "Matt Damon", "Action", "Doug Liman", 83, 119);
            unsorted.AddMovie("Mission Impossible", "Tom Cruise", "Action", "Brian De Palma", 63, 110);
            unsorted.AddMovie("Interstellar", "Matthew McConaughey", "Sci-Fi", "Christopher Nolan", 72, 169);

            unsorted.SortByDirector(unsorted.Movies);

            Assert.Equal("Brian De Palma", unsorted.Movies[0].DirectorName);
            Assert.Equal("Ridley Scott", unsorted.Movies[3].DirectorName);
        }
        [Fact]
        public void SortGenreTest()
        {
            Movie unsorted = new Movie();
            unsorted.AddMovie("The Martian", "Matt Damon", "Sci-Fi", "Ridley Scott", 91, 151);
            unsorted.AddMovie("Bourne Identity", "Matt Damon", "Action", "Doug Liman", 83, 119);
            unsorted.AddMovie("Interstellar", "Matthew McConaughey", "Sci-Fi", "Christopher Nolan", 72, 169);
            unsorted.AddMovie("Mission Impossible", "Tom Cruise", "Action", "Brian De Palma", 63, 110);

            unsorted.SortByGenre(unsorted.Movies);

            Assert.Equal("Action", unsorted.Movies[0].Genre);
            Assert.Equal("Sci-Fi", unsorted.Movies[3].Genre);
        }
        [Fact]
        public void SortScoreTest()
        {
            Movie unsorted = new Movie();
            unsorted.AddMovie("Bourne Identity", "Matt Damon", "Action", "Doug Liman", 83, 119);
            unsorted.AddMovie("The Martian", "Matt Damon", "Sci-Fi", "Ridley Scott", 91, 151);
            unsorted.AddMovie("Interstellar", "Matthew McConaughey", "Sci-Fi", "Christopher Nolan", 91, 169);
            unsorted.AddMovie("Mission Impossible", "Tom Cruise", "Action", "Brian De Palma", 63, 110);

            unsorted.SortByScore(unsorted.Movies);

            Assert.Equal(63, unsorted.Movies[0].CriticScore);
            Assert.Equal(91, unsorted.Movies[3].CriticScore);
        }
        [Fact]
        public void SortRuntimeTest()
        {
            Movie unsorted = new Movie();
            unsorted.AddMovie("Bourne Identity", "Matt Damon", "Action", "Doug Liman", 83, 119);
            unsorted.AddMovie("The Martian", "Matt Damon", "Sci-Fi", "Ridley Scott", 91, 151);
            unsorted.AddMovie("Interstellar", "Matthew McConaughey", "Sci-Fi", "Christopher Nolan", 91, 169);
            unsorted.AddMovie("Mission Impossible", "Tom Cruise", "Action", "Brian De Palma", 63, 110);

            unsorted.SortByRuntime(unsorted.Movies);

            Assert.Equal(110, unsorted.Movies[0].Runtime);
            Assert.Equal(169, unsorted.Movies[3].Runtime);
        }

        [Fact]
        public void SortActor_Descending_Test()
        {
            Movie unsorted = new Movie();

            unsorted.AddMovie("Mission Impossible", "Tom Cruise", "Action", "Brian De Palma", 63, 110);
            unsorted.AddMovie("The Martian", "Matt Damon", "Sci-Fi", "Ridley Scott", 91, 151);
            unsorted.AddMovie("Bourne Identity", "Matt Damon", "Action", "Doug Liman", 83, 119);
            unsorted.AddMovie("Interstellar", "Matthew McConaughey", "Sci-Fi", "Christopher Nolan", 72, 169);

            Assert.Equal("Tom Cruise", unsorted.Movies[0].MainActor);
            Assert.Equal("Matthew McConaughey", unsorted.Movies[3].MainActor);

            unsorted.SortByActorDescending(unsorted.Movies);

            Assert.Equal("Tom Cruise", unsorted.Movies[0].MainActor);
            Assert.Equal("Matt Damon", unsorted.Movies[3].MainActor);

        }
        [Fact]
        public void SortTitle_Descending_Test()
        {
            Movie unsorted = new Movie();
            unsorted.AddMovie("The Martian", "Matt Damon", "Sci-Fi", "Ridley Scott", 91, 151);
            unsorted.AddMovie("Bourne Identity", "Matt Damon", "Action", "Doug Liman", 83, 119);
            unsorted.AddMovie("Mission Impossible", "Tom Cruise", "Action", "Brian De Palma", 63, 110);
            unsorted.AddMovie("Interstellar", "Matthew McConaughey", "Sci-Fi", "Christopher Nolan", 72, 169);

            unsorted.SortByTitleDescending(unsorted.Movies);

            Assert.Equal("The Martian", unsorted.Movies[0].MovieName);
            Assert.Equal("Bourne Identity", unsorted.Movies[3].MovieName);
        }
        [Fact]
        public void SortDirector_Descending_Test()
        {
            Movie unsorted = new Movie();
            unsorted.AddMovie("The Martian", "Matt Damon", "Sci-Fi", "Ridley Scott", 91, 151);
            unsorted.AddMovie("Bourne Identity", "Matt Damon", "Action", "Doug Liman", 83, 119);
            unsorted.AddMovie("Mission Impossible", "Tom Cruise", "Action", "Brian De Palma", 63, 110);
            unsorted.AddMovie("Interstellar", "Matthew McConaughey", "Sci-Fi", "Christopher Nolan", 72, 169);

            unsorted.SortByDirectorDescending(unsorted.Movies);

            Assert.Equal("Ridley Scott", unsorted.Movies[0].DirectorName);
            Assert.Equal("Brian De Palma", unsorted.Movies[3].DirectorName);
        }
        [Fact]
        public void SortGenre_Descending_Test()
        {
            Movie unsorted = new Movie();
            unsorted.AddMovie("The Martian", "Matt Damon", "Sci-Fi", "Ridley Scott", 91, 151);
            unsorted.AddMovie("Bourne Identity", "Matt Damon", "Action", "Doug Liman", 83, 119);
            unsorted.AddMovie("Interstellar", "Matthew McConaughey", "Sci-Fi", "Christopher Nolan", 72, 169);
            unsorted.AddMovie("Mission Impossible", "Tom Cruise", "Action", "Brian De Palma", 63, 110);

            unsorted.SortByGenreDescending(unsorted.Movies);

            Assert.Equal("Sci-Fi", unsorted.Movies[0].Genre);
            Assert.Equal("Action", unsorted.Movies[3].Genre);
        }
        [Fact]
        public void SortScore_Descending_Test()
        {
            Movie unsorted = new Movie();
            unsorted.AddMovie("Bourne Identity", "Matt Damon", "Action", "Doug Liman", 83, 119);
            unsorted.AddMovie("The Martian", "Matt Damon", "Sci-Fi", "Ridley Scott", 91, 151);
            unsorted.AddMovie("Interstellar", "Matthew McConaughey", "Sci-Fi", "Christopher Nolan", 73, 169);
            unsorted.AddMovie("Mission Impossible", "Tom Cruise", "Action", "Brian De Palma", 63, 110);

            unsorted.SortByScoreDescending(unsorted.Movies);

            Assert.Equal(91, unsorted.Movies[0].CriticScore);
            Assert.Equal(63, unsorted.Movies[3].CriticScore);
        }
        [Fact]
        public void SortRuntime_Descending_Test()
        {
            Movie unsorted = new Movie();
            unsorted.AddMovie("Bourne Identity", "Matt Damon", "Action", "Doug Liman", 83, 119);
            unsorted.AddMovie("The Martian", "Matt Damon", "Sci-Fi", "Ridley Scott", 91, 151);
            unsorted.AddMovie("Interstellar", "Matthew McConaughey", "Sci-Fi", "Christopher Nolan", 91, 169);
            unsorted.AddMovie("Mission Impossible", "Tom Cruise", "Action", "Brian De Palma", 63, 110);

            unsorted.SortByRuntimeDescending(unsorted.Movies);

            Assert.Equal(169, unsorted.Movies[0].Runtime);
            Assert.Equal(110, unsorted.Movies[3].Runtime);
        }
    }
}