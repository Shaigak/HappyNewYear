using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interaces
{
    public interface IStudentService
    {
        int GetCountStudents();
        float GetAverageStudents();
        Student[] GetStudentEmails(string m);
        Student[] GetStudentsAddress(string text);
        string SearchFullName(string name, string surname);
        Student[] SearchName(string name);
        int SearchSomeNameArr(string name);

    }
}
