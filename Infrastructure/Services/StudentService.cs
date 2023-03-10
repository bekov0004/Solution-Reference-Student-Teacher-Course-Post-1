using Domain.Models;

namespace Infrastructure.Services;

public class StudentService
{
    public List<Student> Students;
    public StudentService()
    {  
        Students = new List<Student>();
    }


    public List<Student> GetStudents() 
    { 
        return Students;
    }
    public void AddStudent(Student student)
    {
        Students.Add(student);
    }

    public void UpdateStudent(Student student)
    {
        var find = Students.FirstOrDefault(x=>x.Id == student.Id);
        find.Address = student.Address;
        find.BirthDate = student.BirthDate;
        find.FirstName = student.FirstName;
    }
    public void Delete(int id)
    {
        var find = Students.FirstOrDefault(x=>x.Id == id);
        Students.Remove(find);
    }
}
