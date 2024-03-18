using Groups.Implementions;
using NUnit.Framework;
using Students.Implementations;

namespace Groups.Tests
{
    [TestFixture]
    public class TestsGroup
    {
        [Test]
        public void TestGroupCreation()
        {
            GroupManagerEntity my_groupm = new();
            my_groupm.GroupName = "TestName";
            TeacherEntity my_t = new TeacherEntity() { Name = "Testteacher", Age = 30 };
            my_groupm.ChangeCurator(my_t);
            StudentEntity myst = new() { Name = "t1", Age = 15, AverageGrade = 3.7 };
            my_groupm.AddStudent(myst);
            myst = new() { Name = "t2", Age = 14, AverageGrade = 4.0 };
            my_groupm.AddStudent(myst);
            Assert.Pass("No Errors During Creation");
        }

        [Test]
        public void TestGroupAverageGrade()
        {
            GroupManagerEntity my_groupm = new();
            StudentEntity myst = new() { Name = "t1", Age = 15, AverageGrade = 3.5 };
            my_groupm.AddStudent(myst);
            myst = new() { Name = "t2", Age = 14, AverageGrade = 5.0 };
            my_groupm.AddStudent(myst);
            myst = new() { Name = "t3", Age = 14, AverageGrade = 3.0 };
            my_groupm.AddStudent(myst);
            Assert.That(3.83 == Math.Round(my_groupm.GetAverageGrade(), 2));
        }
        [Test]
        public void TestGroupString()
        {
            GroupManagerEntity my_groupm = new();
            my_groupm.GroupName = "TestName";
            TeacherEntity my_t = new TeacherEntity() { Name = "Testteacher", Age = 30 };
            my_groupm.ChangeCurator(my_t);
            StudentEntity myst = new() { Name = "t1", Age = 15, AverageGrade = 3.7 };
            my_groupm.AddStudent(myst);
            myst = new() { Name = "t2", Age = 14, AverageGrade = 4.0 };
            my_groupm.AddStudent(myst);
            string expected_formating = "TestName\n---\nCurator: Testteacher\n---\n--Students:--\nt1\nt2\n";
            Assert.That(my_groupm.ToString() == expected_formating);
        }

        [Test]
        public void TestEmptyGroupString()
        {
            GroupManagerEntity my_groupm = new();
            Assert.That(my_groupm.ToString() is null);
        }
    }
}
