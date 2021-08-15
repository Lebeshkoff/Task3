using System;
using System.Collections.Generic;

namespace Eatery
{
    [Serializable]
    /// <summary>
    /// Order
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Client
        /// </summary>
        public Client<int> Client { get; private set; }
        /// <summary>
        /// All dishes
        /// </summary>
        public List<Dish> dishes = new();

        /// <summary>
        /// Date of order
        /// </summary>
        public DateTime Date { get; private set; }

        //public List<Drink> drinks = new();

        /// <summary>
        /// Price of order
        /// </summary>
        private int totalPrice;
        /// <summary>
        /// Craete new order 
        /// </summary>
        /// <param name="date">Current date</param>
        /// <param name="client">Client</param>
        public Order(DateTime date, Client<int> client)
        {
            Client = client;
            Date = date;
            totalPrice = 0;
        }

        /// <summary>
        /// Add dish to order
        /// </summary>
        /// <param name="dish">Dish</param>
        public void AddDish(Dish dish)
        {
            dishes.Add(dish);
        }

        /// <summary>
        /// Calculate total price
        /// </summary>
        private void CalculatePrice()
        {
            foreach (var dish in dishes)
            {
                totalPrice += dish.Cost;
            }
            //foreach (var drink in drinks)
            //{
            //    TotalPrice += drink.Cost;
            //}
        }
        //public void AddDrink(Drink drink)
        //{
        //    drinks.Add(drink);
        //}

        /// <summary>
        /// Get total price
        /// </summary>
        /// <returns>Price(int)</returns>
        public int GetTotalPrice()
        {
            CalculatePrice();
            return totalPrice;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj as Order == null) return false;
            return Client == ((Order)obj).Client &&
                Date == ((Order)obj).Date &&
                dishes.Equals(((Order)obj).dishes);
        }

        public override int GetHashCode()
        {
            return Client.GetHashCode() ^ Date.GetHashCode() ^ dishes.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
