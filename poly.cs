public abstract class Animal{
    public string name;
    public Animal(string name){
        this.name = "really";
    }

    public abstract void status();
}

public class Dog: Animal{
    public string name;
    public Dog(string name): base(name){
        this.name = name;
    }

    public override void status(){
        Console.WriteLine("Dog is: " + name);
    }
}

public class Tiger: Cat{
    public string name;
    public Tiger(string name): base(name){
        this.name = name;
    }

    public override void status(){
        Console.WriteLine("Tiger is: " + name);
    }
}

public class Cat: Animal{
    public string name;
    public Cat(string name): base(name){
        this.name = name;
    }

    public override void status(){
        Console.WriteLine("Cat is: " + name);
    }
}