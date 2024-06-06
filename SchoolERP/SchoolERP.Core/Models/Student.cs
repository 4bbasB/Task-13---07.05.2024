using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolERP.Core.Models
{
    public class Student : BaseModel
    {
        public string Fullname { get; set; }
        public double Grade { get; set; }

        public Teacher Teacher { get; set; }
    }
}
