using System;

public class Person
{
    private string _firstName;
    private string _lastName;
    private DateTime _dateOfBirth;
    private char _gender;

    public Person(string firstName, string lastName, DateTime dateOfBirth, char gender)
    {
        _firstName = firstName;
        _lastName = lastName;
        _dateOfBirth = dateOfBirth;
        Gender = gender;
    }

    public string FirstName
    {
        get { return _firstName; }
        set { _firstName = value; }
    }

    public string LastName
    {
        get { return _lastName; }
        set { _lastName = value; }
    }

    public DateTime DateOfBirth
    {
        get { return _dateOfBirth; }
        set { _dateOfBirth = value; }
    }

    public char Gender
    {
        get { return _gender; }
        set
        {
            if (value == 'M' || value == 'F')
            {
                _gender = value;
            }
            else
            {
                throw new ArgumentException("Gender must be 'M' or 'F'");
            }
        }
    }

    public int Age
    {
        get
        {
            DateTime now = DateTime.Today;
            int age = now.Year - _dateOfBirth.Year;
            if (now < _dateOfBirth.AddYears(age)) age--;
            return age;
        }
    }

    public void PrintInfo()
    {
        Console.WriteLine("First Name: " + _firstName);
        Console.WriteLine("Last Name: " + _lastName);
        Console.WriteLine("Date of Birth: " + _dateOfBirth.ToShortDateString());
        Console.WriteLine("Gender: " + _gender);
    }
}

class Program
{
    static void Main()
    {
        Person person = new Person("John", "Doe", new DateTime(1990, 1, 1), 'M');
        person.PrintInfo();
        Console.WriteLine("Age: " + person.Age);
    }
}
