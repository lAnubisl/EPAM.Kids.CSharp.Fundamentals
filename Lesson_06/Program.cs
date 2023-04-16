class Program
{
    static void Main(string[] args)
    {
        Weigth weigth = new Weigth();


        Animal animal = new Dog();


        Dog dog = new Dog();
        dog.Name = "Dog";
        dog.Age = 5;
        dog.Color = "Black";
        dog.Weight = 10;
        dog.EarLength = 20;
        //weigth.Measure(dog);
        dog.Eat("Meat", 1);
        // weigth.Measure(dog);

        Cat Cat = new Cat();
        Cat.Name = "Cat";
        Cat.Age = 3;
        Cat.Color = "White";
        Cat.Weight = 5;
        Cat.WhiskersLength = 10;
        //weigth.Measure(Cat);
        Cat.Eat("Fish", 2);
        // weigth.Measure(Cat);
    }

    public static void Analyze(Animal animal, IClinic clinic)
    {
        Console.WriteLine("Name: " + animal.Name);
        Console.WriteLine("Age: " + animal.Age);
        Console.WriteLine("Color: " + animal.Color);
        Console.WriteLine("Weight: " + clinic.MeasureWeight(animal));
        Console.WriteLine("Height: " + clinic.MeasureHeight(animal));
        Console.WriteLine("Length: " + clinic.MeasureLength(animal));
        Console.WriteLine("Temperature: " + clinic.MeasureTemperature(animal));
    }
}

class Weigth
{
    public void Measure(Animal animal)
    {
        animal.MakeSound();
        Console.WriteLine("Weight: " + animal.Weight);
    }
}

interface IClinic
{
    float MeasureWeight(Animal animal);

    float MeasureHeight(Animal animal);

    float MeasureLength(Animal animal);

    float MeasureTemperature(Animal animal);
}

abstract class Animal
{
    public string Name;
    public int Age;
    public string Color;
    public int Weight;

    public abstract void MakeSound();

    public void Eat(string food, int weight)
    {
        Weight = Weight + weight;
        Console.WriteLine("Eating..." + food);
        MakeSound();
    }
}

class Dog : Animal
{
    public int EarLength;

    public override void MakeSound()
    {
        Console.WriteLine("Gav Gav");
    }
}

class Cat : Animal
{
    public int WhiskersLength;

    public override void MakeSound()
    {
        Console.WriteLine("Meow Meow");
    }
}