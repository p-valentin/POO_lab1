//GitHub CoPilot C# console app example
using System;
using System.Collections.Generic;

namespace SampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            Student student = new Student();
            student.firstName = Console.ReadLine();
            student.lastName = Console.ReadLine();
            student.registrationNumber = Console.ReadLine();
            student.year = int.Parse(Console.ReadLine());
            student.disciplines = new List<Disciplina>();
            Disciplina disciplina = new Disciplina();
            disciplina.name = Console.ReadLine();
            disciplina.code = Console.ReadLine();
            student.disciplines.Add(disciplina);
            students.Add(student);

            foreach (Student st in students)
            {
                Console.WriteLine($"{st.firstName}\n" +
                                  $"{st.lastName}\n" +
                                  $"{st.registrationNumber}\n" +
                                  $"{st.year}\n"
                                  );
                foreach (Disciplina d in st.disciplines)
                {
                    Console.WriteLine($"{d.name}" +
                                      $"{d.code}");
                }
            }
        }
    }
}