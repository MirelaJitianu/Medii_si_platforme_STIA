using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    /// <summary>
    /// Subject abstract class
    /// </summary>
    abstract class Drinks
    {
        private int _caloriesPerDrink;
        private List<IRestaurant> _restaurants = new List<IRestaurant>();

        public Drinks(int caloriesPerDrink)
        {
            _caloriesPerDrink = caloriesPerDrink;
        }

        public void Attach(IRestaurant restaurant)
        {
            _restaurants.Add(restaurant);
        }

        public void Detach(IRestaurant restaurant)
        {
            _restaurants.Remove(restaurant);
        }

        public void Notify()
        {
            foreach (IRestaurant restaurant in _restaurants)
            {
                restaurant.Update(this);
            }

            Console.WriteLine("Next Drinks:");
        }

        public int CaloriesPerDrink
        {
            get { return _caloriesPerDrink; }
            set
            {
                if (_caloriesPerDrink != value)
                {
                    _caloriesPerDrink = value;
                    Notify();
                }
            }
        }
    }

    /// <summary>
    /// ConcreteSubject class
    /// </summary>
    class Drink : Drinks
    {
        public Drink(int calories) : base(calories)
        {
        }
    }

    /// <summary>

    /// </summary>
    interface IRestaurant
    {
        void Update(Drinks Drinks);
    }

    /// <summary>
    /// ConcreteObserver class
    /// </summary>
    class Restaurant : IRestaurant
    {
        private string _name;
        private double _purchaseThreshold;

        public Restaurant(string name, double purchaseThreshold)
        {
            _name = name;
            _purchaseThreshold = purchaseThreshold;
        }

        public void Update(Drinks drink)
        {
            Console.WriteLine("Restaurant's {0} = {1}'s " + " calories : " + drink.CaloriesPerDrink + "", _name, drink.GetType().Name, drink.CaloriesPerDrink);
          
        }
    }
}
