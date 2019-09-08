using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_MPDA
{
    class Program
    {
        static void Main(string[] args)
        {
            var colas = new Cola(210);

            var lemonLime = new LemonLime(185);

            var rootBeers = new RootBeer(195);

            SodaWater sodaWater = new SodaWater(180);
            sodaWater.Flavors.Add(colas);
            sodaWater.Flavors.Add(lemonLime);
            sodaWater.Flavors.Add(rootBeers);

            sodaWater.DisplayCalories();
            Console.WriteLine();


            // Threshold pentru calorii
            Drink drinks = new Drink(0);
            drinks.Attach(new Restaurant("Andrei", 185));
            drinks.Attach(new Restaurant("Razvan", 180));
            drinks.Attach(new Restaurant("Marius", 210));

        }
    }
}
