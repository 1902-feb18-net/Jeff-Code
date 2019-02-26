using System;
using System.Collections.Generic;
using System.Text;

namespace MoreAnimals.Library
{
    public  interface IAnimal
    {
        void MakeNoise();
        void GoTo(string location);

        int AnimalId { get; set; }
        string Name { get; set; }
    }
}
