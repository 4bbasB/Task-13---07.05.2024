using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolERP.Core.Models
{
    public class Teacher : BaseModel
    {
        public string Fullname { get; set; }
        public double Salary { get; set; }

        public List<Student> Students = new List<Student>();
    }
}
