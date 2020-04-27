using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidClass1
{
    class Program
    {
        static void Main(string[] args)
        {
            Mentor mentor1 = new Mentor() {
                Name = "Pascal Ojinnaka",
                Location = "Canada",
                Gender = "Male",
                YearsOfExperience = 4,
                Category = "Programming"
            };
            Mentor mentor2 = new Mentor()
            {
                Name = "Stanley Ojinnaka",
                Location = "Ghana",
                Gender = "Male",
                YearsOfExperience = 5,
                Category = "Data Analyst"
            };
            Mentor mentor3 = new Mentor()
            {
                Name = "Amanda Ojinnaka",
                Location = "USA",
                Gender = "Female",
                YearsOfExperience = 5,
                Category = "Cloud Analyst"
            };

            Mentors listOfMentors = new Mentors();

            listOfMentors.MentorsList.Add(mentor1);
            listOfMentors.MentorsList.Add(mentor2);
            listOfMentors.MentorsList.Add(mentor3);

            foreach (Mentor m in listOfMentors.MentorsList)
            {
                Mentor y = GetGender(m);
                Console.WriteLine($"Our Mentor is {y.Name}, {y.DisplayGender} " +
                    $"lives in {y.Location} and has {y.YearsOfExperience} years of experience in {y.Category} ");
            }

        }

        private static Mentor GetGender(Mentor m)
        {
            if (m.Gender == "Male")
            {
                m.DisplayGender = "He";
            }
            else
            {
                m.DisplayGender = "She";
            }
            return m;
        }

    }
}
