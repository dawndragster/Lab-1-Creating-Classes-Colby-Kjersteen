using System;
using System.Collections.Generic;

class Person
{
    public int personId;
    public string firstName;
    public string lastName;
    public string favoriteColour;
    public int age;
    public bool isWorking;

    public void DisplayPersonInfo()
    {
        Console.WriteLine("Name: " + firstName + " " + lastName);
        Console.WriteLine("Person ID: " + personId);
        Console.WriteLine("Favorite Color: " + favoriteColour);
    }

    public void ChangeFavoriteColor()
    {
        favoriteColour = "White";
    }

    public int GetAgeInTenYears()
    {
        return age + 10;
    }

    public override string ToString()
    {
        return "Name: " + firstName + " " + lastName + ", Person ID: " + personId + ", Favorite Color: " + favoriteColour + ", Age: " + age + ", Is Working: " + isWorking;
    }
}

class Relation
{
    public string relationshipType;

    public void ShowRelationship(Person person1, Person person2)
    {
        Console.WriteLine(person1.firstName + " " + person1.lastName + " is " + relationshipType + " of " + person2.firstName + " " + person2.lastName);
    }
}

class MainClass
{
    static void Main(string[] args)
    {
        List<Person> personList = new List<Person>();

        Person person1 = new Person()
        {
            personId = 1,
            firstName = "Ian",
            lastName = "Brooks",
            favoriteColour = "Red",
            age = 30,
            isWorking = true
        };
        personList.Add(person1);

        Person person2 = new Person()
        {
            personId = 2,
            firstName = "Gina",
            lastName = "James",
            favoriteColour = "Green",
            age = 18,
            isWorking = false
        };
        personList.Add(person2);

        Person person3 = new Person()
        {
            personId = 3,
            firstName = "Mike",
            lastName = "Briscoe",
            favoriteColour = "Blue",
            age = 45,
            isWorking = true
        };
        personList.Add(person3);

        Person person4 = new Person()
        {
            personId = 4,
            firstName = "Mary",
            lastName = "Beals",
            favoriteColour = "Yellow",
            age = 28,
            isWorking = true
        };
        personList.Add(person4);

        Console.WriteLine("Gina's information: ");
        Console.WriteLine("ID: " + person2.personId);
        Console.WriteLine("First Name: " + person2.firstName);
        Console.WriteLine("Last Name: " + person2.lastName);
        Console.WriteLine("Favorite Color: " + person2.favoriteColour);

        Console.WriteLine("\nMike's information: ");
        Console.WriteLine(person3.ToString());

        Console.WriteLine("\nIan's information before changing favorite color: ");
        Console.WriteLine(person1.ToString());

        person1.ChangeFavoriteColor();

        Console.WriteLine("\nIan's information after changing favorite color: ");
        Console.WriteLine(person1.ToString());

        Console.WriteLine("\nMary's age after ten years: " + person4.GetAgeInTenYears());

        Relation relation1 = new Relation()
        {
            relationshipType = "Sister"
        };

        Relation relation2 = new Relation()
        {
            relationshipType = "Brother"
        };

        relation1.ShowRelationship(person2, person4);
        relation2.ShowRelationship(person1, person3);

        int sumOfAges = 0;
        int youngestAge = Int32.MaxValue;
        int oldestAge = Int32.MinValue;
        Person youngestPerson = null;
        Person oldestPerson = null;
        List<string> namesWithM = new List<string>();
        Person blueLover = null;

        foreach (Person person in personList)
        {
            sumOfAges += person.age;

            if (person.age < youngestAge)
            {
                youngestAge = person.age;
                youngestPerson = person;
            }

            if (person.age > oldestAge)
            {
                oldestAge = person.age;
                oldestPerson = person;
            }

            if (person.firstName.StartsWith("M"))
            {
                namesWithM.Add(person.firstName);
            }

            if (person.favoriteColour == "Blue")
            {
                blueLover = person;
            }
        }

        double averageAge = (double)sumOfAges / personList.Count;

        Console.WriteLine("\nAverage age: " + averageAge);
        Console.WriteLine("Youngest person: " + youngestPerson.firstName + " " + youngestPerson.lastName);
        Console.WriteLine("Oldest person: " + oldestPerson.firstName + " " + oldestPerson.lastName);
        Console.WriteLine("Names starting with M: ");
        foreach (string name in namesWithM)
        {
            Console.WriteLine(name);
        }

        Console.WriteLine("Person who likes the color blue: ");
        Console.WriteLine(blueLover.ToString());
    }
}