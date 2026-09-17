using System;
using System.Collections.Generic;

public class Student
{
    public string Name;
    public List<Course> Courses;

    public Student(string name)
    {
        Name = name;
        Courses = new List<Course>();
    }

    // Går med i en kurs från studentens sida
    public void Join(Course course)
    {
        course.Enroll(this); // Anropar kursens Enroll-metod
    }

    // Lämnar en kurs från studentens sida
    public void Leave(Course course)
    {
        course.Remove(this); // Anropar kursens Remove-metod
    }

    // Skriver ut studentens schema
    public void Schedule()
    {
        Console.WriteLine($"Schema för {Name}:");
        foreach (Course c in Courses)
        {
            Console.WriteLine(c.Name);
        }
    }

    public override string ToString()
    {
        return Name;
    }
}
