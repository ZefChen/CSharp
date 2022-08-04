using System;
namespace Assignment4OOP.School
{
    public interface IStudentService : IPersonService<Student>
    {
        string[] Courses();
        double GPA();
        int Grade();
    }
}

