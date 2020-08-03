using System.Collections.Generic;

namespace UniversityReg.Models
{
  public class Student
  {
    public Student()
    {
      this.Courses = new HashSet<CourseStudent>();
    }
    public int StudentId {get; set; }
    public string Name { get; set;}
    public ICollection<CourseStudent> Courses {get;} 
  }
}