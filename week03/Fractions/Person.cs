using System;

// 1. Determine the classes
public class Person
{
    // 3. Define class attributes
    private string _title;
    private string _firstName;
    private string _lastName;

    // 4.  Define Constructors
        // Constructor sin parámetros
    public Person()
    {
        _title = "";
        _firstName = "Anonymous";
        _lastName = "Unknown";
    }

        //  Constructor con nombre y apellido
    public Person(string first, string last)
    {
        _title = "";
        _firstName = first;
        _lastName = last;
    }

        //  Constructor con título, nombre y apellido
    public Person(string title, string first, string last)
    {
        _title = title;
        _firstName = first;
        _lastName = last;
    }

        // Define class behaviors
    public void ShowInfo()
    {
        Console.WriteLine($"{_title} {_firstName} {_lastName}");
    }
}