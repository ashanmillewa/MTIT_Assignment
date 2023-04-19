namespace Resturent.Data
{
    public class ResturentMockDataService
    {
        public static List<Models.Resturent> Resturents = new List<Models.Resturent>()
        {
            new Models.Resturent { foodId = 1, foodName = "Sandwiches", category = "Breakfast ", price = 450},
            new Models.Resturent { foodId = 2, foodName = "Rice and Curr ", category = "Lunch ", price = 650 },
            new Models.Resturent { foodId = 3, foodName = "Fride Rice ", category = "Dinner ", price = 1200 },
            new Models.Resturent { foodId = 4, foodName = "Ice Cream ", category = "Desserts ", price = 200 },
            new Models.Resturent { foodId = 5, foodName = "Soups ", category = "Appetizers ", price =500 }
        };
    }
}
