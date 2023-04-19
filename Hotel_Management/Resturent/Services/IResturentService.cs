namespace Resturent.Services
{
    public interface IResturentService
    {
        List<Models.Resturent> GetResturents();
        Models.Resturent? GetResturent(int id);
        Models.Resturent? AddResturent(Models.Resturent resturent);
        Models.Resturent? UpdateResturent(Models.Resturent resturent);
        bool? DeleteResturent(int id);

    }
}
