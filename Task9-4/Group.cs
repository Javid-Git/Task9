using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9_4
{
    class Group 
    {
        public double No;
        public int Limit;
        public Student[] Students = new Student[0];
        
        public void AddStudent(Student student)
        {
            if (Students.Length < Limit)
            {
                for (int i = Students.Length; i < Limit;)
                { 
                    Array.Resize(ref Students, Students.Length + 1);    
                    Students[i] = student;
                    break;
                }
            }
            else
            {
                Console.WriteLine($"Maksimum elave oluna bilecek telebe sayi: {Limit} denedir");
            }
        }

        public void GetStudent()
        {
            foreach  (Student item in Students)
            {
                Console.WriteLine($"\nAd ve Soyad: {item.Name} {item.Surname}\n");
            }
        }

    }
}
