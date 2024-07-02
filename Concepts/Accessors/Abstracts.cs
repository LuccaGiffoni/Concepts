namespace Concepts.Accessors;

public static class Abstracts
{
   public static void Run()
   {
      var motorcycle = new Motorcycle();
      motorcycle.Move();
      
      motorcycle.UpdateSpeed(100);
      motorcycle.Move();
   } 
}

public abstract class Moveable
{
   protected int Speed { get; private set; } = 60;

   public abstract void Move();

   public void UpdateSpeed(int speed)
   {
      Speed = speed;
   }
}

public class Motorcycle : Moveable
{
   public override void Move()
   {
      Console.WriteLine($"Motorcycle is moving at {Speed} km/h");
   }
}