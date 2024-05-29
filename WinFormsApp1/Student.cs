using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    public class Student
    {
        public string FirstName { get; internal set; }
        public string LastName { get; internal set; }
        public string Gender { get; internal set; }
        public string Age { get; internal set; }
        public string Class { get; internal set; }
        public DateTime DateOfBirth { get; set; } = DateTime.Now; // Initialize with a valid date
        public object Address { get; internal set; }
    }
}
