using System.Collections.Generic;
namespace GradeBook
{
  class Book 
  {
    List<double> grades;
    public void Add(double grade)
    {
      grades.Add(grade);
    }
  }
}