using System;

namespace LabManual08
{
    public class Bicycle
    {
        protected int cadence;
        protected int speed;
        protected int gear;

        public Bicycle(int cadence, int speed, int gear)
        {
            this.cadence = cadence;
            this.speed = speed;
            this.gear = gear;
        }

        public void setCadence(int cadence) 
        { 
            this.cadence = cadence; 
        }
        public void setGear(int gear) 
        { 
            this.gear = gear; 
        }
        public void applyBrake(int decrement) 
        { 
            this.speed = this.speed - decrement; 
        }
        public void speedUp(int increment) 
        { 
            this.speed = this.speed + increment;
        }

        public void displayBicycle()
        {
            Console.WriteLine("Bicycle -> Cadence: " + cadence + " | Speed: " + speed + " | Gear: " + gear);
        }
    }

    public class MountainBike : Bicycle
    {
        protected int seatHeight;

        public MountainBike(int seatHeight, int cadence, int speed, int gear) : base(cadence, speed, gear)
        {
            this.seatHeight = seatHeight;
        }

        public void setSeatHeight(int seatHeight)
        { 
            this.seatHeight = seatHeight;
        }
        public void displayMountainBike()
        {
            Console.WriteLine("MountainBike -> Seat Height: " + seatHeight + " | Cadence: " + cadence + " | Speed: " + speed + " | Gear: " + gear);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Bicycle standardBike = new Bicycle(90, 20, 3);
            MountainBike mb = new MountainBike(25, 80, 15, 4);

            standardBike.displayBicycle();
            mb.displayMountainBike();

            Console.WriteLine("\n--- Speeding up the Mountain Bike ---");
            mb.speedUp(10);
            mb.setGear(5);
            mb.displayMountainBike();

            Console.ReadKey();
        }
    }
}