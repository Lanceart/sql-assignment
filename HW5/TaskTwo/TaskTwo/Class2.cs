using System;


// abstraction
public abstract class Animal
{

    //Encapsulation
    private string name;

    public string Name { get; set; }


    public Animal() { }
    public Animal(String name)
    {
        Name = name;
    }


    public abstract void Eat();

}


//Inheritance
public class Cat: Animal
{
    public Cat() { }    
    public Cat(String name): base(name) { }



    //Ploymorphism: different animal need different food
    public override void Eat()
    {
        Console.WriteLine("Cat eat cat food and milk");
    }
}