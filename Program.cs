namespace lesson_5
{
    public class Program
    {


        static void Main(string[] args)
        {
            HeavyTruck truck1 = new HeavyTruck(101, "Avraham", 5000, "Gas");

            Console.WriteLine(truck1.PrintDetails());

            truck1.UpdateWeight(7000);
            Console.WriteLine("After new weight:");
            Console.WriteLine(truck1.PrintDetails());

            truck1.UpdateWeight();
            Console.WriteLine("After +10%:");
            Console.WriteLine(truck1.PrintDetails());
        }
    }
    // מחלקת בסיס
    
 
    class Vehicle
    {
        private int id;
        protected string driverName;

        public Vehicle(int id, string driverName)
        {
            this.id = id;
            this.driverName = driverName;
        }

        public virtual string PrintDetails()
        {
            return "Driver Name: " + driverName;
        }
    }

    // מחלקה יורשת
    class Truck : Vehicle
    {
        protected double maxWeight;

        public Truck(int id, string driverName, double maxWeight)
            : base(id, driverName)
        {
            this.maxWeight = maxWeight;
        }

        public override string PrintDetails()
        {
            return "Driver Name: " + driverName +
                   ", Max Weight: " + maxWeight;
        }
    }

    // מחלקה יורשת נוספת
    class HeavyTruck : Truck
    {
        private string hazardousMaterial;

        public HeavyTruck(int id, string driverName, double maxWeight, string hazardousMaterial)
            : base(id, driverName, maxWeight)
        {
            this.hazardousMaterial = hazardousMaterial;
        }

        public override string PrintDetails()
        {
            return "Driver Name: " + driverName +
                   ", Max Weight: " + maxWeight +
                   ", Hazardous Material: " + hazardousMaterial;
        }

        // Overload ראשון
        public void UpdateWeight(double newWeight)
        {
            maxWeight = newWeight;
        }

        // Overload שני
        public void UpdateWeight()
        {
            maxWeight = maxWeight * 1.10;
        }
    }


}
