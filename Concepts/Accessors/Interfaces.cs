namespace Concepts.Accessors;

public class Interfaces(List<IMovable> movables)
{
    public void Run()
    {
        var car = movables.Find(x => x.GetType() == typeof(Car));
        car?.Move(80);

        var airplane = movables.Find(x => x.GetType() == typeof(Airplane));
        airplane?.Move(950);
    }
}

// Cannot be instantiated
public interface IMovable
{
    // Declares contracts without implementation
    void Move(int speed);
}

public class Car : IMovable
{
    public void Move(int speed)
    {
        Console.WriteLine($"Car is moving at {speed} km/h.");
    }
}

public class Airplane : IMovable
{
    public void Move(int speed)
    {
        Console.WriteLine($"Airplane is flying at {speed} km/h.");
    }
}