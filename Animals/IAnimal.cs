public interface IAnimal
{
    string Species { get; set; }
    int Age { get; set; }
    string Name { get; set; }

    void DisplayInfo();
}