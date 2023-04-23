using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // List<Cat> cats = new List<Cat>();
        // cats.Add(new Cat { Name = "Mittens", Age = 3 });
        // cats.Add(new Cat { Name = "Fluffy", Age = 2 });
        // cats.Add(new Cat { Name = "Whiskers", Age = 5 });
        // cats.Add(new Cat { Name = "Paws", Age = 1 });
        // cats.Add(new Cat { Name = "Tiger", Age = 4 });

        // foreach (Cat cat in cats)
        // {
        //     Console.WriteLine($"Name: {cat.Name}, Age: {cat.Age}");
        // }

        // Cat myCat = cats.Find(c => c.Name == "Fluffy");
        // cats.Remove(myCat);
        // foreach (Cat cat in cats)
        // {
        //     Console.WriteLine($"Name: {cat.Name}, Age: {cat.Age}");
        // }

        // Dictionary<string, Cat> catDictionary = new Dictionary<string, Cat>();
        // catDictionary.Add("Mittens", new Cat { Name = "Mittens", Age = 3 });
        // catDictionary.Add("Fluffy", new Cat { Name = "Fluffy", Age = 2 });
        // catDictionary.Add("Whiskers", new Cat { Name = "Whiskers", Age = 5 });

        // if (catDictionary.ContainsKey("Fluffy"))
        // {
        //     Cat myCat = catDictionary["Fluffy"];
        // }

        // Console.WriteLine("Read or write?");
        // string answer = Console.ReadLine();
        // if (answer == "read")
        // {
        //     Cat cat = ReadCatFromFile();
        //     Console.WriteLine($"Name: {cat.Name}, Age: {cat.Age}");
        // }
        // else if (answer == "write")
        // {
        //     Console.WriteLine("Name?");
        //     string name = Console.ReadLine();
        //     Console.WriteLine("Age?");
        //     int age = int.Parse(Console.ReadLine());
        //     Cat cat = new Cat { Name = name, Age = age };
        //     WriteCatToFile(cat);
        // }
        // else
        // {
        //     Console.WriteLine("Invalid answer");
        // }

        Task myTask = new Task(PrintHelloWorld);
        myTask.Start();
        Thread.Sleep(500);
        Task myTask2 = new Task(PrintGreeting);
        myTask2.Start();


        Console.ReadLine();
    }

    public static void PrintHelloWorld()
    {
        while(true)
        {
            Console.WriteLine("Hello World!");
            Thread.Sleep(1000);
        }
    }

    public static void PrintGreeting()
    {
        while(true)
        {
            Console.WriteLine("Greeting");
            Thread.Sleep(1000);
        }
    }

    static Cat ReadCatFromFile()
    {
        using FileStream stream = new FileStream(Path.Combine(AppContext.BaseDirectory, "file.txt"), FileMode.Open, FileAccess.Read);
        StreamReader reader = new StreamReader(stream);
        string text = reader.ReadToEnd();
        Cat cat = JsonConvert.DeserializeObject<Cat>(text);
        return cat;
    }

    static void WriteCatToFile(Cat cat)
    {
        using FileStream stream = new FileStream(Path.Combine(AppContext.BaseDirectory, "file.txt"), FileMode.OpenOrCreate, FileAccess.Write);
        StreamWriter writer = new StreamWriter(stream);
        string json = JsonConvert.SerializeObject(cat);
        writer.WriteLine(json);
        writer.Flush();
    }
}

class Cat {
    public string Name { get; set; }
    public int Age { get; set; }
}