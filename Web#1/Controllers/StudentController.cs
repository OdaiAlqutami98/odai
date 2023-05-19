using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Eventing.Reader;
using Web_1.Models;


namespace Web_1.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]

    public class StudentController : ControllerBase
    {
        public static List<Student> Studentdatabase = new List<Student>();
        [HttpGet]
        public List<Student> get()
        {
            return Studentdatabase;
        }
        [HttpPost] //added
        public string add(string Name, string Materials, int Marks, double Avarage)
        {
            try
            { 
                Student student = new Student();
                student.NameStudent = "odai";
                student.Materials = "arabic";
                student.Marks = 50;

                if (Marks > 70 & Marks < 90)
                {
                    Console.WriteLine(" Very Good" + " " + student.NameStudent);

                }
                else
                {
                    Console.WriteLine("Exlent" + " " + student.NameStudent);
                }


                Studentdatabase.Add(student);
                return "Student added" + " " + student.NameStudent + " " + student.Marks;
            }
            catch (Exception ex)
            {
                return "Error";
                throw;
            }
        }
        [HttpPut] //added
        public string ubdate(Student student)
        {
            return "Student Update " + " " + student.NameStudent + " " + student.Marks;
        }
        [HttpDelete] 
        public string delete(string name)
        {
            foreach (Student stu in Studentdatabase)
            {
                if (stu.NameStudent == name)
                {
                    Studentdatabase.Remove(stu);
                    break;
                }
            }
            return "Student Deleted !" + " " + name;

        }
    }
}
