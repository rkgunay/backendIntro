using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Course course1 = new Course();
            course1.courseName = "Software Development Course";
            course1.courseTeacher = "Rıdvan";
            course1.courseWatchRatings = 35;

            Course course2 = new Course();
            course2.courseName = "C Sharp Course";
            course2.courseTeacher = "Rıdvan";
            course2.courseWatchRatings = 55;

            Course course3 = new Course();
            course3.courseName = "Java Course";
            course3.courseTeacher = "Rıdvan";
            course3.courseWatchRatings = 92;


            //Console.WriteLine(course2.courseName + afterWord + course2.courseTeacher + afterWord + course2.courseWatchRatings);
           
            String seperator = " : ";
            Course[] courses = new Course[] { course1, course2, course3 };

            foreach (var course in courses)
            {
                Console.WriteLine(course.courseName + seperator + course.courseTeacher);
            }
        }
    }

    class Course
    {
        public String courseName { get; set; }
        public String courseTeacher { get; set; }
        public int courseWatchRatings { get; set; }
    }

}
