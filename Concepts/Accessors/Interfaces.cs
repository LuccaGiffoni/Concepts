namespace Concepts.Accessors;

public class Interfaces(List<IMoveable> moveables)
{
    public void Run()
    {
        var car = moveables.Find(x => x.GetType() == typeof(Car));
        car?.Move(80);

        var airplane = moveables.Find(x => x.GetType() == typeof(Airplane));
        airplane?.Move(950);
    }
}

public interface IMoveable
{
    void Move(int speed);
}

public class Car : IMoveable
{
    public void Move(int speed)
    {
        Console.WriteLine($"Car is moving at {speed} km/h.");
    }
}

public class Airplane : IMoveable
{
    public void Move(int speed)
    {
        Console.WriteLine($"Airplane is flying at {speed} km/h.");
    }
}