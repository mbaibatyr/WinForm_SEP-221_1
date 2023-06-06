using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWPF.Model
{
    public class Student
    {
        public int id { get; set; }
        public string iin { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public DateTime dateBirth { get; set; }
        public string gender { get; set; }

    }
}
