using System.Collections.Generic;
using System;
namespace GradeBook
{
  class Book 
  {
    List<double> grades;
    string name;
    public Book(string name)
    {
      this.name = name;
      grades = new List<double>();
    }
    public void Add(double grade)
    {
      grades.Add(grade);
    }

    public double Average()
    {
      return grades.AddRange / grades.Count;
    }

    public double Max()
    {
      grades.Sort();
      return grades[-1];
    }

    public double Min()
    {
      grades.Sort();
      return grades[0];
    }
  }
}