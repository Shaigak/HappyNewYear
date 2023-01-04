using ServiceLayer.Services;
using ServiceLayer.Services.Interaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYearTasks.Controllers
{
    public class StudentController
    {
        private readonly IStudentService _services;

        public StudentController()
        {
            _services = new StudentService();
        }
        public void GetCountStudents() => Console.WriteLine(_services.GetCountStudents());
        public void GetAverageStudents() => Console.WriteLine(_services.GetAverageStudents());
        public void GetStudentEmails()
        {
            var result = _services.GetStudentEmails("S");
            foreach (var item in result)
            {
                if (item != null)
                {
                    Console.WriteLine($"{item.Id} {item.Name} {item.Surname} {item.Email} {item.Age} {item.Address} {item.Education}");
                }
            }
        }
        public void GetStudentsAddress()
        {
            var result = _services.GetStudentsAddress("Balaxani");
            foreach (var item in result)
            {
                if (item != null)
                {
                    Console.WriteLine($"{item.Id} {item.Name} {item.Surname} {item.Email} {item.Age} {item.Address} {item.Education}");
                }
            }
        }
        public void Search()
        {
            Console.WriteLine("Ad daxil edin");
            string name = Console.ReadLine();

            Console.WriteLine("Soyad daxil edin");
            string surname = Console.ReadLine();

            Console.WriteLine(_services.SearchFullName(name, surname));
        }

        public void SearchName()
        {
            var result = _services.SearchName("Saiq");
            foreach (var item in result)
            {
                if (item != null)
                {
                    Console.WriteLine($"{item.Id} {item.Name} {item.Surname} {item.Email} {item.Age} {item.Address} {item.Education}");
                }
            }

        }

        public void SearchSomeNameArr()
        {
            Console.WriteLine("Ad daxil et");
            string name = Console.ReadLine();
              
            Console.WriteLine($"{_services.SearchSomeNameArr(name)}");
        }
    }
}
