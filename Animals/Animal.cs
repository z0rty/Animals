public class Animal : IAnimal
{
    public string Species { get; set; }
    public int Age { get; set; }
    public string Name { get; set; }

    public Animal(string species, int age, string name)
    {
        Species = species;
        Age = age;
        Name = name;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Species: {Species}, Age: {Age}, Name: {Name}");
    }
}