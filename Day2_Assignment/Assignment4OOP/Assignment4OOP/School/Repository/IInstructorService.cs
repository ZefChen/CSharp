using System;
namespace Assignment4OOP.School
{
    public interface IInstructorService : IPersonService<Instructor>
    {
        string Department();
        bool IfHead();
        decimal BonusSalary();
    }
}

