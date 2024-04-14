Console.WriteLine("NAme your dog:");
string myDogName = Console.ReadLine();
Dog myDog = new Dog(myDogName);

Dog neighboursDog = new Dog("Good Girl");



Console.WriteLine($"My dogs name is {myDog.Name}");
Console.WriteLine($"My neighboursdogs name is {neighboursDog.Name}");

myDog.Rename("Bad boy");
while(myDog.LevelOfHapiness!= 5)
{
    myDog.Bark(); 
}
myDog.WagTail();
//Console.WriteLine($"Level of happines: {myDog.LevelOfHapiness}");

//myDog.Bark();
//Console.WriteLine($"Level of happines: {myDog.LevelOfHapiness}");

class Dog
{
    private string _name;//field
    private int _levelOfHapiness;
    //constructor
    public Dog(string name)
    {
         _name = name;
        _levelOfHapiness = 0;
    }
    
    //getter
    public string Name
    {
        get { return _name; }
    }
    public int LevelOfHapiness
    {  get { return _levelOfHapiness; } }
    public void Rename(string newName)
    {
        _name = newName;
        Console.WriteLine($"Dog has been renamed to: {newName}");
    }
    public void Bark()
    {
        Console.WriteLine("Woof- Woof");
        _levelOfHapiness ++;
    }

    public void WagTail()
    {
        Console.WriteLine("Wiggle-wiggle");
    }
}

