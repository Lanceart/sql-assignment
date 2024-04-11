
public interface IPersonService
{
    int CalculateAge();
    decimal CalculateSalary();
    string[] GetAddresses();
}

public interface IStudentService : IPersonService
{
    double CalculateGPA();
}

public interface IInstructorService : IPersonService
{
    int CalculateExperienceYears(DateTime joinDate);
}

public interface ICourseService<T> where T : class
{
    void EnrollStudent(Student student);
    List<Student> GetEnrolledStudents();
}

public interface IDepartmentService<T> where T : class
{
    void AssignHead(Instructor head);
    void AddCourse(Course course);
    decimal CalculateBudget();
}
