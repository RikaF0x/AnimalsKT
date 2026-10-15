using System.Security.Cryptography.X509Certificates;

namespace Animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zoo zoo = new Zoo();
            Animal Mike = new Bird("Mike", 19, "Чайка", Diet.Omnivore, "Кха-Кха", 14.5);
            Animal Sergeevna = new Mammal("Sergeevna", 7, "Нерпа", Diet.Carnivore, "Блёб", 2);
            Animal Cassius = new Reptile("Cassius", 10, "Крокодил", Diet.Carnivore, "Гхаа", false);
            zoo.AddAnimal(Mike);
            zoo.AddAnimal(Sergeevna);
            zoo.AddAnimal(Cassius);
            zoo.FeedAnimal();
            zoo.PrintAllAnimals();
            zoo.MakeSoundAll();
        }
    }
    public enum Diet
    {
        Herbivore,
        Carnivore,
        Omnivore
    }
    public class Animal
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Vid {  get; private set; }
        public Diet LocalD {get; private set;}
        public string Sound { get; private set; }
        public void Eat()
        {
            Console.WriteLine($"{Name} eat {LocalD}");
        }
        public void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping");
        }
        public void MakeSound()
        {
            Console.WriteLine($"{Name} do {Sound}");
        }
        public void Feed()
        {
            Console.WriteLine($"{Name} is eating now");
        }
        public Animal(string name, int age, string vid, Diet localD, string sound)
        {
            Name = name;
            Age = age;
            Vid = vid;
            LocalD = localD;
            Sound = sound;
        }
    }
    public class Bird : Animal
    {
        public double WingSpan {  get; private set; }
        public Bird(string name, int age, string vid, Diet localD, string sound, double wingspan) : base(name , age, vid, localD, sound)
        {
            WingSpan = wingspan;
        }
    }
    public class Mammal : Animal
    {
        public int NumTeats { get; private set; }
        public Mammal(string name, int age, string vid, Diet localD, string sound, int numteats) : base(name, age, vid, localD, sound)
        {
            NumTeats = numteats;
        }
    }
    public class Reptile : Animal
    {
        public bool IsVenomous { get; private set; }
        public Reptile(string name, int age, string vid, Diet localD, string sound, bool isvenomous) : base(name, age, vid, localD, sound)
        {
            IsVenomous = isvenomous;
        }
    }
    public class Zoo()
    {
        private List<Animal> zoolist = new List<Animal>();
        public void AddAnimal (Animal animal)
        {
            zoolist.Add(animal);
        }
        public void FeedAnimal()
        {
            foreach (Animal animal in zoolist)
            {
                animal.Feed();
            }
        }
        public void PrintAllAnimals()
        {
            foreach(Animal animal in zoolist)
            {
                Console.WriteLine($"{animal.Name} is {animal.Vid}");
            }
        }
        public void MakeSoundAll()
        {
            foreach(Animal animal in zoolist)
            {
                animal.MakeSound();
            }
        }
    }
}
