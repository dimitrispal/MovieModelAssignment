using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace MovieModelAssignment2
{
    class Program
    {
        #region Class <=
        class Movies
        {
            public string Actor { get; set; }
            public string Title { get; set; }
            public string Reviews { get; set; }
            public int Rating { get; set; }
            public int Income { get; set; }
        }
        #endregion
        #region Main <=
        public static void Main(string[] args)
        {


            #region Arrays <=
            int[] array0;
            array0 = new int[10];
            array0[0] = 1;
            array0[1] = 2;
            array0[2] = 3;
            array0[3] = 4;
            array0[4] = 5;
            array0[5] = 6;
            array0[6] = 7;
            array0[7] = 8;
            array0[8] = 9;
            array0[9] = 10;

            Random randomk0 = new Random();
            int noumero0 = randomk0.Next(array0.Length);



            int[] array1;
            array1 = new int[10];
            array1[0] = 1;
            array1[1] = 2;
            array1[2] = 3;
            array1[3] = 4;
            array1[4] = 5;
            array1[5] = 6;
            array1[6] = 7;
            array1[7] = 8;
            array1[8] = 9;
            array1[9] = 10;

            Random randomk1 = new Random();
            int noumero1 = randomk1.Next(array1.Length);

            int[] array2;
            array2 = new int[10];
            array2[0] = 1;
            array2[1] = 2;
            array2[2] = 3;
            array2[3] = 4;
            array2[4] = 5;
            array2[5] = 6;
            array2[6] = 7;
            array2[7] = 8;
            array2[8] = 9;
            array2[9] = 10;

            Random randomk2 = new Random();
            int noumero2 = randomk2.Next(1, 10);

            #endregion

            #region List <=
            List<Movies> myMovies = new List<Movies>() {
                new Movies() { Actor="|Actor: Adam Sidler|", Title= "|Title: Smoke On The Mountain|", Reviews= "|Reviews:| So much smoke...", Rating=noumero0, Income=20009},
                new Movies() { Actor="|Actor: Leo Nightmen|", Title="|Title: Blade Runner|", Reviews="|Reviews:| Amazing!", Rating=noumero1, Income=2010},
                new Movies() { Actor="|Actor: Kaisa Moaren|", Title="|Title: Divide|", Reviews = "|Reviews:| And conquer ha!", Rating=noumero2, Income=2008},
                new Movies() { Actor="|Actor: Roody Charls|", Title="|Title: Inferno|", Reviews="|Reviews:| Scary af.", Rating=1, Income=2008},
                new Movies() { Actor="|Actor: Ben Dawn|",     Title="|Title: De Dust|", Reviews="|Reviews:| Solid film.", Rating=2, Income=2010},
                new Movies() { Actor="|Actor: Jules Moon|",  Title= "|Title: Live|", Reviews= "|Reviews:| Cool.", Rating=3, Income=20009},
                new Movies() { Actor="|Actor: Leo Nightmen|", Title="|Title: Blade Runner|", Reviews="|Reviews:| Amazing!", Rating=6, Income=2010},
                new Movies() { Actor="|Actor: Kaisa Moaren|", Title="|Title: Divide|", Reviews = "|Reviews:| And conquer ha!", Rating=5, Income=2008},
                new Movies() { Actor="|Actor: Roody Charls|", Title="|Title: Inferno|", Reviews="|Reviews:| Scary af.", Rating=7, Income=2008},
                new Movies() { Actor="|Actor: Ben Dawn|",     Title="|Title: De Dust|", Reviews="|Reviews:| Solid film.", Rating=1, Income=2010}
            };

            #endregion

            #region Sort'em <=
            var reqMovies = from car in myMovies
                            orderby car.Rating descending
                            select car;


            #endregion

            //Print'em <=

            foreach (var car in reqMovies)
            {
                Console.WriteLine("{0} {1} {2} {3} {4}", car.Actor, car.Title, car.Income, car.Reviews, car.Rating);
            }
            Console.ReadLine();

        }
        #endregion
    }
}

