using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_IO
{
    class Employees
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string gender { get; set; }
        public double salary { get; set; }

        public Employees()
        {
            firstName = string.Empty;
            lastName = string.Empty;
            email = string.Empty;
            gender = string.Empty;
            salary = 0;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
