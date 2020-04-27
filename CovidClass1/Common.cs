using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidClass1
{
    public class Common
    {
        
        public string Name { get; set; }
        public string Location { get; set; }
        public string Category { get; set; }
        public string Gender { get; set; }
        public string DisplayGender { get; set; }
    }
    public class Mentors
    {
        public List<Mentor> MentorsList = new List<Mentor>();
    }

    public class Mentor : Common
    {
        public int YearsOfExperience { get; set; }
    }
}
