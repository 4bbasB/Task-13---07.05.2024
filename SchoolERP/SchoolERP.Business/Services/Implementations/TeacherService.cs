using SchoolERP.Business.Services.Interfaces;
using SchoolERP.Core.Models;
using SchoolERP.Data.DAL;

namespace SchoolERP.Business.Services.Implementations
{
    public class TeacherService : ITeacherService
    {
        public void Create(Teacher teacher)
        {
            SchoolERPDatabase.Teachers.Add(teacher);
        }

        public List<Teacher> GetAll()
        {
            return SchoolERPDatabase.Teachers;
        }

        public Teacher GetById(int id)
        {
            Teacher? wantedTeacher = SchoolERPDatabase.Teachers.Find(x => x.Id == id);

            if (wantedTeacher is not null)
                return wantedTeacher;

            throw new NullReferenceException("Teacher not found!");
        }

        public void Remove(int id)
        {
            Teacher? wantedTeacher = SchoolERPDatabase.Teachers.Find(x => x.Id == id);

            if (wantedTeacher is not null)
                SchoolERPDatabase.Teachers.Remove(wantedTeacher);
            else
                throw new NullReferenceException("Teacher not found!");


        }

        List<Teacher> ITeacherService.GetAll()
        {
            throw new NotImplementedException();
        }

        Teacher ITeacherService.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
