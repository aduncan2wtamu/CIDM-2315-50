using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    private int studentID;
    private string studentName;
    public static List<Student> studentList = new List<Student>();

    public Student(int id, string name)
    {
        studentID = id;
        studentName = name;
        studentList.Add(this);
    }

    public void PrintInfo()
    {
        Console.WriteLine("ID: " + studentID + ", Name: " + studentName);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student(111, "Alice");
        Student s2 = new Student(222, "Bob");
        Student s3 = new Student(333, "Cathy");
        Student s4 = new Student(444, "David");

        Dictionary<string, double> gradebook = new Dictionary<string, double>();
        gradebook["Alice"] = 4.0;
        gradebook["Bob"] = 3.6;
        gradebook["Cathy"] = 2.5;
        gradebook["David"] = 1.8;

        if (!gradebook.ContainsKey("Tom"))
        {
            gradebook["Tom"] = 3.3;
        }

        double averageGPA = gradebook.Values.Average();
        Console.WriteLine("Average GPA: " + averageGPA);

        Console.WriteLine("Students with GPA greater than the average:");
        foreach (var entry in gradebook)
        {
            if (entry.Value > averageGPA)
            {
                Console.WriteLine(entry.Key + ": " + entry.Value);
            }
        }
    }
}
