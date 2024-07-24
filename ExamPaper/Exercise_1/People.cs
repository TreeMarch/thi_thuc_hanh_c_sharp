namespace ExamPaper;

public class People
{
    public String Name { get; set; }
    public Boolean Gender { get; set; }
    public int Age { get; set; }

    public People()
    {
        
    }

    public People(string name, bool gender, int age)
    {
        Name = name;
        Gender = gender;
        Age = age;
    }

    public void DisplayValue()
    {
        Console.WriteLine($"Name : {Name}");
        Console.WriteLine($"Gender : {(Gender ? "Female" : "Male")}");
        Console.WriteLine($"Age : {Age}");
    }
}