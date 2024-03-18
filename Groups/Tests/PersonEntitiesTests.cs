using NUnit.Framework;

using Groups.Implementions;
using Students.Implementations;

namespace Groups.Tests
{
    [TestFixture]
    public class PersonEntitiesTests
    {
        [TestCase("Testname", 30)]
        public void TestPersonFeatures(in string name, int age)
        {
            PersonEntity my_p = new() { Name = name, Age = age };
            bool ch = my_p.Name == name && my_p.Age == age;
            Assert.That(ch, Is.True);
        }
        [TestCase("Testname", 30, 5)]
        public void TestTeacherFeatures(in string name, int age, int work_exp)
        {
            TeacherEntity my_t = new() { Name = name, Age = age, WorkExperience = work_exp };
            bool ch = my_t.Name == name && my_t.Age == age && my_t.WorkExperience == work_exp;
            Assert.That(ch, Is.True);
        }
        [TestCase("Testname", 30, 4.5)]
        public void TestStudentFeatures(in string name, int age, double avg_grade)
        {
            StudentEntity my_st = new() { Name = name, Age = age, AverageGrade = avg_grade };
            bool ch = my_st.Name == name && my_st.Age == age && my_st.AverageGrade == avg_grade;
            Assert.That(ch, Is.True);
        }
    }
}
