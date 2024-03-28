using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassY
{
    public class Program
    {
        static void Main(string[] args)
        {
            Exam exam1 = new Exam("Riyaziyyat", 78);
            Exam exam2 = new Exam("Fizika", 85);
            Exam exam3 = new Exam("Kimya", 57);
            Exam exam4 = new Exam("Biologiya", 95);
            Exam exam5 = new Exam("Tarix", 88);

            
             



            Student[] students = {
            new Student("Ali", "Aliyev", "Mühendislik", 95,73),
            new Student("Ayse", "Memmedli", "Muhendislik", 93, 75),
            new Student("Mehemmed", "Cavadov", "Ekologiya", 89, 45),
            };

            foreach (var student in students)
            {
                student.CheckExam();
                student.StudentInfo();
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
