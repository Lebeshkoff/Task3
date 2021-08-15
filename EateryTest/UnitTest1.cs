using System;
using Xunit;
using Eatery;
using System.Collections.Generic;
using Eatery.Processings;
using Eatery.Ingridients;

namespace EateryTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var c = new Chef("Roman");
            var e = new EateryManager("Eatery", 3, c);
            for (int i = 0; i < 10; i++)
            {
                e.Ingridients.Add(new Tomato(10, 10));
            }
            var re = new Dictionary<Ingridient, Processing>();
            re.Add(new Cucumber(10, 2), new ShreddingProcess(10, 10));
            re.Add(new Tomato(10, 4), new ShreddingProcess(10, 10));
            re.Add(new Onion(20, 6), new ShreddingProcess(20, 20));
            re.Add(new Salt(25, 1), new AddProcess(2, 2));
            var r = c.CreateRecipe(re, "Salat iz pomidora");
            var d = new Dish("Salat iz pomidora alya frace", r, 40);
            var cl = new Client<int>(1234);
            e.CreateOrder(cl, d, d, d, d);
            e.SaveEateryToJSON("json.json");
            var k = EateryManager.LoadEateryFromJSON("json.json");
            if(e == k)
            {
                
            }
        }
    }
}
