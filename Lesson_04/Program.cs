// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Cat[] cats = new Cat[3];
cats[0] = new Cat(3, "Murzik", "Black", "Siam");
cats[1] = new Cat(5, "Barsik", "White", "Siam");
cats[2] = new Cat(2, "Vaska", "Gray", "Siam");

cats[0].Owner = new Owner("Ivan", "123456789", "Moscow");

Cat murzik = new Cat(3, "Murzik", "Black", "Siam");
Cat barsik = new Cat(5, "Barsik", "White", "Siam");


PrintCatOwnerInfo(murzik);
PrintCatOwnerInfo(barsik);
IncreaseCatAge(murzik, 1);
IncreaseCatAgeInt(murzik.Age, 1);
IncreaseCatAge(barsik, 2);


Console.ReadKey();

void IncreaseCatAgeInt(int catAge, int years)
{
    catAge += years;
}

void IncreaseCatAge(Cat cat, int years)
{
    cat = new Cat(cat.Age + years, cat.Name, cat.Color, cat.Breed);
}

void PrintCatOwnerInfo(Cat cat)
{
    Console.WriteLine($"Owner name: {cat.Owner.Name}");
    Console.WriteLine($"Owner phone: {cat.Owner.Phone}");
    Console.WriteLine($"Owner address: {cat.Owner.Address}");
}

class Cat
{
    public Cat(int age, string name, string color, string breed)
    {
        this.Age = age;
        this.Name = name;
        this.Color = color;
        this.Breed = breed;
    }

    public string Name;
    public int Age;
    public string Color;
    public string Breed;
    public Owner Owner;
}

class Owner
{
    public Owner(string name, string phone, string address)
    {
        this.Name = name;
        this.Phone = phone;
        this.Address = address;
    }

    public string Name;
    public string Phone;
    public string Address;
}