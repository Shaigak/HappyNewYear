using DomainLayer.Models;
using ServiceLayer.Helpers;
using ServiceLayer.Services.Interaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class StudentService : IStudentService
    {
        public float GetAverageStudents()
        {
            Student[] students = GetAll();
            int result = 0;
            foreach (var item in students)
            {
                result += item.Age;

            }
            return result/ students.Length; 
        }

        public int GetCountStudents()
        {
            Student[] students = GetAll();
            int count = 0;
            foreach (var item in students)
            {
                count++;
            }
            return count;
        }

        public Student[] GetStudentEmails(string m)
        {
            Student[] students = GetAll();
            Student[] result=new Student[students.Length];
            int count = 0;
            bool check = false;
            foreach (var item in students)
            {
                if (m == item.Email.Substring(0, 1))
                {
                    result[count] = item;
                    count++;
                    check = true;

                }
                
            }
            if (!check)
            {
                Console.WriteLine(Errors.ErrorEmail);
            }
            return result;
           
        }

        public Student[] GetStudentsAddress(string text)
        {
            Student[] students= GetAll();
            Student[] result=new Student[students.Length];
            int count = 0;
            bool check = false;
            foreach (var item in students)
            {
                if (item.Address == text)
                {
                    result[count] = item;
                    count++;
                    check = true;
                }
                if (!check)
                {
                    
                }
             
            }
            Console.WriteLine(Errors.ErrorAddress);
            return result;
        }

        private Student[] GetAll()
        {
            Student c1 = new Student
            {
                Id = 1,
                Name = "Shaiq",
                Surname = "Kazimov",
                Age = 25,
                Address = "Sedmoy",
                Education = "Bachelor",
                Email = "Shaiq@code.edu.az"
            };
            Student c2 = new Student
            {
                Id = 2,
                Name = "Pervin",
                Surname = "Rehimli",
                Age = 25,
                Address = "Sumqayit",
                Education = "Bachelor",
                Email = "Pervin@code.edu.az"
            };
            Student c3 = new Student
            {
                Id = 3,
                Name = "Aqshin",
                Surname = "Hummetov",
                Age = 27,
                Address = "Xirdalan",
                Education = "Bachelor",
                Email = "Aqshin@code.edu.az"
            };
            Student c4 = new Student
            {
                Id = 4,
                Name = "Jale",
                Surname = "Abdullayeva",
                Age = 18,
                Address = "Hokmeli",
                Education = "Bachelor",
                Email = "Jale@code.edu.az"
            };
            Student[] students = { c1, c2, c3, c4 };
            return students;
        }

        public string SearchFullName(string name,string surname)
        {
            var result = GetAll();
            foreach (var item in result)
            {
               if(item.Name == name && item.Surname == surname)
                {
                    return ($"{item.Id} {item.Name} {item.Surname} {item.Email} {item.Age} {item.Address} {item.Education}");
                }
            }
            return Errors.ErrorFulName;
        }

        public Student[] SearchName(string name)
        {
           Student[] students = GetAll();
            Student[] result = new Student[students.Length];
            int count = 0;
            bool check = false;
            foreach (var item in students)
            {
                if (item.Name == name)
                {
                    result[count] = item;
                    count++;
                    check = true;
                }
                if (!check)
                {
                    
                }                
            }
            Console.WriteLine(Errors.ErrorName);
            return result;
        }

        public int SearchSomeNameArr(string name)
        {
           int count = 0;
            foreach (var item in GetAll())
            {
                if (item.Name.ToLower() == name.ToLower())
                {
                    count++;
                }
            }
            return count;
        }
        
    }
}

    
    
   