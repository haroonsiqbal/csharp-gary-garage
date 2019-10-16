using System;

namespace gary_garage
{
    public class Tesla : Vehicle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery() 
        {
            Console.WriteLine("Battery is charging");
        }
        public override void Drive () {
        Console.WriteLine($"The {MainColor} Tesla drives past. Eeeeeeeeee!");
        }
        public override void Turn(string direction){
        Console.WriteLine($"The Tesla deftly turned {direction}.");
        }

        public override void Stop(){
        Console.WriteLine("The tesla silently came to a stop.");
        }
    }

    public class Zero : Vehicle
    {
        public double BatteryKWh {get; set;}
        public void ChargeBattery() 
        {
            Console.WriteLine("Battery is charging");
        }
        public override void Drive () {
        Console.WriteLine($"The {MainColor} Zero zips past you. Shoooooom!");
        }
        public override void Turn(string direction){
            Console.WriteLine($"The Zero darted {direction}.");
        }
        public override void Stop(){
            Console.WriteLine("The Zero screetched to a halt.");
        }
    }
    public class Cessna : Vehicle
    {
        public double FuelCapacity {get; set;}
        public void RefuelTank ()
        { 
            Console.WriteLine("Tank is refueling");
        }
        public override void Drive () {
        Console.WriteLine($"The {MainColor} Cessna flies over you. Zoooom!");
        }
        public override void Turn(string direction){
        Console.WriteLine($"The {MainColor} Cessna banked {direction}.");
        }
        public override void Stop(){
            Console.WriteLine("The cessna landed and came to a stop.");
        }
    }
    public class Ram : Vehicle
    {
        public double FuelCapacity {get; set;}
        public void RefuelTank()
        {
            Console.WriteLine("Tank is refueling");
        }
        public override void Drive(){
        Console.WriteLine($"The {MainColor} Ram growls past you. Rrroooam!");
        }
        public override void Turn(string direction){
            Console.WriteLine($"The Ram steered {direction}.");
        }
        public override void Stop(){
            Console.WriteLine($"The {MainColor} ram slammed on its brakes and stopped.");
        }
    }
}