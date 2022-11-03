using System;
namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public Car()
        {
        }

        public double EngineSize { get; set; } = 5.0;
        public string Model { get; set; } = "Charger";
        public string Make { get; set; } = "Dodge";
        public int SeatCount { get; set; } = 4;
        public string CompanyName { get; set; } = "Dodge";
        public string Motto { get; set; } = "Domestic. Not Domesticated.";
        public bool HasChangedGears { get; set; }

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} now driving forward..");
        }

      
        public void Reverse()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now driving forward..");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Cannot reverse until we change gears");
            }
        }

        public void Park()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now driving forward..");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Cannot reverse until we change gears");
            }
        }


        public void ChangeGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }
    }
}

