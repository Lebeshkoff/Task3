using System;
using System.Collections.Generic;
using Eatery.Processings;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using Eatery.Ingridients;

namespace Eatery
{
    [KnownType(typeof(Tomato))]
    [KnownType(typeof(Cucumber))]
    [KnownType(typeof(Salt))]
    [KnownType(typeof(Onion))]
    [KnownType(typeof(ShreddingProcess))]
    [KnownType(typeof(AddProcess))]
    [Serializable]
    /// <summary>
    /// Eatery
    /// </summary>
    public class EateryManager
    {
        /// <summary>
        /// Order history
        /// </summary>
        public List<Order> ordersHistory = new();
        /// <summary>
        /// Current queue 
        /// </summary>
        public List<Order> ordersQueue = new();
        /// <summary>
        /// Ingridients aviable
        /// </summary>
        public List<Ingridient> Ingridients { get; private set; }
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
        public EateryManager(string name, int orderPower, Chef chef)
        {
            Ingridients = new List<Ingridient>();
            OrdersInProcess = new();
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

        public void SaveEateryToJSON(string path)
        {
            var memoryStream = new MemoryStream();
            DataContractJsonSerializer data = new DataContractJsonSerializer(typeof(EateryManager));
            data.WriteObject(memoryStream, this);
            memoryStream.Position = 0;
            using Stream s = File.Create(path);
            memoryStream.CopyTo(s);
        }

        public static EateryManager LoadEateryFromJSON(string path)
        {
            DataContractJsonSerializer data = new DataContractJsonSerializer(typeof(EateryManager));
            var fileStream = new FileStream(path, FileMode.Open)
            {
                Position = 0
            };
            return (EateryManager)data.ReadObject(fileStream);
        }

        public void CreateOrder(Client<int> client, params Dish[] dishes)
        {
            var order = new Order(DateTime.Now, client);
            foreach (var dish in dishes)
            {
                order.AddDish(dish);
            }
            order.GetTotalPrice();
            ordersQueue.Add(order);
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj as EateryManager == null) return false;
            return Name == ((EateryManager)obj).Name &&
                OrderPower == ((EateryManager)obj).OrderPower &&
                OrdersInProcess.Equals(((EateryManager)obj).OrdersInProcess) &&
                ordersHistory.Equals(((EateryManager)obj).ordersHistory) &&
                ordersQueue.Equals(((EateryManager)obj).ordersQueue);
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() ^ OrderPower.GetHashCode() ^
                OrdersInProcess.GetHashCode() ^ ordersHistory.GetHashCode() ^
                ordersQueue.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
