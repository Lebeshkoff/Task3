using System;
using System.Collections.Generic;

namespace Eatery
{
    public class Order
    {
        public Client<int> Client { get; private set; }

        public List<Dish> dishes = new();

        public DateTime Date { get; private set; }

        //public List<Drink> drinks = new();
        private int totalPrice;
        public Order(DateTime date, Client<int> client)
        {
            Client = client;
            Date = date;
            totalPrice = 0;
        }

        public void AddDish(Dish dish)
        {
            dishes.Add(dish);
        }
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
        public int GetTotalPrice()
        {
            CalculatePrice();
            return totalPrice;
        }
    }
}
