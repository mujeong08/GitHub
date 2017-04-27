using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Overlord
    {
        public void OvlDemo()
        {
            Console.WriteLine("No parameters");
        }
        public void OvlDemo(int a)
        {
            Console.WriteLine("One parameter: " + a);
        }
        public int OvlDemo(int a, int b)
        {
            Console.WriteLine("Two parameters: " + a + " " + b);
            return a + b;
        }
        public double OvlDemo(double a, double b)
        {
            Console.Write("Two double parameters:" + a + "" + b);
            return a + b;
        }
    }
    class OverLoadDemo
    {
        private static string item;

        static void Main()
        {
            Overlord ob = new Overlord();
            int resl;
            double resD;

            ob.OvlDemo();
            Console.WriteLine();

            ob.OvlDemo(2);
            Console.WriteLine();

            resl = ob.OvlDemo(4, 6);
            Console.WriteLine("result of ob.OvlDemo(4,6):" + resl);
            Console.WriteLine();

            resD = ob.OvlDemo(1.1, 2.32);
            Console.WriteLine("result of ob.OvlDemo(1.1, 2.2):" + resD);

            // Specify the data source.
            int[] scores = new int[] { 97, 60, 92, 81, 99 };

            // Define the query expression.
            IEnumerable<int> scoreQuery =
                from score in scores
                where score > 80
                select score;
            int scoreCount = scoreQuery.Count();

            // Execute the query.
            foreach (int i in scoreQuery)
            {
                Console.Write(+i + " ");
            }
            Console.WriteLine("Count is " + scoreCount);

            // Data source.
            int[] scores2 = { 90, 71, 82, 93, 75, 82 };

            // Query Expression.
            IEnumerable<int> scoreQuery2 = //query variable
                from score2 in scores2 //required
                where score2 > 80 // optional
                orderby score2 descending // optional
                select score2; //must end with select or group

            // Execute the query to produce the results
            foreach (int testScore in scoreQuery2)
            {
                Console.WriteLine(testScore);
            }
            Console.Write("==================================================================");
            // Query #1.
            List<int> numbers = new List<int>() { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            // The query variable can also be implicitly typed by using var
            //IEnumerable<int> filteringQuery =
            //    from num in numbers
            //    where num < 3 || num > 7
            //    select num;
            //Console.WriteLine(filteringQuery);

            //// Query #2.
            //IEnumerable<int> orderingQuery =
            //    from num in numbers
            //    where num < 3 || num > 7
            //    orderby num ascending
            //    select num;
            //Console.Write(orderingQuery);

            // Query #3.
            string[] groupingQuery = { "carrots", "cabbage", "broccoli", "beans", "barley" };
            IEnumerable<IGrouping<char, string>> queryFoodGroups =
                from item in groupingQuery
                group item by item[0];
            Console.Write(item);
        }
    }
}
