namespace Concepts.Accessors;

public static class Abstracts
{
   public static void Run()
   {
      var motorcycle = new Motorcycle();
      // Subtype class implementation method
      motorcycle.Move();
      
      // Base class method
      motorcycle.UpdateSpeed(100);
      motorcycle.Move();
   } 
}

public abstract class Moveable
{
   // Can have properties
   // Protected to make it accessible only be derived classes
   protected int Speed { get; private set; } = 60;

   // Can declare methods to be overwritten
   public abstract void Move();

   // Can implement methods
   public void UpdateSpeed(int speed)
   {
      Speed = speed;
   }
}

public class Motorcycle : Moveable
{
   // Method's override from base class
   public override void Move()
   {
      Console.WriteLine($"Motorcycle is moving at {Speed} km/h");
   }
}