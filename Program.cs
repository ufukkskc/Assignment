using System;

namespace EFCodeFirstStudentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchoolContext())
            {
                var student = new Student
                {
                    FirstName = "Jane",
                    LastName = "Doe",
                    EnrollmentDate = DateTime.Now
                };

                context.Students.Add(student);
                context.SaveChanges();

                Console.WriteLine("Student added successfully!");
            }

            Console.ReadKey();
        }
    }
}
