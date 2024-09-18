using System.Numerics;

class Var
{
    public static void MyVar()
    {
        string myName = "Andre";
        Console.WriteLine(myName);
    }

    public static void DataType()
    {
        string firstName = "Andre";
        string lastName  = "Jefferson"; 
        string wholeName = firstName +lastName;
        int age = 16;
        float gpa = 4.1f;
        double height = 5.7;
        decimal dollar = 7.62m;
        bool is_Student = true;
        char grade = 'A';

        // Console.WriteLine(firstName);
        // Console.WriteLine(lastName);
        Console.WriteLine(firstName +lastName);
        Console.WriteLine(age);
        Console.WriteLine(dollar);
        Console.WriteLine(height);
        Console.WriteLine(gpa);
        Console.WriteLine(is_Student);
        Console.WriteLine(grade);
    }
}