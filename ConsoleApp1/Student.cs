using System;

public class Student
{
    public int Id { get; set; }
    public string FName { get; set; }
    public string LName { get; set; }
    public override string ToString()
    {
        return $"{FName}, {LName}"
    }
}
