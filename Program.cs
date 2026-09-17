using System;

class Program
{
    static void Main(string[] args)
    {
        // Skapar en kurs med max 2 platser
        Course csharp = new Course("C# OOP", 2);

        // Skapar 3 studenter
        Student s1 = new Student("Negar");
        Student s2 = new Student("Anna");
        Student s3 = new Student("Erik");

 // 1. Registrering via Course
        csharp.Enroll(s1);

        // 2. Registrering via Student (tvåvägskoppling)
        s2.Join(csharp);

        // 3. Testar maxkapacitet (den tredje studenten ska inte läggas till)
        csharp.Enroll(s3);

        // 4. Visar studentlista och kursstatus
        Console.WriteLine();
        Console.WriteLine(csharp.ToString());
        csharp.RollCall();

        // 5. Visar Negars schema
        Console.WriteLine();
        s1.Schedule();

        // 6. Testar avregistrering
        Console.WriteLine();
        s1.Leave(csharp);
        Console.WriteLine(csharp.ToString()); // Ska visa 1 ledig plats
    }
}
       