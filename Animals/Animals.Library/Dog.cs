using System;

namespace Animals.Library

{
    public class Dog
    {
        internal string Noise = "Woof!";

        public string getNoise()
        {
            return Noise + "!";
        }

        public void setNoise(string newValue)
        {
            if(newValue == null || newValue.Length == 0)
            {
                throw new ArgumentException("Value must not be null or empty");
            }
            Noise == newValue;
        }
        public void GoTo(string location)
        {
            Console.WriteLine($"Walking to {location}");

            //Console.WriteLine($"Walking to {location}");
        }
        
        public void MakeNoise()
        {
            Console.WriteLine(Noise);
        }
       
    }
}