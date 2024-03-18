using Students.Implementations;
using System.Text;

namespace Groups.Implementions;

public class GroupManagerEntity
{
    private GroupEntity group = new();
    public TeacherEntity Curator { get => group.Curator; }
    public string GroupName { get => group.GroupName; set => group.GroupName = value; }

    public void ChangeCurator(in TeacherEntity new_cur)
    {
        group.Curator = new_cur;
    }

    public void AddStudent(in StudentEntity st)
    {
        group.Students.Add(st);
    }

    public void AddSubject(in SubjectEntity sub)
    {
        group.Subjects.Add(sub);
    }

    public double GetAverageGrade()
    {
        double avg = 0.0;
        int count = 0;
        foreach (StudentEntity student in group.Students)
        {
            avg += student.AverageGrade;
            count++;
        }
        if (count > 0)
            return avg / count;
        else
            return 0;
    }

    public override string? ToString()
    {
        if (Curator is null || String.IsNullOrEmpty(Curator.Name) || this.group.Students is null || this.group.Students.Count == 0 || String.IsNullOrEmpty(this.GroupName))
            return null;
        StringBuilder str_b = new(GroupName);
        str_b.Append("\n---\n" + "Curator: " + Curator.Name + "\n---\n--Students:--\n");
        foreach (StudentEntity st in this.group.Students)
            str_b.Append(st.Name + "\n");
        return str_b.ToString();
    }

}