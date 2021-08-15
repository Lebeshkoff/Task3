using System;
using System.Collections.Generic;
using Eatery.Processings;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eatery
{
    /// <summary>
    /// Eatery
    /// </summary>
    public class Eatery
    {
        /// <summary>
        /// Order history
        /// </summary>
        public List<Order> ordersHistory = new();
        /// <summary>
        /// Current queue 
        /// </summary>
        private List<Order> ordersQueue = new();
        /// <summary>
        /// Ingridients aviable
        /// </summary>
        protected List<Ingridient> Ingridients { get; private set; }
        /// <summary>
        /// Cooking orders
        /// </summary>
        public List<Order> OrdersInProcess { get; private set; }
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// Production capacity
        /// </summary>
        public int OrderPower { get; protected set; }
        /// <summary>
        /// Chef
        /// </summary>
        public Chef Chef { get; set; }

        /// <summary>
        /// Create eatery
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="orderPower">Production capacity</param>
        /// <param name="chef">Chef</param>
        public Eatery(string name, int orderPower, Chef chef)
        {
            Name = name;
            OrderPower = orderPower;
            Chef = chef;
        }

        /// <summary>
        /// Get free production capacity
        /// </summary>
        /// <returns></returns>
        public int GetFreePower()
        {
            return OrderPower - OrdersInProcess.Count;
        }

        /// <summary>
        /// Get aviable ingridients
        /// </summary>
        /// <returns></returns>
        public List<Ingridient> GetIngridients()
        {
            return Ingridients;
        }

        /// <summary>
        /// Get orders sorted by dates
        /// </summary>
        /// <param name="date1">Left date </param>
        /// <param name="date2">Right date</param>
        /// <returns></returns>
        public List<Order> GetOrdersByDate(DateTime date1, DateTime date2)
        {
            return ordersHistory.FindAll(x => x.Date > date1 && x.Date < date2);
        }

        /// <summary>
        /// Get popular ingridients in history
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Get ingridients by storage temperature
        /// </summary>
        /// <param name="storageTemperature">Storage temperature</param>
        /// <returns></returns>
        public List<Ingridient> GetIngridientsByStorageTemperature(int storageTemperature)
        {
            return Ingridients.FindAll(x => x.StorageTemperature == storageTemperature);
        }

        public void CookOrder()
        {
            foreach (var order in OrdersInProcess)
            {
                order
            }
        }
    }
}
