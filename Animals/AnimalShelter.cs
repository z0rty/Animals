public class AnimalShelter : IAnimalShelter
{
    private List<Animal> animals = new List<Animal>();

    public void AddAnimal(Animal animal)
    {
        animals.Add(animal);
    }

    public void RemoveAnimal(string name)
    {
        animals.RemoveAll(a => a.Name == name);
    }

    public List<Animal> SearchAnimals(string species = null, int? age = null, string name = null)
    {
        return animals.FindAll(a =>
            (species == null || a.Species == species) &&
            (!age.HasValue || a.Age == age) &&
            (name == null || a.Name == name));
    }
}