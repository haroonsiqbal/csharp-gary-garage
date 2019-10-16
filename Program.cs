using System;

namespace gary_garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Tesla modelS = new Tesla()
            {
                BatteryKWh = 300,
                MaximumOccupancy = 5,
                MainColor = "silver"
            };

            Zero fsx = new Zero()
            {
                BatteryKWh = 50,
                MaximumOccupancy = 1,
                MainColor = "black"
            };
            Cessna s2100 = new Cessna()
            {
                FuelCapacity = 100,
                MaximumOccupancy = 4,
                MainColor = "white"
            };
            Ram srt = new Ram()
            {
                FuelCapacity = 20,
                MaximumOccupancy = 4,
                MainColor = "red"
            };

        modelS.Drive();
        modelS.Turn("Right");
        modelS.Stop();
        
        Console.WriteLine("");
        
        fsx.Drive();
        fsx.Turn("Left");
        fsx.Stop();
        
        Console.WriteLine("");
        
        s2100.Drive();
        s2100.Turn("Sharply Right");
        s2100.Stop();
        
        Console.WriteLine("");
        
        srt.Drive();
        srt.Turn("Slightly Left");
        srt.Stop();

        }
    }
}
