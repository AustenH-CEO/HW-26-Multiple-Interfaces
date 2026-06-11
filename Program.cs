// This program will demonstrate implementing multiple interfaces in a single class.
// Austen Hernandez
// 6/11/26

public class Program
{
    public static void Main()
    {
        Drone drone = new Drone();

    }
}
public interface IFlyable
{
    void FlyUp();
    void FlyDown();
}
public interface IShootable
{
    void Shoot();
}
public class Drone : IFlyable, IShootable
{
    public void FlyUp()
    {
        Console.WriteLine("Drone flies upward.");
    }
    public void FlyDown()
    {
        Console.WriteLine("Drone flies downward.");
    }
    public void Shoot()
    {
        Console.WriteLine("Drone fires lasers.");
    }
}