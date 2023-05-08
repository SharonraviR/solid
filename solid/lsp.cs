using System;

/*  
 // Interface
internal interface IBird
{
   void MakeSound();

   void Fly();

   void Run();
}

// Implementations
public class Duck : IBird
{
   public void MakeSound()
   {
       Console.WriteLine("Making sound.");
   }

   public void Fly()
   {
       Console.WriteLine("Flying...");
   }

   public void Run()
   {
       Console.WriteLine("Running...");
   }
}


public class Ostrich : IBird
{
   public void MakeSound()
   {
       Console.WriteLine("Making sound.");
   }

   // Ostrich cannot fly.
   public void Fly()
   {
       throw new NotImplementedException();
   }

   public void Run()
   {
       Console.WriteLine("Running...");
   }
}
 */

internal interface IBird
{
    void MakeSound();

    void Fly();

    void Run();
}

// Implementations
public class Duck : IBird
{
    public void MakeSound()
    {
        Console.WriteLine("Making sound.");
    }

    public void Fly()
    {
        Console.WriteLine("Flying...");
    }

    public void Run()
    {
        Console.WriteLine("Running...");
    }
}

// This breaks the Liskov substituion principle because if we follow polymorphism and call the Fly() method from IBird reference variable
// then it will throw NotImplementedException.
public class Ostrich : IBird
{
    public void MakeSound()
    {
        Console.WriteLine("Making sound.");
    }

    // Ostrich cannot fly.
    public void Fly()
    {
        throw new NotImplementedException();
    }

    public void Run()
    {
        Console.WriteLine("Running...");
    }
}

interface IBird
{
    void MakeSound();

    void Run();
}

interface IFlyingBird : IBird
{
    void Fly();
}

public class Duck : IFlyingBird
{
    public void MakeSound()
    {
        Console.WriteLine("Making sound.");
    }

    public void Fly()
    {
        Console.WriteLine("Flying...");
    }

    public void Run()
    {
        Console.WriteLine("Running...");
    }
}

public class Ostrich : IBird
{
    public void MakeSound()
    {
        Console.WriteLine("Making sound.");
    }

    public void Run()
    {
        Console.WriteLine("Running...");
    }
}

public class Lsp
{
    public static void Main()
    {
        Duck bduck = new Duck();
        Ostrich borstrich = new Ostrich();
        bduck.MakeSound();
        bduck.Fly();
        bduck.Run();
        borstrich.MakeSound();
        borstrich.Run();
    }
}