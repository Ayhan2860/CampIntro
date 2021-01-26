using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Ayhan";
            //int age = 33;
            Course course1 = new Course();
            course1.CourseName = "C#";
            course1.Instructor = "Engin Demiroğ";
            course1.WhatchingRate = 100;


            Course course2 = new Course();
            course2.CourseName = "Java";
            course2.Instructor = "Kerem Varış";
            course2.WhatchingRate = 90;


            Course course3 = new Course();
            course3.CourseName = "Python";
            course3.Instructor = "Berkay Bilgin";
            course3.WhatchingRate = 88;


            Course course4 = new Course();
            course4.CourseName = "C++";
            course4.Instructor = "Murat Kurtboğan";
            course4.WhatchingRate = 100;

            Course[] courses = new Course[] { course1, course2, course3, course4 };

            foreach (Course course in courses)
            {
                Console.WriteLine("Kurs Adı : " + course.CourseName);
                Console.WriteLine("Eğitmen : " + course.Instructor);
                Console.WriteLine("İzlenme Oranı : " + course.WhatchingRate + "\n");
            }
        }
    }

    class Course
    {
        public int WhatchingRate { get; set; }

        public string CourseName { get; set; }

        public string Instructor { get; set; }
    }
}
