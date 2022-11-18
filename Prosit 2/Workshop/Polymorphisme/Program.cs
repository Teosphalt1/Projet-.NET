public class Vehicle
{
    public virtual void vehicleSpeed()
    {
        Console.WriteLine("This vehicle goes to a certain speed");
    }

    public virtual void amongus()
    {
        Console.WriteLine("I'm a vehicle");
    }
}

public class motorcycle : Vehicle
{
    public override void vehicleSpeed()
    {
        Console.WriteLine("The motorcycle goes 100mph");
    }
    public virtual void motorcycleName()
    { }
}

public class duke390 : motorcycle
{
    public override void motorcycleName()
    {
        Console.WriteLine("I'm a KTM Duke 390");
    }
}

public class bike : Vehicle
{
    public override void vehicleSpeed()
    {
        Console.WriteLine("The bike goes 7mph");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Vehicle myVehicle = new Vehicle();
        Vehicle myMotorcycle = new motorcycle();
        Vehicle myBike = new bike();
        motorcycle myduke390 = new duke390();


        myVehicle.vehicleSpeed();

        myMotorcycle.vehicleSpeed();
        myMotorcycle.amongus();

        myBike.vehicleSpeed();

        myduke390.motorcycleName();
        myduke390.vehicleSpeed();
        myduke390.amongus();
    }
}