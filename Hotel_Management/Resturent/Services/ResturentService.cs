using Resturent.Data;
using System.Reflection;

namespace Resturent.Services
{
    public class ResturentService : IResturentService
    {
        public List<Models.Resturent> GetResturents()
        {
            return ResturentMockDataService.Resturents;
        }

        public Models.Resturent? GetResturent(int id)
        {
            return ResturentMockDataService.Resturents.FirstOrDefault(x => x.foodId == id);
        }

        public Models.Resturent? AddResturent(Models.Resturent resturent)
        {
            ResturentMockDataService.Resturents.Add(resturent);
            return resturent;
        }

        public Models.Resturent? UpdateResturent(Models.Resturent resturent)
        {
            Models.Resturent selectedResturent = ResturentMockDataService.Resturents.FirstOrDefault(x => x.foodId == resturent.foodId);
            if (selectedResturent != null)
            {
                selectedResturent.category = resturent.category;
                selectedResturent.price = resturent.price;
                selectedResturent.foodName = resturent.foodName;
                return selectedResturent;
            }

            return selectedResturent;
        }

        public bool? DeleteResturent(int id)
        {
            Models.Resturent selectedResturent = ResturentMockDataService.Resturents.FirstOrDefault(x => x.foodId == id);
            if (selectedResturent != null)
            {
                ResturentMockDataService.Resturents.Remove(selectedResturent);
                return true;
            }
            return false;
        }
    }
}
