
Console.WriteLine("Nmae you dog");
string myDogName = Console.ReadLine();
Dog myDog = new Dog(myDogName);

Dog neighboursDog = new Dog("Good Girl");

Console.WriteLine($"My dog name is{myDog.Name}");
Console.WriteLine($"Naabri koer {neighboursDog.Name}");
myDog.Rename("Bad Boy");

while (myDog.LevelOfHapiness != 5) 
{
    myDog.Bark();
}
myDog.WagTail();

class Dog
{
    public string _name;
    public int _levelOfHapiness;

    //constructor
    public Dog(string name)
    { _name = name;
      _levelOfHapiness = 0;
    }

    //getter

    public string Name
    { get { return _name; } }

    public int LevelOfHapiness { 
    get { return _levelOfHapiness; }
    }

    public void Rename(string newName)
    {
        _name = newName;
        Console.WriteLine($"Ümbernimetetud: {newName}");
    }

    public void Bark()
    {
        Console.WriteLine("Woof-woof!");
        _levelOfHapiness++;
    }

    public void WagTail()
    {
        Console.WriteLine("Wiggle-wiggle!");
    }

}

