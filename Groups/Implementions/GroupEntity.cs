using Groups.Implementions;
using Students.Implementations;

namespace Groups.Implementions;

public class GroupEntity
{
    public string GroupName { get; set; } = String.Empty;
    public List<StudentEntity> Students = new();
    public TeacherEntity Curator { get; set; } = new();
    public List<SubjectEntity> Subjects = new();

}