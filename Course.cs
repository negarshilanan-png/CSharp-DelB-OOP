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

    // Registrerar en student i kursen
    public bool Enroll(Student student)
    {
        // 1. Kontrollerar om kursen är full
        if (Students.Count >= MaxSeats)
        {
            Console.WriteLine("Kursen är full!");
            return false;
        }

        // 2. Kontrollerar om studenten inte redan är registrerad
        if (Students.Contains(student) == false)
        {
            Students.Add(student);
            student.Courses.Add(this); // Lägger till kursen i studentens lista
            return true;
        }

        return false;
    }

    // Tar bort en student från kursen
    public void Remove(Student student)
    {
        if (Students.Contains(student) == true)
        {
            Students.Remove(student);
            student.Courses.Remove(this); // Tar bort kursen från studentens lista
        }
    }

    // Skriver ut alla studenter i kursen
    public void RollCall()
    {
        Console.WriteLine($"Studenter i {Name}:");
        foreach (Student s in Students)
        {
            Console.WriteLine(s.Name);
        }
    }

    // Returnerar en textrepresentation av kursen
    public override string ToString()
    {
        return $"{Name} ({Students.Count}/{MaxSeats} platser)";
    }
}
