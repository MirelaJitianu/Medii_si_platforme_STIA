
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            var colas = new Cola(210);

            var lemonLime = new LemonLime(185);

            var rootBeers = new RootBeer(195);

            SodaWater sodaWater = new SodaWater(188);
            sodaWater.Flavors.Add(colas);
            sodaWater.Flavors.Add(lemonLime);
            sodaWater.Flavors.Add(rootBeers);

            sodaWater.DisplayCalories();
            Console.WriteLine();


            // Threshold pentru calorii
            Drink drinks = new Drink(0);
            drinks.Attach(new Restaurant("Andrei", 185));
            drinks.Attach(new Restaurant("Razvan", 188));
            drinks.Attach(new Restaurant("Marius", 210));


            // Calorii bauturi
            drinks.CaloriesPerDrink = 210; // Cola
            drinks.CaloriesPerDrink = 185; // LemonLime
            drinks.CaloriesPerDrink = 195; // RootBeer
            drinks.CaloriesPerDrink = 180; // SodaWater
            Console.ReadKey();
        }
    }
}
