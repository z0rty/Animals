using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        AnimalShelter shelter = new AnimalShelter();

        while (true)
        {
            Console.WriteLine("1. Add Animal");
            Console.WriteLine("2. Remove Animal");
            Console.WriteLine("3. Search Animals");
            Console.WriteLine("4. Exit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter species:");
                    string species = Console.ReadLine();
                    Console.WriteLine("Enter age:");
                    int age = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter name:");
                    string name = Console.ReadLine();
                    shelter.AddAnimal(new Animal(species, age, name));
                    break;
                case 2:
                    Console.WriteLine("Enter name of animal to remove:");
                    string nameToRemove = Console.ReadLine();
                    shelter.RemoveAnimal(nameToRemove);
                    break;
                case 3:
                    Console.WriteLine("Enter search criteria:");
                    Console.WriteLine("Species (leave empty for any):");
                    string speciesSearch = Console.ReadLine();
                    Console.WriteLine("Age (leave empty for any):");
                    int? ageSearch = string.IsNullOrEmpty(Console.ReadLine()) ? null : (int?)int.Parse(Console.ReadLine());
                    Console.WriteLine("Name (leave empty for any):");
                    string nameSearch = Console.ReadLine();

                    List<Animal> searchResults = shelter.SearchAnimals(speciesSearch, ageSearch, nameSearch);
                    if (searchResults.Count == 0)
                        Console.WriteLine("No animals found.");
                    else
                    {
                        Console.WriteLine("Search results:");
                        foreach (var animal in searchResults)
                        {
                            animal.DisplayInfo();
                        }
                    }
                    break;
                case 4:
                    return;
            }
        }
    }
}
