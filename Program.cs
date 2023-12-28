using System;
using System.Linq;

namespace CsharpAdvanced_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] premiers = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };
            int[] impairs = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };

            Console.WriteLine("----------");
            Console.WriteLine("----------");
            var union = premiers.Union(impairs);
            foreach (int nb in union)
            {
                Console.WriteLine(nb);
            }
            Console.WriteLine("----------Union");

            // Union
            var unionQuery = (from premier in premiers
                              where premier > 5
                              select premier)
                             .Union(from impair in impairs
                                    where impair < 15
                                    select impair);

            // Même chose mais écrite différement : 
            var unionBis = premiers.Where(nb => nb > 5)
                .Union(impairs.Where(nb => nb < 15));


            foreach (int nb in unionQuery)
            {
                Console.WriteLine(nb);
            }
            Console.WriteLine("----------UnionBis");

            foreach (int nb in unionBis)
            {
                Console.WriteLine(nb);
            }
            Console.WriteLine("============Concatenation");

            // Concatenation
            var concat = premiers.Concat(impairs);
            foreach (int nb in concat)
            {
                Console.WriteLine(nb);
            }
            Console.WriteLine("============Intersection");

            // Intersection (apparait uniquement dans les 2 tableaux)
            var intersect = premiers.Intersect(impairs);
            foreach (int nb in intersect)
            {
                Console.WriteLine(nb);
            }
            Console.WriteLine("============Exception");

            // Exception (ou Différence)
            var except = premiers.Except(impairs);
            foreach (int nb in except)
            {
                Console.WriteLine(nb);
            }
            Console.WriteLine("============ExceptionBis");

            var exceptbis = impairs.Except(premiers);
            foreach (int nb in exceptbis)
            {
                Console.WriteLine(nb);
            }
            Console.WriteLine("============Fin");
            Console.WriteLine("============Fin");
        }
    }
}