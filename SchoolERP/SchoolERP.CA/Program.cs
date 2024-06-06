using SchoolERP.Business.Services.Implementations;
using SchoolERP.Business.Services.Interfaces;
using SchoolERP.Core.Models;

namespace SchoolERP.CA
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region 1
            //ITeacherService teacherService = new TeacherService();
            //Teacher teacher = new Teacher();
            //teacher.Id = 1;
            //teacher.FullName = "Yusif Guluzada";
            //teacher.Salary = 7500;
            //teacherService.Create(teacher);

            //Teacher teacher2 = new Teacher();
            //teacher2.Id = 2;
            //teacher2.FullName = "Vasif Guluzada";
            //teacher2.Salary = 1500;
            //teacherService.Create(teacher2);

            //teacherService.GetAll().ForEach(teacher => Console.WriteLine(teacher.FullName));

            //Console.WriteLine("After remove");
            //teacherService.Remove(2);
            //teacherService.GetAll().ForEach(teacher => Console.WriteLine(teacher.FullName));


            //Console.WriteLine(teacherService.GetById(1).FullName);

            #endregion



            #region 2

            ITeacherService teacherService = new TeacherService();
            IStudentService studentService = new StudentService();
            teacherService.Create(new Teacher() { Fullname = "Eli Eliyev", Salary = 2600, });
            Teacher teacher = null;
            try
            {
                teacher = teacherService.GetById(1);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine(teacher);


            //try
            //{
            //    teacherService.Remove(1);
            //}
            //catch (NullReferenceException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            Student student = new Student()
            {
                Fullname = "Abbas",
                Grade = 13,
                Teacher = teacher,
            };

            studentService.Create(student);
            studentService.GetAll().ForEach(x => Console.WriteLine(x));

            try
            {
                studentService.Remove(1);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("After Delete");
            studentService.GetAll().ForEach(x => Console.WriteLine(x));

            Console.WriteLine("\n\n");


            teacher.Students.Add(student);
            teacher.Students.ForEach(student => Console.WriteLine(student));


            teacherService.Remove(1);
            Console.WriteLine(student.Teacher.Fullname);
            #endregion





        }
    }
}
