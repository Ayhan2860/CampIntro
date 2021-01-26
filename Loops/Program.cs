using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string course1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string course2 = "Programlamaya Başlamak İçin Temel Kurs";
            string course3 = "Java";
            string course4 = "Python";
            string course5 = "C++";

            Console.WriteLine(course1);
            Console.WriteLine(course2);
            Console.WriteLine(course3);
            Console.WriteLine(course4);
            Console.WriteLine(course5);


            // Arrays - Diziler
            Console.WriteLine("\nArrays - Diziler\n");

            string[] courses = new string[] { "Yazılım Geliştirici Yetiştirme Kampı",
                "Programlamaya Başlamak İçin Temel Kurs", "Java","Python", "C++" };

            Console.WriteLine("For Loop Started\n");

            for (int i = 0; i < courses.Length; i++)
            {
                Console.WriteLine(courses[i]);
            }

            Console.WriteLine("\n Foreach Loop Started\n");

            foreach (var course in courses)
            {
                Console.WriteLine(course);
            }

            Console.WriteLine("\nPage Break - Footer");
        }
    }
}
