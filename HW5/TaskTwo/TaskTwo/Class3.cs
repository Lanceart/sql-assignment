using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskTwo;

public class Person: IPersonService
{
    public string Name { get; set; }

    public decimal Salary { get; set; }
    public List<string> Addresses { get; set; } = new List<string>();

    public int Age { get; set; }

    public int CalculateAge()
    {
        return Age;
    }

    public decimal CalculateSalary()
    {
        return Salary;
    }

    public string[] GetAddresses()
    {
        return Addresses.ToArray();
    }
}
   

public class Instructor : Person, IInstructorService
{
    public DateTime JoinDate { get; set; }
    public Department Department { get; set; }
    public decimal Bonus { get; set; }

    public int CalculateExperienceYears(DateTime joinDate)
    {
        return DateTime.Now.Year - joinDate.Year;
    }


    
}

public class Student : Person, IStudentService
{

    public double Gpa {  get; set; }

    public List<Course> Courses { get; set; } = new List<Course>();

    public double CalculateGPA()
    {
        return Gpa;
    }


}

public class Course : ICourseService
{
    public List<Student> EnrolledStudents { get; set; } = new List<Student>();

    public void EnrollStudent(Student student)
    {
        EnrolledStudents.Add(student);
    }

    public List<Student> GetEnrolledStudents()
    {
        return EnrolledStudents;
    }
}

public class Department : IDepartmentService
{
    public Instructor Head { get; set; }
    public decimal Budget { get; set; }
    public List<Course> Courses { get; set; } = new List<Course>();

    public void AssignHead(Instructor head)
    {
        Head = head;
    }

    public void AddCourse(Course course)
    {
        Courses.Add(course);
    }

    public decimal CalculateBudget()
    {
        // Budget calculation logic goes here
        return Budget;
    }
}
