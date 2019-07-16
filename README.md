
# Zoological Zaniness

Imagine a scenario in which you are writing an application in which you need to classify any animal species as ground-based, air-based, or water-based. Also consider that animal species can be any combination of those classifications.

For example, a platypus is both ground and water. Most birds are both air and ground. Cats are ground only. Dolphins are water only. Seagulls are air, ground, and water (they can dive to amazing depths and are great swimmers). So many possible combinations of behavior in the animal kingdom!

🐯 🦅 🐎 🦈 🙎🏾‍♀️ 🦉

To make our code base as flexible as possible, we define the properties and behaviors of each classification (or description) into an interface. You are going to start with intefaces for animals that can walk and those that can swim.

```cs
public interface IWalking
{
    void Run();
    void Walk();
}

public interface ISwimming
{
    int MaximumDepth {get;}
    void Swim();
}
```

Now you can define a class as an implemention of the interface for a walking animal. You can start with an African Painted Dog.

```cs
public class PaintedDog : IWalking
{
}
```

Since it is a contract, we must implement the methods that were defined in the interface.

```cs
public class PaintedDog : IWalking
{
    public void Run()
    {
        Console.WriteLine("Animal is now running");
    }

    public void Walk()
    {
        Console.WriteLine("Animal is now walking");
    }
}
```


The `PaintedDog` class has now followed the rules of the interface, and implemented the two required methods that are required.

### Multiple Interfaces

A class can implement more than one interface. Let's use a Sea Turtle as an example, since they both swim in the ocean and walk on land.

```cs
class SeaTurtle : IWalking, ISwimming
{
    int MaximumDepth { get; } = 100;

    public void Run()
    {
        Console.WriteLine("Animal is now running");
    }

    public void Walk()
    {
        Console.WriteLine("Animal is now walking");
    }

    public void Swim()
    {
        Console.WriteLine("Animal is now swimming");
    }
}
```

Because you specified two interfaces, you had to provide an implementation for the properties and methods from both of them.

## Resources

* [Interface-based programming](https://en.wikipedia.org/wiki/Interface-based_programming)
* [Understanding Interface-based Programming](https://msdn.microsoft.com/en-us/library/aa260635(v=vs.60).aspx)

## Practice: Diggers and Fliers

As an avid animal lover, you have started your very own collection of creatures in your home. You can use the code from the lesson as a starting point to have interfaces for walking and swimming animals, but you want to have several other kinds in your collection.

This is the list of animals you want to own and care for.

1. Parakeets
1. Earthworms
1. [Terrapins](https://en.wikipedia.org/wiki/Terrapin)
1. Timber Rattlesnake
1. Mice
1. Ants
1. Finches
1. [Betta Fish](https://bettafish.org/)
1. Copperhead snake
1. Gerbils

Each month, you clean out all of the habitats in a single day for efficiency. On that day, all animals need to be put into temporary containers. Each container will hold animals of similar similar, but different, types.

* Animals that dig and live in the ground
* Animals that move about on the ground
* Animals that swim in water
* Animals that fly above the ground

1. Before you write any classes for the above animals, determine the common properties and behaviors that some of them share and define interfaces first.
1. Once you believe you have a good set of interfaces, then start creating your specific animal classes and have them implement the appropriate interface.
1. Then define classes to represent the containers that will hold various animals. Each container class should have a single property - a list to hold animal instances.
1. Lastly, in `Main()` create one (or more if you like) instances of each type of animal and each container. Then add the animals to their corresponding container.
