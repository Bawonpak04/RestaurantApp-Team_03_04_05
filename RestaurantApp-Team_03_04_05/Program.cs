using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp_Team_03_04_05
{
    class Restaurant
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public double Rating { get; set; }
    }

    internal class Program
    {
        static List<Restaurant> restaurants = new List<Restaurant> 
    {
        new Restaurant { Name = "Mcdonal's", Type = "Fast Food", Rating = 4.2 },
        new Restaurant { Name = "Teenoi", Type = "Suki", Rating = 4.7 },
        new Restaurant { Name = "Fuji", Type = "Japanese", Rating = 4.8 },
        new Restaurant { Name = "KFC", Type = "Fast Food", Rating = 3.5 },
        new Restaurant { Name = "MK", Type = "Suki", Rating = 4.2 },
        new Restaurant { Name = "Hachiban", Type = "Japanese", Rating = 5 },
    };

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n===== Restaurant Menu =====");
                Console.WriteLine("1. Add Restaurant");
                Console.WriteLine("2. Show Good Rating");
                Console.WriteLine("3. Show Summary");
                Console.WriteLine("0. Exit");
                Console.Write("Select Menu: ");

                string menu = Console.ReadLine();

                switch (menu)
                {
                    case "1":
                        AddRestaurant();
                        break;
                    case "2":
                        ShowGoodRating();
                        break;
                    case "3":
                        ShowSummary();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Invalid Menu");
                        break;
                }
            }
        }

        // คน A รับผิดชอบ
        static void AddRestaurant()
        {
            foreach (var restaurant in restaurants)
            {
                Console.WriteLine(restaurant.Name+ " - " + restaurant.Type + " - " + restaurant.Rating);
            }
        }

        // คน B รับผิดชอบ
        static void ShowGoodRating()
        {
            Console.WriteLine("Not completed");
            var goodRestaurants = restaurants
        .Where(r => r.Rating >= 4.5);


            foreach (var restaurant in goodRestaurants)
            {
                Console.WriteLine(restaurant.Name +
                                  " คะแนน: " + restaurant.Rating);
            }
        }

        // คน C รับผิดชอบ
        static void ShowSummary()
        {
            if (restaurants.Count == 0)
            {
                Console.WriteLine("No restaurant data");
                return;
            }

            var highest = restaurants.OrderByDescending(r => r.Rating).First();
            var lowest = restaurants.OrderBy(r => r.Rating).First();

            Console.WriteLine("ร้านคะแนนสูงสุด: " + highest.Name +
                              " คะแนน: " + highest.Rating);

            Console.WriteLine("ร้านคะแนนต่ำสุด: " + lowest.Name +
                              " คะแนน: " + lowest.Rating);
        }
    }

}
