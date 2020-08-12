using System;
using System.Collections.Generic;

namespace Midterm
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie movie = new Movie();
            movie.AddMovie("Knives Out", "Daniel Craig", "Comedy", "Rian Johnson", 97, 116);
            movie.AddMovie("The Martian", "Matt Damon", "Sci-Fi", "Ridley Scott", 91, 151);
            movie.AddMovie("Bourne Identity", "Matt Damon", "Action", "Doug Liman", 82, 119);
            movie.AddMovie("Shrek", "Mike Myers", "Animated", "Andrew Adamson", 88, 90);
            movie.AddMovie("Get Out", "Daniel Kaluuya", "Thriller", "Jordan Peele", 98, 104);
            movie.AddMovie("Interstellar", "Matthew McConaughey", "Sci-Fi", "Christopher Nolan", 71, 169);
            movie.AddMovie("A Quiet Place", "Emily Blunt", "Horror", "John Krasinski", 95, 90);
            movie.AddMovie("Spider-Man: Homecoming", "Tom Holland", "Action", "John Watts", 92, 133);
            movie.AddMovie("Baby Driver", "Ansel Elgort", "Action", "Edgar Wright", 93, 118);
            movie.AddMovie("21 Jump Street", "Jonah Hill", "Comedy", "Phil Lord", 85, 109);
            movie.AddMovie("Captain America: The Winter Soldier", "Chris Evans", "Action", "Anthony Russo/Joe Russo", 90, 135);
            movie.AddMovie("Zombieland", "Jesse Eisenberg", "Adventure", "Ruben Fleischer", 90, 87);
            movie.AddMovie("Crazy Rich Asians", "Constance Wu", "Comedy", "Jon M. Chu", 91, 120);
            movie.AddMovie("Ankerman", "Will Ferrell", "Comedy", "Adam McKay", 66, 104);

            Menu.MainMenu(movie);
            Console.WriteLine();
            Console.WriteLine("░██████╗░░█████╗░░█████╗░██████╗░  ██████╗░██╗░░░██╗███████╗██╗");
            Console.WriteLine("██╔════╝░██╔══██╗██╔══██╗██╔══██╗  ██╔══██╗╚██╗░██╔╝██╔════╝██║");
            Console.WriteLine("██║░░██╗░██║░░██║██║░░██║██║░░██║  ██████╦╝░╚████╔╝░█████╗░░██║");
            Console.WriteLine("██║░░╚██╗██║░░██║██║░░██║██║░░██║  ██╔══██╗░░╚██╔╝░░██╔══╝░░╚═╝");
            Console.WriteLine("╚██████╔╝╚█████╔╝╚█████╔╝██████╔╝  ██████╦╝░░░██║░░░███████╗██╗");
            Console.WriteLine("░╚═════╝░░╚════╝░░╚════╝░╚═════╝░  ╚═════╝░░░░╚═╝░░░╚══════╝╚═╝");

        }
    }
}