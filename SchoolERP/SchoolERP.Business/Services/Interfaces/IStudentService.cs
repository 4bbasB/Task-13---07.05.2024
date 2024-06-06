using SchoolERP.Core.Models;

namespace SchoolERP.Business.Services.Interfaces
{
    public interface IStudentService
    {
        void Create(Student student);
        List<Student> GetAll();
        Student GetById(int id);
        void Remove(int id);
    }
}
