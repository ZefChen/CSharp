using System;
namespace Assignment4OOP.School
{
    public interface IDepartmentService
    {
        string head();
        decimal Budget();
        List<Course> Courses();
    }
}

