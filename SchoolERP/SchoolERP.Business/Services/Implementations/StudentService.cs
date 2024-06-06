using SchoolERP.Business.Services.Interfaces;
using SchoolERP.Core.Models;
using SchoolERP.Data.DAL;

namespace SchoolERP.Business.Services.Implementations
{
    public class StudentService : IStudentService
    {
        public void Create(Student student)
        {
            SchoolERPDatabase.Students.Add(student);
        }

        public List<Student> GetAll()
        {
            return SchoolERPDatabase.Students;
        }

        public Student GetById(int id)
        {
            Student? wantedStudent = SchoolERPDatabase.Students.Find(x => x.Id == id);

            if (wantedStudent is null)
                throw new NullReferenceException("Student not found!");
                
            return wantedStudent;

        }

        public void Remove(int id)
        {
            Student? wantedStudent = SchoolERPDatabase.Students.Find(x => x.Id == id);

            if (wantedStudent is  null)
                throw new NullReferenceException("Student not found!");
            
            SchoolERPDatabase.Students.Remove(wantedStudent);
        }
    }
}
