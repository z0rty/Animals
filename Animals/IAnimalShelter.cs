public interface IAnimalShelter
{
    void AddAnimal(Animal animal);
    void RemoveAnimal(string name);
    List<Animal> SearchAnimals(string species = null, int? age = null, string name = null);
}