using CSharpProgramming.Tests.Base;
using Xunit;
using Xunit.Abstractions;

namespace CSharpProgramming.Tests.General;

public class Tuples(ITestOutputHelper output) : BaseTest(output)
{
    [Fact]
    public void CreateTuple()
    {
        var person = ("John", 30, "New York");
        output.WriteLine($"Name: {person.Item1}, Age: {person.Item2}, City: {person.Item3}");
    }

    [Fact]
    public void NamedTuple()
    {
        var person = (Name: "John", Age: 30, City: "New York");
        output.WriteLine($"Name: {person.Name}, Age: {person.Age}, City: {person.City}");
    }

    [Fact]
    public void TupleWithMethod()
    {

        (string Name, int Age, string City) GetPerson()
        {
            return ("John Doe", 30, "New York");
        }

        var person = GetPerson();
        output.WriteLine($"Name: {person.Name}, Age: {person.Age}, City: {person.City}");
    }

    [Fact]
    public void TupleDeconstruction()
    {
        var person = (Name: "John", Age: 30, City: "New York");
        var (name, age, city) = person;
        output.WriteLine($"Name: {name}, Age: {age}, City: {city}");
    }

    [Fact]
    public void Features1Comparison()
    {
        var person1 = ("John", 30, "New York");
        var person2 = ("Jane", 25, "Los Angeles");
        var person3 = ("John", 30, "New York");

        Print(person1 == person2);
        Print(person1 == person3);
    }

    [Fact]
    public void Features2()
    {
        // Use it up to 7 elements as a best practice
        var largeTuple = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11);
        Print(largeTuple.Item1);
        Print(largeTuple.Item2);
        Print(largeTuple.Item11);

        var largeTuple2 = (1, 2, 3, 4, 5, 6, 7, Tuple.Create(8, 9, 10), 11);
        Print(largeTuple2.Item1);
        Print(largeTuple2.Item2);
        Print(largeTuple2.Rest.Item1);
        Print(largeTuple2.Rest.Item2);
    }

    [Fact]
    public void Features3()
    {
        var numbers = Enumerable.Range(1, 10).ToArray();
        var tuples = numbers.Select(i => (i, i * i)).ToArray();

        foreach (var (number, square) in tuples)
        {
            output.WriteLine($"Number: {number}, Square: {square}");
        }
    }
}
