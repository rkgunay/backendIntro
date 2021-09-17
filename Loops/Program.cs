using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] courses = new string[] 
            {
                "Software developer course",
                "Starting programming course",
                "Java course", "Python"
            };
            string endOfPage = "End of Page";
            string endOfFor = "End of For";
            for (int i = 0; i < courses.Length; i++)
            {
                Console.WriteLine(courses[i]);
            }

            Console.WriteLine(endOfFor);

            foreach (var course in courses)
            {
                Console.WriteLine(course);
            }

            Console.WriteLine(endOfPage);

        


        }
    }
}
