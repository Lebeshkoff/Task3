using System;
using System.Collections.Generic;
using Eatery.Processings;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eatery
{
    public class Eatery
    {
        public List<Order> ordersHistory = new();
        private List<Order> ordersQueue = new();
        protected List<Ingridient> Ingridients { get; private set; }
        public List<Order> OrdersInProcess { get; private set; }
        public string Name { get; private set; }
        public int OrderPower { get; protected set; }

        public Eatery(string name, int orderPower)
        {
            Name = name;
            OrderPower = orderPower;
        }

        public int GetFreePower()
        {
            return OrderPower - OrdersInProcess.Count;
        }

        public List<Ingridient> GetIngridients()
        {
            return Ingridients;
        }

        public List<Order> GetOrdersByDate(DateTime date1, DateTime date2)
        {
            return ordersHistory.FindAll(x => x.Date > date1 && x.Date < date2);
        }

        public Dictionary<Ingridient,int> GetPopularIngridients()
        {
            var result = new Dictionary<Ingridient, int>();
            foreach (var order in ordersHistory)
            {
                foreach (var dish in order.dishes)
                {
                    foreach (var ingridient in dish.Recipe.Ingridients)
                    {
                        if (result.ContainsKey(ingridient.Key))
                        {
                            result[ingridient.Key]++;
                        }
                        else
                        {
                            result.Add(ingridient.Key, 0);
                        }
                    }
                }
            }
            return result;
        }

        public List<Ingridient> GetIngridientsByStorageTemperature(int storageTemperature)
        {
            return Ingridients.FindAll(x => x.StorageTemperature == storageTemperature);
        }
    }
}
