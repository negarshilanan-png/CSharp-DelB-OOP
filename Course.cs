using System;
using System.Collections.Generic;

public class Course
{
    public string Name;
    public int MaxSeats;
    public List<Student> Students;

    public Course(string name, int maxSeats)
    {
        Name = name;
        MaxSeats = maxSeats;
        Students = new List<Student>();
    }

    // Metod för att registera en student och kontrollera platser
    public bool Enroll(Student student)
    {
        if (Students.Count < MaxSeats)
        {
            Students.Add(student);
            student.Courses.Add(this);
            return true;
        }
        return false;
    }
}
